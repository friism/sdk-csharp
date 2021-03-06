﻿// Copyright (c) Cloud Native Foundation. 
// Licensed under the Apache 2.0 license.
// See LICENSE file in the project root for full license information.

namespace CloudNative.CloudEvents.Mqtt
{
    using MQTTnet;
    using MQTTnet.Client;
 
    public static class MqttClientExtensions
    {
        public static CloudEvent ToCloudEvent(this MqttApplicationMessage message,
            ICloudEventFormatter eventFormatter, params ICloudEventExtension[] extensions)
        {
            return eventFormatter.DecodeStructuredEvent(message.Payload, extensions);
        }
    }
}