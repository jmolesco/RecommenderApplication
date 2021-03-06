using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Seed
{
    public class DBInitializerSchoolRegion11
    {
        public static void AddDefaultSchool(DataContext dataContext)
        {
            List<string[]> School = new List<string[]>
            {
                new string[] { "405320",    "Assumption Academy of Compostela",             "REGION XI",    "Compostela Valley",    "Compostela" },
                new string[] { "405321",    "Compostela Christian School",          "REGION XI",    "Compostela Valley",    "Compostela" },
                new string[] { "405329",    "Institution of Northern Davao, Inc.",          "REGION XI",    "Compostela Valley",    "Compostela" },
                new string[] { "464031",    "Legacy College of Compostela, Inc",            "REGION XI",    "Compostela Valley",    "Compostela" },
                new string[] { "464005",    "Laak Institute Foundation, Inc.",          "REGION XI",    "Compostela Valley",    "Laak (San Vicente)" },
                new string[] { "405324",    "Cor Jesu High School of Mabini, Inc.",             "REGION XI",    "Compostela Valley",    "Mabini (Doña Alicia)" },
                new string[] { "405325",    "Letran de Davao of Maco, Inc",             "REGION XI",    "Compostela Valley",    "Maco" },
                new string[] { "405326",    "Thomson Christian School-Masara Branch",           "REGION XI",    "Compostela Valley",    "Maco" },
                new string[] { "406608",    "Community Technical College of Southeastern Mindanao, Inc.",           "REGION XI",    "Compostela Valley",    "Maco" },
                new string[] { "407244",    "Maco Institute of Technology, Inc.",           "REGION XI",    "Compostela Valley",    "Maco" },
                new string[] { "405327",    "Saint Vincent Academy of Maragusan, Inc.",             "REGION XI",    "Compostela Valley",    "Maragusan (San Mariano)" },
                new string[] { "405759",    "Informatic Technical Institute of Comval Province, Inc.",          "REGION XI",    "Compostela Valley",    "Maragusan (San Mariano)" },
                new string[] { "405328",    "Assumption Academy of Mawab, Inc.",            "REGION XI",    "Compostela Valley",    "Mawab" },
                new string[] { "403871",    "Monkayo College of Arts, Sciences and Technology",             "REGION XI",    "Compostela Valley",    "Monkayo" },
                new string[] { "405332",    "Assumption Academy of Monkayo",            "REGION XI",    "Compostela Valley",    "Monkayo" },
                new string[] { "403727",    "Compostela Valley Institute of Technology (COMVIT) Inc",           "REGION XI",    "Compostela Valley",    "Montevista" },
                new string[] { "405335",    "Assumption College of Nabunturan",             "REGION XI",    "Compostela Valley",    "Nabunturan (Capital)" },
                new string[] { "405339",    "Nueva Estrella Santiago Dulos Academy",            "REGION XI",    "Compostela Valley",    "Pantukan" },
                new string[] { "405340",    "Maryknoll High School of Asuncion",            "REGION XI",    "Davao del Norte",  "Asuncion" },
                new string[] { "403841",    "ACES Polytechnic College",             "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "403844",    "Northlink Technological College",          "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "403848",    "University of Mindanao - Panabo College",          "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "405584",    "Maryknoll College of Panabo, Inc. (Formerly: Maryknoll High School of Panabo, Inc.)",          "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "405586",    "North Davao Colleges",             "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "405587",    "Northern Paramedical and Technological College of Panabo, Inc.",           "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "405588",    "Panabo Christian School",          "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "467002",    "Francisco Adlaon Learning Institute",          "REGION XI",    "Davao del Norte",  "City of Panabo" },
                new string[] { "403859",    "ACES Tagum College",           "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "403861",    "ACLC College of Tagum City, Inc.",             "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "403862",    "STI College - Tagum",          "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "403863",    "Tagum Doctors College, Inc.",          "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "403867",    "CARD-MRI Development Institute, Inc.",             "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405366",    "Arriesgado College Foundation, Inc.",          "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405367",    "Assumpta School of Tagum, Inc.",           "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405374",    "Letran De Davao, Inc.",            "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405379",    "Max Mirafuentes Academy",          "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405381",    "NDC - Tagum Foundation, Inc.",             "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405383",    "St. Mary's College of Tagum, Inc",             "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405385",    "Sto. Niño College of Science and Technology, Inc.",            "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "405388",    "UM Tagum College",             "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "407265",    "Mindtechs Institute of Technology, Inc.",          "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "495017",    "Liceo de Davao",           "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "495026",    "St. Thomas More Montessori School",            "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "495027",    "Tagum Longford College",           "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "495033",    "Tagum City College of Science & Technology Foundation, Inc.",          "REGION XI",    "Davao del Norte",  "City of Tagum (Capital)" },
                new string[] { "403851",    "University of Mindanao - Peñaplata",           "REGION XI",    "Davao del Norte",  "Island Garden City of Samal" },
                new string[] { "405350",    "Holy Cross of Babak, Inc.",            "REGION XI",    "Davao del Norte",  "Island Garden City of Samal" },
                new string[] { "405351",    "Holy Name School Foundation, Inc.",            "REGION XI",    "Davao del Norte",  "Island Garden City of Samal" },
                new string[] { "407253",    "IGB Samal Function House & Training Center",           "REGION XI",    "Davao del Norte",  "Island Garden City of Samal" },
                new string[] { "405342",    "Kapalong College of Technology, Inc.",             "REGION XI",    "Davao del Norte",  "Kapalong" },
                new string[] { "405771",    "Global Education Technology of Kapalong, Inc.",            "REGION XI",    "Davao del Norte",  "Kapalong" },
                new string[] { "407568",    "Maryknoll High School of Maniki, Inc.",            "REGION XI",    "Davao del Norte",  "Kapalong" },
                new string[] { "464502",    "Quezon Memorial Institute of Technology Inc.",             "REGION XI",    "Davao del Norte",  "Kapalong" },
                new string[] { "405346",    "Maryknoll High School of New Corella, Inc.",           "REGION XI",    "Davao del Norte",  "New Corella" },
                new string[] { "464504",    "Davao del Norte Agricultural College, Inc.",           "REGION XI",    "Davao del Norte",  "New Corella" },
                new string[] { "405349",    "Davao Winchester Colleges, Inc",           "REGION XI",    "Davao del Norte",  "Santo Tomas" },
                new string[] { "405358",    "Philippine Baptist Christian College of Mindanao, Inc.",           "REGION XI",    "Davao del Norte",  "Santo Tomas" },
                new string[] { "405364",    "Temple Christian School",          "REGION XI",    "Davao del Norte",  "Santo Tomas" },
                new string[] { "407569",    "Maryknoll High School of Sto. Thomas",             "REGION XI",    "Davao del Norte",  "Santo Tomas" },
                new string[] { "403834",    "University of Mindanao - Bansalan College",            "REGION XI",    "Davao del Sur",    "Bansalan" },
                new string[] { "405391",    "Nazareth High School of Bansalan, Inc.",           "REGION XI",    "Davao del Sur",    "Bansalan" },
                new string[] { "407246",    "Global Systems Institute of Technology, Inc.",             "REGION XI",    "Davao del Sur",    "Bansalan" },
                new string[] { "465001",    "St. Therese School of Bansalan, Inc.",             "REGION XI",    "Davao del Sur",    "Bansalan" },
                new string[] { "403839",    "University of Mindanao - Digos College",           "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405572",    "Cor Jesu College",             "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405573",    "Digos Central Adventist Academy, Inc.",            "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405577",    "Holy Cross Academy, Inc.",             "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405784",    "Digital Systems College of Science and Technology",            "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405786",    "Digos Institute of Technical Education and Driving School, Inc.",          "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405788",    "Dok Alternatibo Research and Development Foundation, Inc.",            "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405791",    "Mary Mediatrix of all Graces Academy, Inc.",           "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "405807",    "Southern Mindanao Computer College, Inc.",             "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "406623",    "Saver's Technological College of Davao, Inc.",             "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "466506",    "Polytechnic College of Davao del Sur, Inc.",           "REGION XI",    "Davao del Sur",    "City of Digos (Capital)" },
                new string[] { "403736",    "AMA Computer Learning Center of Davao del Sur",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403760",    "Asian International School of Aeronautics and Technology",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403767",    "Davao Doctors College",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403776",    "Davao Vision Colleges, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403778",    "DMMA College of Southern Philippines",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403795",    "Gabriel Taborin College of Davao Foundation Inc.",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403798",    "Institute of International Culinary and Hospitality Entrepreneurship",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403804",    "Mindanao Medical Foundation College",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403805",    "St. John Paul II College of Davao",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403830",    "STI College - Davao",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "403868",    "Evelyn E. Fabie College, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405431",    "Assumption College of Davao",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405434",    "Brainworks School, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405435",    "Brokenshire College Toril",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405438",    "Davao Central College",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405439",    "Davao Christian High School",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405445",    "Davao Wisdom Academy",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405453",    "Holy Child College of Davao, Inc. (Cabantian Campus)",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405454",    "Holy Cross of Mintal",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405455",    "Holy Cross College of Sasa, Inc.",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405458",    "Immanuel School of Davao, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405462",    "Calinan LAM Adventist Academy, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405469",    "Saint Therese College of Science and Technology, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405473",    "Our Lady of Fatima Academy -Davao",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405476",    "Philippine Academy of Sakya Davao, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405477",    "Philippine Nikkei Jin Kai International School",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405479",    "Rizal Memorial Colleges, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405480",    "Rizal Special Education Learning Center",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405481",    "Rogationist Academy-Davao, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405489",    "St. Francis Xavier Learning Center",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405491",    "St. Patrick Math-Sci School",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405492",    "Saint Peter's College of Toril",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405494",    "Stella Maris Academy of Davao",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405495",    "Tecarro College Foundation, Inc.",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405499",    "Thompson Christian School",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405500",    "Brokenshire College",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405505",    "University of the Immaculate Conception",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405508",    "University of Mindanao - Ilang-Tibungco Junior College",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405510",    "Agro-Industrial Foundation College of the Philippines",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405512",    "Ateneo de Davao University",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405516",    "Precious International School of Davao",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405518",    "Emar Human and Environmental College",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405527",    "Philippine Women's College of Davao",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405536",    "Holy Cross of Davao College, Inc.-Main Campus",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405542",    "General Baptist Bible College (GENBAP)",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405551",    "Colegio de San Ignacio, Inc.",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405552",    "Davao Jones Academy",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405555",    "Ford Academy of the Arts",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405558",    "Jose Maria College",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405559",    "The Lamb of God SPED Academy",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405563",    "Montserrat Camp School de Davao",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405566",    "Holy Cross of Bunawan, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405570",    "Holy Cross of Agdao",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405571",    "MATS College of Technology",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405766",    "Davao Institute of Technical Education, Inc.",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405768",    "Southeastern Mindanao Institute of Technology, Inc. - Magallanes Campus",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "406610",    "JIB Welding Academy",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "406719",    "Davao St. Martin de Porres Technical School, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407565",    "Holy Cross College of Calinan",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407566",    "University of Mindanao - Guianga College",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407567",    "University of Mindanao (Main Campus)",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407586",    "Philippine College of Technology",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407638",    "San Pedro College, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407639",    "Holy Child College of Davao, Mintal Campus",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407828",    "Joji Ilagan Career Centre Foundation, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "407829",    "AMA Computer College-Davao",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466004",    "Davao Chong Hua High School (Formerly Davao Central High School)",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466008",    "Holy Child College of Davao, Inc. (Jacinto Campus)",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466016",    "San Lorenzo College of Davao, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466018",    "Samson Polytechnic College of Davao, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466019",    "Southern Philippines Baptist Theological Seminary Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466033",    "Christian Colleges of Southeast Asia",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466039",    "St. Francis College of Davao, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466042",    "Soli Deo Gloria Christian Academy",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466045",    "Holy Infant Jesus Academy of Panacan, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466051",    "Kristy Dawn College of Davao, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466053",    "Apo Learning Village, Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466057",    "Kids Camp Innovative Learning Academy Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466060",    "New Ilang Achievers Academy, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466078",    "Saint Paul College of Davao, Inc.",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466095",    "Deaf Ministries Institute, Inc.",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466101",    "Imma-Con School of Davao",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466104",    "International College of St. Ignatius",            "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466110",    "Wisdom Islamic School, Davao City Inc.",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466115",    "Dr. P. Ocampo College Davao Campus, Inc.",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466131",    "Philippine College of Technology",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466139",    "San Pedro College, Inc.-Ulas",             "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466148",    "Intercity College of Science and Technology",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466153",    "Interface Computer College",           "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "466154",    "Proverbs Ville Christian School",          "REGION XI",    "Davao del Sur",    "Davao City" },
                new string[] { "405393",    "Holy Cross of Hagonoy, Inc",           "REGION XI",    "Davao del Sur",    "Hagonoy" },
                new string[] { "405394",    "Holy Cross of Caburan, Inc.",          "REGION XI",    "Davao del Sur",    "Jose Abad Santos (Trinidad)" },
                new string[] { "405395",    "Cogon Bacaca High School of Kiblawan, Inc.",           "REGION XI",    "Davao del Sur",    "Kiblawan" },
                new string[] { "405396",    "Holy Cross of Kiblawan",           "REGION XI",    "Davao del Sur",    "Kiblawan" },
                new string[] { "405397",    "Serapion C. Basalo Memorial Foundation Colleges, Inc.",            "REGION XI",    "Davao del Sur",    "Kiblawan" },
                new string[] { "405398",    "Holy Cross of Magsaysay",          "REGION XI",    "Davao del Sur",    "Magsaysay" },
                new string[] { "405399",    "Magsaysay Academy, Inc.",          "REGION XI",    "Davao del Sur",    "Magsaysay" },
                new string[] { "405400",    "Holy Cross of Malalag, Inc.",          "REGION XI",    "Davao del Sur",    "Malalag" },
                new string[] { "406613",    "Adventure College of Malita, Inc.",            "REGION XI",    "Davao del Sur",    "Malita" },
                new string[] { "407570",    "Holy Cross of Malita, Inc",            "REGION XI",    "Davao del Sur",    "Malita" },
                new string[] { "405402",    "Holy Cross of Matanao, Inc.",          "REGION XI",    "Davao del Sur",    "Matanao" },
                new string[] { "405403",    "South Philippines Adventist College",          "REGION XI",    "Davao del Sur",    "Matanao" },
                new string[] { "405404",    "Saint Michael's School of Padada",             "REGION XI",    "Davao del Sur",    "Padada" },
                new string[] { "465002",    "Southeastern College of Padada, Inc.",             "REGION XI",    "Davao del Sur",    "Padada" },
                new string[] { "405407",    "Holy Cross of Sta. Maria, Inc.",           "REGION XI",    "Davao del Sur",    "Santa Maria" },
                new string[] { "405409",    "Sta. Maria Institute, Inc.",           "REGION XI",    "Davao del Sur",    "Santa Maria" },
                new string[] { "405412",    "Holy Cross of Sulop, Inc.",            "REGION XI",    "Davao del Sur",    "Sulop" },
                new string[] { "405413",    "Maryknoll School of Lambajon",             "REGION XI",    "Davao Oriental",   "Baganga" },
                new string[] { "405414",    "St. Mary's College - Baganga Campus",          "REGION XI",    "Davao Oriental",   "Baganga" },
                new string[] { "407248",    "Holy Child Colleges of Butuan (Baganga)",          "REGION XI",    "Davao Oriental",   "Baganga" },
                new string[] { "405417",    "St. Mary's Academy of Caraga, Inc.",           "REGION XI",    "Davao Oriental",   "Caraga" },
                new string[] { "407640",    "Mati Polytechnic College, Inc.-Caraga Campus",             "REGION XI",    "Davao Oriental",   "Caraga" },
                new string[] { "405418",    "Maryknoll Academy of Cateel",          "REGION XI",    "Davao Oriental",   "Cateel" },
                new string[] { "405424",    "Mati Polytechnic College, Inc.",           "REGION XI",    "Davao Oriental",   "City of Mati (Capital)" },
                new string[] { "405425",    "Santo Niño School of Mati, Incorporated",          "REGION XI",    "Davao Oriental",   "City of Mati (Capital)" },
                new string[] { "405812",    "Don Bosco Training Center-Mati",           "REGION XI",    "Davao Oriental",   "City of Mati (Capital)" },
                new string[] { "407571",    "Immaculate Heart of Mary Academy",             "REGION XI",    "Davao Oriental",   "City of Mati (Capital)" },
                new string[] { "465506",    "Sunbeam Christian School of Mati, Inc.",           "REGION XI",    "Davao Oriental",   "City of Mati (Capital)" },
                new string[] { "465513",    "Mati Doctors Academy",             "REGION XI",    "Davao Oriental",   "City of Mati (Capital)" },
                new string[] { "405772",    "Informatic Technological College of Davao Oriental, Inc.",             "REGION XI",    "Davao Oriental",   "Governor Generoso" },
                new string[] { "405421",    "Maryknoll School of Lupon",            "REGION XI",    "Davao Oriental",   "Lupon" },
                new string[] { "465502",    "Eastern Davao Academy, Inc.",          "REGION XI",    "Davao Oriental",   "Lupon" },
                new string[] { "600277",    "Davao Oriental State College of Science and Technology",           "REGION XI",    "Davao Oriental",   "Lupon" },
                new string[] { "405422",    "Maryknoll School of Manay, Inc.",          "REGION XI",    "Davao Oriental",   "Manay" },
            };
        }
    }
}