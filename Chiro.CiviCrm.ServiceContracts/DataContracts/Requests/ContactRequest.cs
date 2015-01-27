﻿/*
   Copyright 2015 Chirojeugd-Vlaanderen vzw

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
using System.Collections.Generic;
using Chiro.CiviCrm.Api.Converters;
using Chiro.CiviCrm.BehaviorExtension;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Chiro.CiviCrm.Api.DataContracts.Requests
{
    [CiviRequest]
    public class ContactRequest: BaseRequest
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("external_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalIdentifier { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("contact_type", NullValueHandling = NullValueHandling.Ignore)]
        public ContactType? ContactType { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("middle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("organization_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        [JsonProperty("gender_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(NullableEnumConverter))]
        public Gender? Gender { get; set; }

        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BirthDate { get; set; }

        [JsonProperty("deceased_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeceasedDate { get; set; }

        [JsonProperty("preferred_mail_format", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public MailFormat? PreferredMailFormat { get; set; }

        #region chaining
        [JsonProperty("api.address.get", NullValueHandling = NullValueHandling.Ignore)]
        public BaseRequest AddressGetRequest { get; set; }

        [JsonProperty("api.phone.get", NullValueHandling = NullValueHandling.Ignore)]
        public BaseRequest PhoneGetRequest { get; set; }

        [JsonProperty("api.phone.create", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseRequest> PhoneSaveRequest { get; set; }

        [JsonProperty("api.email.get", NullValueHandling = NullValueHandling.Ignore)]
        public BaseRequest EmailGetRequest { get; set; }

        [JsonProperty("api.website.get", NullValueHandling = NullValueHandling.Ignore)]
        public BaseRequest WebsiteGetRequest { get; set; }

        [JsonProperty("api.website.create", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseRequest> WebsiteSaveRequest { get; set; }

        [JsonProperty("api.im.get", NullValueHandling = NullValueHandling.Ignore)]
        public BaseRequest ImGetRequest { get; set; }
        #endregion
    }
}
