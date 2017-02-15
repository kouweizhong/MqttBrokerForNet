﻿/*
Copyright (c) 2013, 2014 Paolo Patierno

All rights reserved. This program and the accompanying materials
are made available under the terms of the Eclipse Public License v1.0
and Eclipse Distribution License v1.0 which accompany this distribution. 

The Eclipse Public License is available at 
   http://www.eclipse.org/legal/epl-v10.html
and the Eclipse Distribution License is available at 
   http://www.eclipse.org/org/documents/edl-v10.php.

Contributors:
   Paolo Patierno - initial API and implementation and/or initial documentation
   David Kristensen - optimalization for the azure platform
*/

namespace MqttBrokerForNet.Domain.Entities
{
    using System;

    /// <summary>
    /// MQTT client connected event args
    /// </summary>
    public class MqttClientConnectedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connection">Connected client</param>
        public MqttClientConnectedEventArgs(MqttConnection connection)
        {
            this.Connection = connection;
        }

        /// <summary>
        /// Connected client
        /// </summary>
        public MqttConnection Connection { get; private set; }
    }
}
