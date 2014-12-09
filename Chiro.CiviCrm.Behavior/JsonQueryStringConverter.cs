﻿/*
   Copyright 2013, 2014 Chirojeugd-Vlaanderen vzw

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
using System.ServiceModel.Dispatcher;
using System.Web.Script.Serialization;

namespace Chiro.CiviCrm.BehaviorExtension
{
    /// <summary>
    /// QueryStringConverter able to convert to Json.
    /// </summary>
    public class JsonQueryStringConverter: QueryStringConverter
    {
        public override bool CanConvert(Type type)
        {
            return (Attribute.GetCustomAttribute(type, typeof(JsonConvertibleAttribute)) != null)
                || base.CanConvert(type);
        }

        public override object ConvertStringToValue(string parameter, Type parameterType)
        {
            if (Attribute.GetCustomAttribute(parameterType, typeof(JsonConvertibleAttribute)) != null)
            {
                // We don't need this client side. So I won't bother.
                throw new NotImplementedException();
            }
            return base.ConvertStringToValue(parameter, parameterType);
        }

        public override string ConvertValueToString(object parameter, Type parameterType)
        {
            if (Attribute.GetCustomAttribute(parameterType, typeof(JsonConvertibleAttribute)) != null)
            {
                var result = new JavaScriptSerializer().Serialize(parameter);
                return result;
            }
            else
            {
                return base.ConvertValueToString(parameter, parameterType);
            }
        }
    }
}