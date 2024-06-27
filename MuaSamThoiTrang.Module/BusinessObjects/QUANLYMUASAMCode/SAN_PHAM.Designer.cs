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
using MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAMCode;
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{

    public partial class SAN_PHAM : XPObject
    {
        string fMaSP;
        public string MaSP
        {
            get { return fMaSP; }
            set { SetPropertyValue<string>(nameof(MaSP), ref fMaSP, value); }
        }
        string fTenSP;
        public string TenSP
        {
            get { return fTenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref fTenSP, value); }
        }
        THUONG_HIEU fMaTH;
        [Association(@"SAN_PHAMReferencesTHUONG_HIEU")]
        public THUONG_HIEU MaTH
        {
            get { return fMaTH; }
            set { SetPropertyValue<THUONG_HIEU>(nameof(MaTH), ref fMaTH, value); }
        }
        DANH_MUC fMaDM;
        [Association(@"SAN_PHAMReferencesDANH_MUC")]
        public DANH_MUC MaDM
        {
            get { return fMaDM; }
            set { SetPropertyValue<DANH_MUC>(nameof(MaDM), ref fMaDM, value); }
        }
        NHA_CUNG_CAP fMaNhaCC;
        [Association(@"SAN_PHAMReferencesNHA_CUNG_CAP")]
        public NHA_CUNG_CAP MaNhaCC
        {
            get { return fMaNhaCC; }
            set { SetPropertyValue<NHA_CUNG_CAP>(nameof(MaNhaCC), ref fMaNhaCC, value); }
        }

        decimal fDonGia;
        public decimal DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<decimal>(nameof(DonGia), ref fDonGia, value); }
        }
        
        string fDVT;
        public string DVT
        {
            get { return fDVT; }
            set { SetPropertyValue<string>(nameof(DVT), ref fDVT, value); }
        }
        string fMota;
        public string Mota
        {
            get { return fMota; }
            set { SetPropertyValue<string>(nameof(Mota), ref fMota, value); }
        }
        [Association(@"CT_DAT_HANGReferencesSAN_PHAM")]
        public XPCollection<CT_DAT_HANG> CT_DAT_HANGs { get { return GetCollection<CT_DAT_HANG>(nameof(CT_DAT_HANGs)); } }

    }

}
