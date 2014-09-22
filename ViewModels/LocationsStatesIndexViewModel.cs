﻿using OShop.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OShop.ViewModels {
    public class LocationsStatesIndexViewModel {
        public IEnumerable<LocationsCountryRecord> Countries { get; set; }
        public IEnumerable<LocationsStateRecord> States { get; set; }

        public dynamic Pager { get; set; }
        public LocationsBulkAction BulkAction { get; set; }
        public LocationsFilter Filter { get; set; }

        public bool ShippingEnabled { get; set; }
        public IEnumerable<ShippingZoneRecord> ShippingZones { get; set; }
        public int CountryId { get; set; }
        public int ZoneId { get; set; }
        public int BulkZoneId { get; set; }
    }
}