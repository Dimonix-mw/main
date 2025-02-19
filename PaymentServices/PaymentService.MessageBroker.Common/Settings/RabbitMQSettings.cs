﻿namespace PaymentService.MessageBroker.Common.Settings
{
    public class RabbitMQSettings
    {
        public string? Hostname { get; set; }
        public string? CreateFillingMQ { get; set; }
        public string? UpdateFillingMQ { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? VirtualHost { get; set; }
    }
}
