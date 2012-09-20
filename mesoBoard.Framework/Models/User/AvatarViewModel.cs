﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mesoBoard.Data;

namespace mesoBoard.Framework.Models
{
    public class AvatarViewModel
    {
        public User CurrentUser { get; set; }

        public AvatarType AvatarType { get; set; }

        public int WidthMax { get; set; }

        public int HeightMax { get; set; }

        public string Url { get; set; }

        public HttpPostedFileBase Image { get; set; }
    }
}