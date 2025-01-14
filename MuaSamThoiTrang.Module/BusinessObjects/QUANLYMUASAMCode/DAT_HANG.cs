﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{
    [DefaultClassOptions]

    public partial class DAT_HANG
    {
        public DAT_HANG(Session session) : base(session) { }
        public override void AfterConstruction()
        { base.AfterConstruction();
            if (Session.IsNewObject(this))
            {
                NgayDH = DateTime.Now;
            }
        }
    }

}
