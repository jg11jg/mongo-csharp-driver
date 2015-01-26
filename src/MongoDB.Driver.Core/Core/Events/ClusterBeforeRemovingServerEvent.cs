﻿/* Copyright 2013-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Net;
using MongoDB.Driver.Core.Clusters;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Core.Servers;

namespace MongoDB.Driver.Core.Events
{
    /// <preliminary/>
    /// <summary>
    /// Represents information about a ClusterBeforeRemovingServer event.
    /// </summary>
    public struct ClusterBeforeRemovingServerEvent
    {
        private readonly ServerId _serverId;
        private readonly string _reason;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterBeforeRemovingServerEvent"/> struct.
        /// </summary>
        /// <param name="serverId">The server identifier.</param>
        /// <param name="reason">The reason the server is being removed.</param>
        public ClusterBeforeRemovingServerEvent(ServerId serverId, string reason)
        {
            _serverId = serverId;
            _reason = reason;
        }

        /// <summary>
        /// Gets the reason the server is being removed.
        /// </summary>
        /// <value>
        /// The reason the server is being removed.
        /// </value>
        public string Reason
        {
            get { return _reason; }
        }

        /// <summary>
        /// Gets the server identifier.
        /// </summary>
        /// <value>
        /// The server identifier.
        /// </value>
        public ServerId ServerId
        {
            get { return _serverId; }
        }
    }
}
