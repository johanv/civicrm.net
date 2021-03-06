﻿using System;
using System.ServiceModel.Dispatcher;
using Chiro.CiviCrm.Api.DataContracts;
using Newtonsoft.Json;
/*
   Copyright 2013, 2014, 2015 Chirojeugd-Vlaanderen vzw

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

namespace Chiro.CiviCrm.BehaviorExtension
{
    /// <summary>
    /// QueryStringConverter able to convert to Json.
    /// </summary>
    public class JsonQueryStringConverter: QueryStringConverter
    {
        public override bool CanConvert(Type type)
        {
            return (Attribute.GetCustomAttribute(type, typeof(CiviRequestAttribute)) != null)
                || base.CanConvert(type);
        }

        public override object ConvertStringToValue(string parameter, Type parameterType)
        {
            if (Attribute.GetCustomAttribute(parameterType, typeof(CiviRequestAttribute)) != null)
            {
                // We don't need this client side. So I won't bother.
                throw new NotImplementedException();
            }
            return base.ConvertStringToValue(parameter, parameterType);
        }

        public override string ConvertValueToString(object parameter, Type parameterType)
        {
            if (Attribute.GetCustomAttribute(parameterType, typeof (CiviRequestAttribute)) == null)
            {
                // No CiviCRM request. Just convert as usual.
                return base.ConvertValueToString(parameter, parameterType);
            }

            string json = JsonConvert.SerializeObject(parameter);
            return json;
        }
    }
}
