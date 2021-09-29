using AzureSpeed.Web.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSpeed.Web.Shared.Data
{
    public class EndpointsProvider
    {

        public List<StorageEndpoint> GetStorageEnpoints()
        {
            var endpoints = new List<StorageEndpoint>();

            endpoints.Add(new StorageEndpoint() { Location = "West Europe", Name = "westeurope", Url = "https://azspeedwesteurope001.blob.core.windows.net/public/speed-test.json", Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/nl.svg" });
            
            endpoints.Add(new StorageEndpoint() { 
                Location = "East US", 
                Name = "eastus", 
                Url = "https://azspeedeastus001.blob.core.windows.net/public/speed-test.json", 
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg" 
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "East US 2",
                Name = "eastus2",
                Url = "https://azspeedeastus2001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "South Central US",
                Name = "southcentralus",
                Url = "https://azspeedsouthcentralus001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "West US 2",
                Name = "westus2",
                Url = "https://azspeedwestus2001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "West US 3",
                Name = "westus3",
                Url = "https://azspeedwestus3001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Australia East",
                Name = "australiaeast",
                Url = "https://azspeedaustraliaeast001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/au.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Southeast Asia",
                Name = "southeastasia",
                Url = "https://azspeedsoutheastasia001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/au.svg"
            });
            
            endpoints.Add(new StorageEndpoint()
            {
                Location = "North Europe",
                Name = "northeurope",
                Url = "https://azspeednortheurope001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/ie.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "UK South",
                Name = "uksouth",
                Url = "https://azspeeduksouth001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/gb.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Central US",
                Name = "centralus",
                Url = "https://azspeedcentralus001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "North Central US",
                Name = "northcentralus",
                Url = "https://azspeednorthcentralus001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });
            
            endpoints.Add(new StorageEndpoint()
            {
                Location = "West US",
                Name = "westus",
                Url = "https://azspeedwestus001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "South Africa North",
                Name = "southafricanorth",
                Url = "https://azspeedsanorth001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/za.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Central India",
                Name = "centralindia",
                Url = "https://azspeedcentralindia001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/in.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "East Asia",
                Name = "eastasia",
                Url = "https://azspeedeastasia001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/za.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "East Asia",
                Name = "eastasia",
                Url = "https://azspeedjapaneast001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/hk.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Korea Central",
                Name = "koreacentral",
                Url = "https://azspeedkoreacentral001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/kr.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Canada Central",
                Name = "canadacentral",
                Url = "https://azspeedcanadacentral001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/ca.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "France Central",
                Name = "francecentral",
                Url = "https://azspeedfrancecentral001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/fr.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Germany West Central",
                Name = "germanywestcentral",
                Url = "https://azspeedgewestcentral001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/fr.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Norway East",
                Name = "norwayeast",
                Url = "https://azspeednorwayeast001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/no.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Switzerland North",
                Name = "switzerlandnorth",
                Url = "https://azspeednswnorth001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/ch.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "UAE North",
                Name = "uaenorth",
                Url = "https://azspeeduaenorth001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/ae.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "Brazil South",
                Name = "brazilsouth",
                Url = "https://azspeedbrazilsouth001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/br.svg"
            });

            endpoints.Add(new StorageEndpoint()
            {
                Location = "West Central US",
                Name = "westcentralus",
                Url = "https://azspeedwestcentralus001.blob.core.windows.net/public/speed-test.json",
                Icon = "https://cdn.staticaly.com/gh/hjnilsson/country-flags/master/svg/us.svg"
            });

            return endpoints;
        }

    }
}
