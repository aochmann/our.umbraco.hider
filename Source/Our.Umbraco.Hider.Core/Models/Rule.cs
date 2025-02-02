﻿namespace Our.Umbraco.Hider.Core.Models
{
    public class Rule
    {
        public string Type { get; set; }

        public bool Enabled { get; set; }

        public string Names { get; set; }

        public string UserGroups { get; set; }

        public string Users { get; set; }

        public string ContentIds { get; set; }

        public string ParentContentIds { get; set; }

        public string ContentTypes { get; set; }

        public string Description { get; set; }
    }
}