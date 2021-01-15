﻿using Braavos.Core.Repositories.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Braavos.Core.Repositories.DbContexts.Internal
{
    public class TodaysNationData
    {
        public int NationId { get; set; }
        public string RulerName { get; set; }
        public string NationName { get; set; }
        public int? AllianceId { get; set; }
        public DateTime? AllianceDate { get; set; }
        public string AllianceStatus { get; set; }
        public int GovernmentType { get; set; }
        public int Religion { get; set; }
        public int Team { get; set; }
        public DateTime Created { get; set; }
        public decimal Technology { get; set; }
        public decimal Infrastructure { get; set; }
        public decimal BaseLand { get; set; }
        public int WarStatus { get; set; }
        public int Votes { get; set; }
        public decimal Strength { get; set; }
        public int Defcon { get; set; }
        public int BaseSoldiers { get; set; }
        public int Tanks { get; set; }
        public int CruiseMissiles { get; set; }
        public int Nukes { get; set; }
        public int RecentActivity { get; set; }
        public string ConnectedResource1 { get; set; }
        public string ConnectedResource2 { get; set; }
        public string ConnectedResource3 { get; set; }
        public string ConnectedResource4 { get; set; }
        public string ConnectedResource5 { get; set; }
        public string ConnectedResource6 { get; set; }
        public string ConnectedResource7 { get; set; }
        public string ConnectedResource8 { get; set; }
        public string ConnectedResource9 { get; set; }
        public string ConnectedResource10 { get; set; }
        public string FileName { get; set; }

        public TodaysNationData() { }

        public TodaysNationData(Nation realNationObject, string fileName)
        {
            NationId = realNationObject.NationId;
            RulerName = realNationObject.RulerName;
            NationName = realNationObject.NationName;
            AllianceId = realNationObject.AllianceId;
            AllianceDate = realNationObject.AllianceDate;
            AllianceStatus = realNationObject.AllianceStatus;
            GovernmentType = (int)realNationObject.GovernmentType;
            Religion = (int)realNationObject.Religion;
            Team = (int)realNationObject.Team;
            Created = realNationObject.Created;
            Technology = realNationObject.Technology;
            Infrastructure = realNationObject.Infrastructure;
            BaseLand = realNationObject.BaseLand;
            WarStatus = (int)realNationObject.WarStatus;
            Votes = realNationObject.Votes;
            Strength = realNationObject.Strength;
            Defcon = realNationObject.Defcon;
            BaseSoldiers = realNationObject.BaseSoldiers;
            Tanks = realNationObject.Tanks;
            CruiseMissiles = realNationObject.CruiseMissiles;
            Nukes = realNationObject.Nukes;
            RecentActivity = (int)realNationObject.RecentActivity;
            FileName = fileName;
        }
    }
}
