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
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Core.Servers;

namespace MongoDB.Driver.Core.Events
{
    /// <preliminary/>
    /// <summary>
    /// Represents information about a ServerAfterOpening event.
    /// </summary>
    public struct ServerAfterOpeningEvent
    {
        private readonly ServerId _serverId;
        private readonly ServerSettings _serverSettings;
        private readonly TimeSpan _elapsed;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerAfterOpeningEvent"/> struct.
        /// </summary>
        /// <param name="serverId">The server identifier.</param>
        /// <param name="serverSettings">The server settings.</param>
        /// <param name="elapsed">The elapsed time.</param>
        public ServerAfterOpeningEvent(ServerId serverId, ServerSettings serverSettings, TimeSpan elapsed)
        {
            _serverId = serverId;
            _serverSettings = serverSettings;
            _elapsed = elapsed;
        }

        /// <summary>
        /// Gets the elapsed time.
        /// </summary>
        /// <value>
        /// The elapsed time.
        /// </value>
        public TimeSpan Elapsed
        {
            get { return _elapsed; }
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

        /// <summary>
        /// Gets the server settings.
        /// </summary>
        /// <value>
        /// The server settings.
        /// </value>
        public ServerSettings ServerSettings
        {
            get { return _serverSettings; }
        }
    }
}
