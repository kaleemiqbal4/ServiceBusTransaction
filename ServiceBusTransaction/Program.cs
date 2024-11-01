using Azure.Messaging.ServiceBus;
using System.Transactions;

public class Program
{
    public static async Task Main(string[] args)
    {
        ServiceBusTransActionClass serviceBusTransActionClass = new ServiceBusTransActionClass();
       await serviceBusTransActionClass.SBTransAction();
        Console.ReadLine();
    }
}

public class ServiceBusTransActionClass
{
    public async Task SBTransAction()
    {
        await using var client = new ServiceBusClient("<Connection>");

        // Create Sender
        ServiceBusSender sender = client.CreateSender("<QueueName>");
        // Send Message

        await sender.SendMessageAsync(new ServiceBusMessage("this is message is to test transaction in service bus queue"));

        // Create Receiver
        ServiceBusReceiver receiver = client.CreateReceiver("<QueueName>");

        ServiceBusReceivedMessage rcvd = await receiver.ReceiveMessageAsync();
        using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            await sender.SendMessageAsync(new ServiceBusMessage("Inside the transaction in service bus queue"));
            await receiver.CompleteMessageAsync(rcvd);
            ts.Complete();
        }
    }
}