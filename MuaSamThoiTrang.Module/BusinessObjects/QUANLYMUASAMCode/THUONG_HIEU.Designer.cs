﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{
    [System.ComponentModel.DisplayName("Thương hiệu")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [DefaultProperty("TenTH")]

    public partial class THUONG_HIEU : XPObject
    {
        string fMaTH;
        [XafDisplayName("Mã thương hiệu")]
        public string MaTH
        {
            get { return fMaTH; }
            set { SetPropertyValue<string>(nameof(MaTH), ref fMaTH, value); }
        }
        string fTenTH;
        [XafDisplayName("Tên thương hiệus")]
        public string TenTH
        {
            get { return fTenTH; }
            set { SetPropertyValue<string>(nameof(TenTH), ref fTenTH, value); }
        }
        [Association(@"SAN_PHAMReferencesTHUONG_HIEU")]
        public XPCollection<SAN_PHAM> SAN_PHAMs { get { return GetCollection<SAN_PHAM>(nameof(SAN_PHAMs)); } }
    }

}
