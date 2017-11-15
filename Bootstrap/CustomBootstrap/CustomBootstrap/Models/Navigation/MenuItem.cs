﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomBootstrap.Models.Navigation
{
    public class MenuItem
    {

        public MenuItem(string text, string uri)
        {
            Id = Guid.NewGuid();
            Text = text;
            Link = new Uri(uri);
            SubMenuItems = null;
        }

        public Guid Id { get; set; }

        public string Text { get; set; }

        public Uri Link { get; set; }

        public IEnumerable<MenuItem> SubMenuItems { get; set; }
    }
}