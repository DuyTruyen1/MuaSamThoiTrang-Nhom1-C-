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
<<<<<<< HEAD
using DevExpress.ExpressApp.DC;
=======
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Validation;
>>>>>>> 41fd1856b43042ac3e5b0b3ac523503b0f4f9f58
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{
    [System.ComponentModel.DisplayName("Khách hàng")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [DefaultProperty("Ten")]

    public partial class USER : XPObject
    {
        string fUserID;
        [XafDisplayName("Mã khách")]
        [RuleRequiredField("Yeucau UserID", DefaultContexts.Save, "Phải có mã khách hàng")]
        public string UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<string>(nameof(UserID), ref fUserID, value); }
        }
        string fTen;
<<<<<<< HEAD
        [XafDisplayName("Tên")]
=======
        [XafDisplayName("Tên khách")]
>>>>>>> 41fd1856b43042ac3e5b0b3ac523503b0f4f9f58
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>(nameof(Ten), ref fTen, value); }
        }

        string fSoDT;
<<<<<<< HEAD
        [XafDisplayName("Sô điện thoại")]
=======
        [XafDisplayName("Số điện thoại")]
>>>>>>> 41fd1856b43042ac3e5b0b3ac523503b0f4f9f58
        public string SoDT
        {
            get { return fSoDT; }
            set { SetPropertyValue<string>(nameof(SoDT), ref fSoDT, value); }
        }
        string fDiaChi;
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fGhiChu;
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        [Association(@"DANH_GIAReferencesUSER")]
        public XPCollection<DANH_GIA> DANH_GIAs { get { return GetCollection<DANH_GIA>(nameof(DANH_GIAs)); } }
        [Association(@"DAT_HANGReferencesUSER")]
        public XPCollection<DAT_HANG> DAT_HANGs { get { return GetCollection<DAT_HANG>(nameof(DAT_HANGs)); } }
        [Association(@"HOA_DONReferencesUSER")]
        public XPCollection<HOA_DON> HOA_DONs { get { return GetCollection<HOA_DON>(nameof(HOA_DONs)); } }
    }

}
