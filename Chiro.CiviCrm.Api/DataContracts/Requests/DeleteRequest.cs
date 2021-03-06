﻿/*
   Copyright 2014 Chirojeugd-Vlaanderen vzw

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */

using System;

namespace Chiro.CiviCrm.Api.DataContracts.Requests
{
    /// <summary>
    /// A request to delete any entity.
    /// </summary>
    [CiviRequest]
    public class DeleteRequest: BaseRequest
    {
        public DeleteRequest() : base() { }
        public DeleteRequest(int id) : this()
        {
            Id = id;
        }

        /// <summary>
        /// The entity type this request is referring to.
        /// </summary>
        public override CiviEntity EntityType
        {
            get { return CiviEntity.Any; }
        }
    }
}
