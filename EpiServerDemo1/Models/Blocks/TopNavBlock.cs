﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDemo1.Models.Blocks
{
    [ContentType(DisplayName = "TopNavBlock", GUID = "d43897c9-9a2e-4011-a9f4-67036c1af1fd", Description = "")]
    public class TopNavBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Parent Page",
            Description = "Select the parent of the pages you want to display",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual PageReference ParentPage { get; set; }

    }
}