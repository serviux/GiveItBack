using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiveItBack.Models;

namespace GiveItBack.ViewModels.Home
{
    public class ShowItemsViewModel
    {
        public IEnumerable<Item> ItemsList { get; set; }
        public ShowItemsViewModel( Item[] items)
        {
            ItemsList = items;
        }
        
    }
}