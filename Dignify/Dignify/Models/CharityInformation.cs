using System;
using System.Collections.Generic;
using System.Text;

namespace Dignify.Models
{
    public enum Service
    {
        Beds,
        Health,
        Food,
        MentalHealth
    }
    public class Charity
    {
        public string name { get; set; }
        public string address { get; set; }
        public List<Service> Services { get; set; }
        public Charity(string charityName, string charityAddress)
        {
            name = charityName;
            address = charityAddress;
            Services = new List<Service>();
        }
    }
    public class Charities
    {
        public static List<Charity> GetCharityList()
        {
            List<Charity> charityList = new List<Charity>();
            Charity CIMOA = new Charity("Community Internal Medicine of Athens", "1500 Ogelthorpe Ave 200C");
            CIMOA.Services.Add(Service.Health);
            CIMOA.Services.Add(Service.MentalHealth);
            charityList.Add(CIMOA);
            Charity FCSOFA = new Charity("Family Counseling Service of Athens", "1435 Ogelthorpe Ave");
            FCSOFA.Services.Add(Service.MentalHealth);
            charityList.Add(FCSOFA);
            Charity BHBC = new Charity("Beech Haven Baptist Church", "2390 W. Broad St.");
            BHBC.Services.Add(Service.Food);
            BHBC.Services.Add(Service.MentalHealth);
            charityList.Add(BHBC);
            Charity APC = new Charity("Athens Pregnancy Center", "767 Ogelthorpe Ave");
            APC.Services.Add(Service.Health);
            APC.Services.Add(Service.MentalHealth);
            charityList.Add(APC);
            Charity SACCSU = new Charity("Salvation Army Clarke County Service Unit", "484 Hawthorne Ave");
            SACCSU.Services.Add(Service.Food);
            SACCSU.Services.Add(Service.Beds);
            SACCSU.Services.Add(Service.MentalHealth);
            charityList.Add(SACCSU);
            Charity SMCS = new Charity("St. Mary's Health Care System", "1230 Baxter Street");
            SMCS.Services.Add(Service.Health);
            SMCS.Services.Add(Service.MentalHealth);
            charityList.Add(SMCS);
            Charity PACCC = new Charity("Piedmont Athens Community Care Clinic", "1270 Prince Ave #201");
            PACCC.Services.Add(Service.Health);
            PACCC.Services.Add(Service.MentalHealth);
            charityList.Add(PACCC);
            Charity AHA = new Charity("Athens Housing Authority", "300 S. Rocksprings St");
            AHA.Services.Add(Service.Beds);
            AHA.Services.Add(Service.MentalHealth);
            charityList.Add(AHA);
            Charity TM = new Charity("Teen Matters", "168 S. Rocksprings Ct.");
            TM.Services.Add(Service.Health);
            TM.Services.Add(Service.MentalHealth);
            charityList.Add(TM);
            Charity SN = new Charity("Sparrow's Nest", "745 Prince Ave");
            SN.Services.Add(Service.Food);
            SN.Services.Add(Service.MentalHealth);
            charityList.Add(SN);
            Charity AHDCMS = new Charity("Acc Health Dept. & Children's Medical Services", "345 N. Harris St.");
            AHDCMS.Services.Add(Service.Health);
            AHDCMS.Services.Add(Service.MentalHealth);
            charityList.Add(AHDCMS);
            Charity AAEFB = new Charity("Athens Area Emergency Food Bank", "640 Barber Street");
            AAEFB.Services.Add(Service.Food);
            AAEFB.Services.Add(Service.MentalHealth);
            charityList.Add(AAEFB);
            Charity AAHS = new Charity("Athens Area Homeless Shelter", "620 Barber Street");
            AAHS.Services.Add(Service.Beds);
            AAHS.Services.Add(Service.MentalHealth);
            charityList.Add(AAHS);
            Charity IHNOA = new Charity("Interfaith Hospitality Network of Athens", "393-1 W. Hancock Ave");
            IHNOA.Services.Add(Service.Beds);
            IHNOA.Services.Add(Service.MentalHealth);
            charityList.Add(IHNOA);
            Charity AM = new Charity("Action Ministries", "465 Lumpkin Street");
            AM.Services.Add(Service.Food);
            AM.Services.Add(Service.MentalHealth);
            charityList.Add(AM);
            Charity SCC = new Charity("Samaritan Counseling Center", "455 N. Lumpkin Street");
            SCC.Services.Add(Service.MentalHealth);
            charityList.Add(SCC);
            Charity ANHC = new Charity("Athens Neighborhood Health Center", "675 College Ave");
            ANHC.Services.Add(Service.Health);
            charityList.Add(ANHC);
            Charity BVOA = new Charity("Bigger Vision of Athens", "95 North Ave");
            BVOA.Services.Add(Service.Beds);
            charityList.Add(BVOA);
            Charity ANC = new Charity("Athens Nurses Clinic", "240 North Ave");
            ANC.Services.Add(Service.Health);
            charityList.Add(ANC);
            Charity HDSC = new Charity("Homeless Day Service Center", "250 North Ave");
            HDSC.Services.Add(Service.MentalHealth);
            charityList.Add(HDSC);
            Charity AMMBS = new Charity("ACC Multi-Modal Bus Station", "775 E Broad Street");
            AMMBS.Services.Add(Service.Beds);
            charityList.Add(AMMBS);
            Charity UOGPC = new Charity("University of Georgia-Psychology Clinic", "139 Psych Bldg");
            UOGPC.Services.Add(Service.MentalHealth);
            charityList.Add(UOGPC);
            Charity AICC = new Charity("Action, Inc. -Clarke County", "594 Oconee Street");
            AICC.Services.Add(Service.Food);
            charityList.Add(AICC);
            Charity ANHCE = new Charity("Athens Neighborhood Health Center-East", "402 McKinley Drive");
            ANHCE.Services.Add(Service.Health);
            charityList.Add(ANHCE);
            return charityList;
        }
    }
}
