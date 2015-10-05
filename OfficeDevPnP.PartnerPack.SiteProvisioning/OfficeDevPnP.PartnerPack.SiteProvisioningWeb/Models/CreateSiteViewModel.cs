﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeDevPnP.PartnerPack.SiteProvisioningWeb.Models
{
    public class CreateSiteViewModel
    {
        [Required(ErrorMessage = "Title is a required field!")]
        [DisplayName("Title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Relative URL is a required field!")]
        [DisplayName("Relative URL")]
        public String RelativeUrl { get; set; }

        [DisplayName("Site Policy")]
        [UIHint("SitePolicy")]
        public String SitePolicy { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Language is a required field!")]
        [DisplayName("Language")]
        [UIHint("LocaleID")]
        public Int32 Language { get; set; }

        [Required(ErrorMessage = "Template is a required field!")]
        [DisplayName("Template")]
        [UIHint("ProvisioningTemplate")]
        public String ProvisioningTemplateUrl { get; set; }

        [DisplayName("Time Zone")]
        public TimeZoneInfo TimeZone { get; set; }
    }
}