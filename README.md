# Azure Service Bus Transaction Example

This project demonstrates how to use Azure Service Bus with transactions in a .NET application. It shows how to send and receive messages to/from a Service Bus queue, while managing message transactions to ensure atomic operations. This is particularly useful for scenarios where you need to guarantee that a series of actions are completed successfully.

## Prerequisites

Before you begin, ensure you have the following:

- **.NET SDK**: Version 5.0 or later installed on your machine. You can download it from the [official .NET website](https://dotnet.microsoft.com/download).
- **Azure Subscription**: An active Azure subscription. If you don’t have one, you can create a free account [here](https://azure.com/free).
- **Azure Service Bus Namespace**: Create a Service Bus namespace in the Azure portal to manage your queues and messages.
- **Queue**: Within your Service Bus namespace, create a queue that will be used to send and receive messages.

## NuGet Packages

Ensure that the following NuGet package is installed in your project:

```bash
dotnet add package Azure.Messaging.ServiceBus
```
## clone code  
```
  git clone https://github.com/kaleemiqbal4/ServiceBusTransaction.git
  cd ServiceBusTransaction
``