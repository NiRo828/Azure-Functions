using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class ServiceBusQueueTriggerCSharp
    {
        private readonly ILogger _logger;

        public ServiceBusQueueTriggerCSharp(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ServiceBusQueueTriggerCSharp>();
        }

        [Function("ServiceBusQueueTriggerCSharp")]
        public void Run([ServiceBusTrigger("QueueNameValue", Connection = "ConnectionValue")] string myQueueItem)
        {
            _logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
