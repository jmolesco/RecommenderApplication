using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Seed
{
    public class DBInitializerSchoolRegionARMM
    {
        public static List<string[]> AddDefaultSchools()
        {
            List<string[]> School = new List<string[]>
            {
                new string[] { "405839",    "Mindanao Autonomous College Foundation, Inc.",             "ARMM",     "Basilan",  "City of Lamitan" },
                new string[] { "406057",    "Claret School of Lamitan",             "ARMM",     "Basilan",  "City of Lamitan" },
                new string[] { "406921",    "Hardam Furigay Colleges Foundation, Inc.",             "ARMM",     "Basilan",  "City of Lamitan" },
                new string[] { "407069",    "The Mariam School of Nursing, Inc.",           "ARMM",     "Basilan",  "City of Lamitan" },
                new string[] { "406059",    "Claret School of Maluso",          "ARMM",     "Basilan",  "Maluso" },
                new string[] { "406060",    "Claret School of Tumahubong",          "ARMM",     "Basilan",  "Sumisip" },
                new string[] { "406063",    "San Isidro High School of Balabagan",          "ARMM",     "Lanao del Sur",    "Balabagan" },
                new string[] { "600120",    "Adiong Memorial Polytechnic State College",            "ARMM",     "Lanao del Sur",    "Ditsaan-Ramain" },
                new string[] { "406066",    "Our Lady of Peace High School",            "ARMM",     "Lanao del Sur",    "Malabang" },
                new string[] { "476002",    "Felix A. Panganiban (FAP) Academy of the Philippines, Inc.",           "ARMM",     "Lanao del Sur",    "Malabang" },
                new string[] { "406008",    "Jamiatul Philippine Al-Islamia",           "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "406086",    "Aba Al-khail Computer School",             "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "406089",    "Dansalan College Foundation",          "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "406091",    "IBN Siena Integrated School Foundation",           "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "406093",    "Jamiatu Muslim Mindanao",          "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "406096",    "Mapandi Memorial College",             "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "406097",    "Marawi Capitol College Foundation, Inc.",          "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478003",    "Marawi Foundation Academy, Inc.",          "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478008",    "Masiricampo Abantas Memorial Educational Center, Inc.",            "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478011",    "Lanao Islamic Paramedical College Foundation, Inc",            "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478015",    "SMD Foundation Academy",           "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478017",    "RC-AKICFI Science Laboratory School",          "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478018",    "Jamiatu Marawi Al-Islamia Foundation",             "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478019",    "Fountain Harvest Islamic Academy",             "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478020",    "Philippine Engineering and Agro-Industrial College, Inc.",             "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "478021",    "Datu Blo Umpar Adiong (BUAD) Agricultural School Foundation, Inc.",            "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "600121",    "Mindanao State University-LNCAT",          "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "600122",    "Mindanao State University-Marawi",             "ARMM",     "Lanao del Sur",    "Marawi City" },
                new string[] { "475505",    "As-salihein Integrated School Foundation, Inc.",           "ARMM",     "Lanao del Sur",    "Tamparan" },
                new string[] { "405861",    "Adiong Memorial College Foundation, Inc.",             "ARMM",     "Lanao del Sur",    "Wao" },
                new string[] { "406061",    "La Purisima High School",          "ARMM",     "Lanao del Sur",    "Wao" },
                new string[] { "405841",    "VMC Asian College Foundation, Inc.-Kauran Branch",             "ARMM",     "Maguindanao",  "Ampatuan" },
                new string[] { "476505",    "Maguindanao Institute of Technology and Learning Center, Inc.",            "ARMM",     "Maguindanao",  "Buluan" },
                new string[] { "476519",    "Buluan Technical Educational School of Life, Inc.",            "ARMM",     "Maguindanao",  "Buluan" },
                new string[] { "476520",    "Eastern Kutawato Islamic Institute, Inc.",             "ARMM",     "Maguindanao",  "Buluan" },
                new string[] { "400844",    "Bai Malgen Mama College Inc.",             "ARMM",     "Maguindanao",  "Datu Odin Sinsuat" },
                new string[] { "476503",    "Sharif Awliya Academy",            "ARMM",     "Maguindanao",  "Datu Odin Sinsuat" },
                new string[] { "600194",    "Mindanao State University-Maguindanao",            "ARMM",     "Maguindanao",  "Datu Odin Sinsuat" },
                new string[] { "406673",    "Datu Ibrahim Paglas Memorial College",             "ARMM",     "Maguindanao",  "Datu Paglas" },
                new string[] { "406070",    "Gani L. Abpi College, Inc.",           "ARMM",     "Maguindanao",  "Datu Piang" },
                new string[] { "406071",    "Notre Dame of Dulawan",            "ARMM",     "Maguindanao",  "Datu Piang" },
                new string[] { "407450",    "Lamalan Balis Flash Image Learning Center, Inc.",          "ARMM",     "Maguindanao",  "Datu Piang" },
                new string[] { "476525",    "Southern Philippines Academy (SPA) College",           "ARMM",     "Maguindanao",  "Datu Piang" },
                new string[] { "406072",    "Notre Dame of Parang, Inc.",           "ARMM",     "Maguindanao",  "Parang" },
                new string[] { "406073",    "Notre Dame of Sarmiento, Inc",             "ARMM",     "Maguindanao",  "Parang" },
                new string[] { "476508",    "The Easter Joy School, Inc.",          "ARMM",     "Maguindanao",  "Parang" },
                new string[] { "476504",    "Sultan Kudarat Islamic Academy Foundation College",            "ARMM",     "Maguindanao",  "Sultan Kudarat (Nuling)" },
                new string[] { "406074",    "Notre Dame of Upi, Inc.",          "ARMM",     "Maguindanao",  "Upi" },
                new string[] { "406075",    "St. Francis High School",          "ARMM",     "Maguindanao",  "Upi" },
                new string[] { "400857",    "Notre Dame of Jolo College",           "ARMM",     "Sulu",     "Jolo" },
                new string[] { "477001",    "Southwestern Mindanao Islamic Institute",          "ARMM",     "Sulu",     "Jolo" },
                new string[] { "477006",    "Sulu College of Technology, Inc.",             "ARMM",     "Sulu",     "Jolo" },
                new string[] { "600183",    "Sulu State College",           "ARMM",     "Sulu",     "Jolo" },
                new string[] { "600195",    "Mindanao State University",            "ARMM",     "Sulu",     "Jolo" },
                new string[] { "406079",    "Notre Dame of Siasi",          "ARMM",     "Sulu",     "Siasi" },
                new string[] { "477002",    "Central Sulu College",             "ARMM",     "Sulu",     "Siasi" },
                new string[] { "405845",    "Tawi-Tawi School of Midwifery, Inc.",          "ARMM",     "Tawi-Tawi",    "Bongao" },
                new string[] { "406080",    "Notre Dame of Bongao",             "ARMM",     "Tawi-Tawi",    "Bongao" },
                new string[] { "477503",    "Mahardika Institute of Technology, Inc.",          "ARMM",     "Tawi-Tawi",    "Bongao" },
                new string[] { "600124",    "Tawi-Tawi Regional Agricultural College-Main",             "ARMM",     "Tawi-Tawi",    "Bongao" },
                new string[] { "600196",    "Mindanao State University-Tawi-Tawi",          "ARMM",     "Tawi-Tawi",    "Bongao" },
                new string[] { "600329",    "Mindanao State University - Mapun Extension",          "ARMM",     "Tawi-Tawi",    "Mapun" },
                new string[] { "600327",    "Mindanao State University - Sibutu Extension",             "ARMM",     "Tawi-Tawi",    "Sibutu" },
                new string[] { "600328",    "Mindanao State University - Ungus Matata Extension",           "ARMM",     "Tawi-Tawi",    "Tandubas" },
            };
            return School;
        }
    }
}