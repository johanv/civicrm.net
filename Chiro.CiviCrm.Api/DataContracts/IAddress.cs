/*
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

namespace Chiro.CiviCrm.Api.DataContracts
{
    /// <summary>
    /// Just an address interface that allows you to access both
    /// Addresses and AddressRequests.
    /// </summary>
    public interface IAddress
    {
        string StreetAddress { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        string PostalCodeSuffix { get; set; }
        int? StateProvinceId { get; set; }
        int? CountryId { get; set; }
        string Country { get; set; }
        string Name { get; set; }
    }
}