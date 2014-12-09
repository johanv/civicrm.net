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

using Chiro.CiviCrm.BehaviorExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chiro.CiviCrm.Api.DataContracts
{
    /// <summary>
    /// Some class that basically converts an ID to the json-part of the request url.
    /// </summary>
    [JsonConvertible]
    public class CiviId
    {
        public int id { get; set; }
        public int sequential { get; set; }

        public CiviId(int id)
        {
            this.id = id;
            this.sequential = 1;
        }
    }
}
