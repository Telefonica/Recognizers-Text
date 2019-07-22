//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Turkish\Turkish-NumbersWithUnit.yaml
//     - Language: Turkish
//     - ClassName: NumbersWithUnitDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Turkish
{
    using System;
    using System.Collections.Generic;

    public static class NumbersWithUnitDefinitions
    {
      public static readonly Dictionary<string, string> AgeSuffixList = new Dictionary<string, string>
        {
            { @"Year", @"yaş|yaşında|yaşındayım|yaşındayken|yaşından|yıllık" },
            { @"Month", @"aylık|aydan|aylıkken|ay" },
            { @"Week", @"haftalık|haftalıkken" },
            { @"Day", @"günlük" }
        };
      public static readonly Dictionary<string, string> AreaSuffixList = new Dictionary<string, string>
        {
            { @"Square kilometer", @"kilometrekare|kilometre kare|km2|km^2|km²" },
            { @"Square hectometer", @"hektometrekare|hektometre kare|hm2|hm^2|hm²" },
            { @"Square decameter", @"dekametrekare|dekametre kare|dam2|dam^2|dam²" },
            { @"Square meter", @"metrekaredir|metrekare|metre kare|m2|m^2|m²" },
            { @"Square decimeter", @"desimetrekare|desimetre kare|dm2|dm^2|dm²" },
            { @"Square centimeter", @"santimetrekare|santimetre kare|cm2|cm^2|cm²" },
            { @"Square millimeter", @"milimetrekare|milimetre kare|mm2|mm^2|mm²" },
            { @"Square inch", @"inç kare|inçkare|in2|in^2|in²" },
            { @"Square foot", @"fit kare|fitkare|ft2|ft^2|ft²|ayakkare" },
            { @"Square mile", @"mil kare|milkare|mi2|mi^2|mi²" },
            { @"Square yard", @"yarda kare|yardakare|yd2|yd^2|yd²" },
            { @"Acre", @"akre|ac|dönümlük|dönüm" },
            { @"Ar", @"ar|a" },
            { @"Dekar", @"dekar|daa" },
            { @"Hektar", @"hektar|ha" }
        };
      public static readonly IList<string> AmbiguousAreaUnitList = new List<string>
        {
            @"fitkare",
            @"ar",
            @"dönüm",
            @"ha",
            @"a",
            @"daa"
        };
      public static readonly Dictionary<string, string> CurrencySuffixList = new Dictionary<string, string>
        {
            { @"Afganistan afganisi", @"afganistan afganisi|afgani|؋|afn|af|afs" },
            { @"Pul", @"pul" },
            { @"Euro", @"euro|€|eur|avro" },
            { @"Cent", @"sent|s" },
            { @"Albanian lek", @"arnavut leki|lek|L|" },
            { @"Qindarkë", @"qindarkë|qindarke" },
            { @"Angolan kwanza", @"angola kvanzası|kz|aoa|kvanza" },
            { @"Armenian dram", @"ermeni dramı|amd" },
            { @"Aruban florin", @"aruba florini|ƒ|awg|florin" },
            { @"Bangladeshi taka", @"bangladeş takası|৳|bdt|taka" },
            { @"Paisa", @"poisha|paisa" },
            { @"Bhutanese ngultrum", @"bhutan ngultrumu|nu.|btn" },
            { @"Chetrum", @"chetrum" },
            { @"Bolivian boliviano", @"bolivya bolivyanosu|bob|bs." },
            { @"Bosnia and Herzegovina convertible mark", @"konvertibl bosna hersek markı|konvertibl bosna-hersek markı|bam|km" },
            { @"Fening", @"feninga" },
            { @"Botswana pula", @"botsvana pulası|bwp|pula" },
            { @"Thebe", @"thebe" },
            { @"Brazilian real", @"brezilya reali|r$|brl|real|r" },
            { @"Bulgarian lev", @"bulgar levası|bgn|лв" },
            { @"Stotinka", @"stotinkas" },
            { @"Cambodian riel", @"kamboçya rieli|khr|៛" },
            { @"Sens", @"sens" },
            { @"Cape Verdean escudo", @"cape verdean esküdosu|cve" },
            { @"Costa Rican colón", @"kosta rika kolonu|crc|₡" },
            { @"Salvadoran colón", @"svc|el salvador kolonu" },
            { @"Céntimo", @"céntimo" },
            { @"Croatian kuna", @"hırvatistan kunası|kn|hrk" },
            { @"Lipa", @"lipa" },
            { @"Czech koruna", @"Çek korunası|czk|kč" },
            { @"Haléř", @"haléř" },
            { @"Eritrean nakfa", @"eritre nakfası|nfk|ern" },
            { @"Ethiopian birr", @"etiyopya birri|etb" },
            { @"Gambian dalasi", @"gmd" },
            { @"Butut", @"butut" },
            { @"Georgian lari", @"gürcistan larisi|lari|gel|₾" },
            { @"Tetri", @"tetri" },
            { @"Ghanaian cedi", @"gana sedisi|ghs|₵|gh₵" },
            { @"Pesewa", @"pesewa" },
            { @"Guatemalan quetzal", @"guatemala quetzalı|gtq" },
            { @"Haitian gourde", @"haiti gurdu|htg" },
            { @"Honduran lempira", @"honduras lempirası|hnl" },
            { @"Hungarian forint", @"macar forinti|huf|ft" },
            { @"Fillér", @"fillér" },
            { @"Iranian rial", @"iran riyali|irr" },
            { @"Yemeni rial", @"yemen riyali|yer" },
            { @"Israeli new shekel", @"yeni israil şekeli|₪|ils" },
            { @"Agora", @"agora" },
            { @"Lithuanian litas", @"ltl|litvanya litası" },
            { @"Japanese yen", @"japon yeni|jpy|yen|¥|yenlik" },
            { @"Kazakhstani tenge", @"kazakistan tengesi|kzt" },
            { @"Kenyan shilling", @"kenya şilini|sh|kes" },
            { @"North Korean won", @"kuzey kore wonu|kpw" },
            { @"South Korean won", @"güney kore wonu|krw" },
            { @"Korean won", @"kore wonu|₩" },
            { @"Kyrgyzstani som", @"kırgızistan somu|kgs" },
            { @"Uzbekitan som", @"özbekistan somu|uzs" },
            { @"Lao kip", @"laos kipi|lak|₭n|₭" },
            { @"Att", @"att" },
            { @"Lesotho loti", @"lesotho lotisi|lsl|loti" },
            { @"Sente", @"sente|lisente" },
            { @"South African rand", @"güney afrika randı|zar" },
            { @"Macanese pataca", @"makao patakası|mop" },
            { @"Avo", @"avo" },
            { @"Macedonian denar", @"makedonya dinarı|makedon denarı|mkd|ден" },
            { @"Deni", @"deni" },
            { @"Malagasy ariary", @"malagasy ariary|mga" },
            { @"Iraimbilanja", @"iraimbilanja" },
            { @"Malawian kwacha", @"malavi kvaçası|mk|mwk" },
            { @"Tambala", @"tambala" },
            { @"Malaysian ringgit", @"malezya ringgiti|rm|myr" },
            { @"Mauritanian ouguiya", @"moritanya ouguiyası|um|mro" },
            { @"Khoums", @"khoums" },
            { @"Mongolian tögrög", @"moğolistan tugriki|mnt|₮" },
            { @"Mozambican metical", @"mozambik metikali|mt|mzn" },
            { @"Burmese kyat", @"burma kyatı|ks|mmk" },
            { @"Pya", @"pya" },
            { @"Nicaraguan córdoba", @"nikaragua kordobası|nio" },
            { @"Nigerian naira", @"nijerya nairası|naira|ngn|₦" },
            { @"Kobo", @"kobo" },
            { @"Turkish lira", @"türk lirası|try|tl" },
            { @"Kuruş", @"kuruş" },
            { @"Omani rial", @"umman riyali|omr|ر.ع." },
            { @"Panamanian balboa", @"panama balboası|b/.|pab" },
            { @"Centesimo", @"centesimo" },
            { @"Papua New Guinean kina", @"papua yeni gine kinası|kina|pgk" },
            { @"Toea", @"toea" },
            { @"Paraguayan guaraní", @"paraguay guaranisi|₲|pyg" },
            { @"Peruvian sol", @"peru solü|sol|peru nuevo solü|pen" },
            { @"Polish złoty", @"zloti|polonya zlotisi|zł|pln" },
            { @"Grosz", @"grosz" },
            { @"Qatari riyal", @"katar riyali|qar" },
            { @"Saudi riyal", @"suudi arabistan riyali|sar" },
            { @"Riyal", @"riyal|﷼" },
            { @"Dirham", @"dirhem" },
            { @"Halala", @"halala" },
            { @"Samoan tālā", @"Samoa talası|tala|wst" },
            { @"Sene", @"sene" },
            { @"São Tomé and Príncipe dobra", @"são tomé ve príncipe dobrası|sao tome ve principe dobrası|dobra|std" },
            { @"Sierra Leonean leone", @"sierra leone leonesi|sll|le" },
            { @"Peseta", @"ispanyol pesetası|peseta|esp" },
            { @"Netherlands guilder", @"hollanda antilleri|hollanda guldeni|ang|gulden|ƒ|fl|nlg|hollanda florini|florin" },
            { @"Swazi lilangeni", @"svaziland lilangenisi|lilangeni|szl" },
            { @"Tajikistani somoni", @"tacikistan somonisi|tjs|somoni" },
            { @"Diram", @"diram" },
            { @"Thai baht", @"tayland bahtı|฿|thb|baht" },
            { @"Satang", @"satang" },
            { @"Tongan paʻanga", @"tonga paʻangası|paʻanga|tonga pa'angası|pa'anga" },
            { @"Seniti", @"seniti" },
            { @"Ukrainian hryvnia", @"ukrayna grivnası|grivna|uah|₴" },
            { @"Vanuatu vatu", @"vanuatu vatusu|vatu|vuv" },
            { @"Venezuelan bolívar", @"venezuela bolívarı|venezuela bolivarı|bs.f.|vef" },
            { @"Vietnamese dong", @"vietnam dongu|vnd|đồng|dong" },
            { @"Hàos", @"hàos|haos" },
            { @"Zambian kwacha", @"zambiya kvaçası|zk|zmw|kvaça" },
            { @"Moroccan dirham", @"fas dirhemi|mad|د.م." },
            { @"United Arab Emirates dirham", @"birleşik arap emirlikleri|د.إ|aed" },
            { @"Azerbaijani manat", @"azerbaycan manatı|azn" },
            { @"Turkmenistan manat", @"türkmenistan manatı|türkmenistan yeni manat|tmt" },
            { @"Manat", @"manat" },
            { @"Qəpik", @"qəpik|qepik" },
            { @"Somali shilling", @"somali şilini|sos" },
            { @"Somaliland shilling", @"somaliland şilini" },
            { @"Tanzanian shilling", @"tanzanya şilini|tsh|tzs" },
            { @"Ugandan shilling", @"uganda şilini|sh|ugx" },
            { @"Romanian leu", @"romen leyi|rumen leyi|ron" },
            { @"Moldovan leu", @"moldova leyi|mdl" },
            { @"Leu", @"ley" },
            { @"Ban", @"ban" },
            { @"Nepalese rupee", @"nepal rupisi|npr" },
            { @"Pakistani rupee", @"pakistan rupisi|pkr" },
            { @"Indian rupee", @"hindistan rupisi|inr|₹" },
            { @"Seychellois rupee", @"seyşeller rupisi|scr|sr|sre" },
            { @"Mauritian rupee", @"mauritius rupisi|mur" },
            { @"Maldivian rufiyaa", @"maldiv rufiyaası|rf|mvr|.ރ" },
            { @"Sri Lankan rupee", @"sri lanka rupisi|lkr|රු|ரூ" },
            { @"Indonesian rupiah", @"Endonezya rupiahı|rupiah|perak|rp|idr" },
            { @"Rupee", @"rupi" },
            { @"Danish krone", @"danimarka kronu|dkk" },
            { @"Norwegian krone", @"norveç kronu|nok" },
            { @"Icelandic króna", @"izlanda kronu|isk" },
            { @"Swedish krona", @"isveç kronu|sek" },
            { @"Krone", @"kron" },
            { @"Øre", @"Øre|oyra|eyrir" },
            { @"West African CFA franc", @"batı afrika cfa frangı|xof" },
            { @"Central African CFA franc", @"orta afrika cfa frangı|xaf" },
            { @"Comorian franc", @"komorlar franc|kmf" },
            { @"Congolese franc", @"kongo frangı|cdf" },
            { @"Burundian franc", @"burundi frangı|bif" },
            { @"Djiboutian franc", @"cibuti frangı|djf" },
            { @"CFP franc", @"cfp frangı|xpf" },
            { @"Guinean franc", @"gine frangı|gnf" },
            { @"Swiss franc", @"isviçre frangı|chf|sfr." },
            { @"Rwandan franc", @"Ruanda frangı|rwf|rf|r₣|frw" },
            { @"Belgian franc", @"belçika frangı|bi.|b.fr.|bef" },
            { @"Rappen", @"rappen" },
            { @"Franc", @"frank|fr.|fs" },
            { @"Centime", @"santim" },
            { @"Russian ruble", @"rus rublesi|₽|rub" },
            { @"New Belarusian ruble", @"yeni beyaz rusya rublesi|yeni belarus rublesi|byn" },
            { @"Old Belarusian ruble", @"eski beyaz rusya rublesi|eski belarus rublesi|byr" },
            { @"Transnistrian ruble", @"transdinyester rublesi|prb|р." },
            { @"Belarusian ruble", @"beyaz rusya rublesi|belarus rublesi" },
            { @"Kopek", @"kopek" },
            { @"Kapyeyka", @"kapyeyka" },
            { @"Ruble", @"ruble|br" },
            { @"Algerian dinar", @"cezayir dinarı|د.ج|dzd" },
            { @"Bahraini dinar", @"bahreyn dinarı|bhd|.د.ب" },
            { @"Santeem", @"santim" },
            { @"Iraqi dinar", @"ırak dinarı|iqd|ع.د" },
            { @"Jordanian dinar", @"ürdün dinarı|د.ا|jod" },
            { @"Kuwaiti dinar", @"kuveyt dinarı|kwd|د.ك" },
            { @"Libyan dinar", @"libya dinarı|lyd" },
            { @"Serbian dinar", @"sırp dinarı|din.|rsd|дин." },
            { @"Tunisian dinar", @"tunus dinarı|tnd" },
            { @"Yugoslav dinar", @"yugoslav dinarı|yun" },
            { @"Dinar", @"dinar" },
            { @"Fils", @"fils" },
            { @"Para", @"para|napa" },
            { @"Santim", @"santim|santîm" },
            { @"Dirhem", @"dirhem" },
            { @"Millime", @"milim" },
            { @"Argentine peso", @"arjantin pesosu|ars" },
            { @"Chilean peso", @"şili pesos|clp" },
            { @"Colombian peso", @"kolombiya pesosu|cop" },
            { @"Cuban convertible peso", @"konvertibl küba pesosu|cuc" },
            { @"Cuban peso", @"küba pesosu|cup" },
            { @"Dominican peso", @"dominik pesosu|dop" },
            { @"Mexican peso", @"meksika pesosu|mxn" },
            { @"Philippine peso", @"filipinler pesosu|₱|php" },
            { @"Uruguayan peso", @"uruguay pesos|uyu" },
            { @"Peso", @"peso" },
            { @"Centavo", @"centavo" },
            { @"British pound", @"ingiliz sterlini|£|gbp|ingiliz poundu" },
            { @"Guernsey pound", @"guernsey sterlini|£|ggp|guernsey poundu" },
            { @"Saint Helena pound", @"saint helena sterlini|£|shp|saint helena poundu" },
            { @"Egyptian pound", @"mısır lirası|egp|ج.م" },
            { @"Falkland Islands pound", @"falkland adaları sterlini|£|fkp|falkland adaları poundu" },
            { @"Gibraltar pound", @"gibraltar sterlini|£|gip|gibraltar poundu" },
            { @"Manx pound", @"manx sterlini|£|imp|manx poundu" },
            { @"Jersey pound", @"jersey sterlini|£|jep|jersey poundu" },
            { @"Lebanese pound", @"lübnan lirası|lbp|ل.ل" },
            { @"South Sudanese pound", @"güney sudan lirası|ssp" },
            { @"Sudanese pound", @"sudan lirası|ج.س.|sdg" },
            { @"Syrian pound", @"suriye lirası|ل.س|syp" },
            { @"Pound", @"pound|sterlin|£|sterlini|sterline" },
            { @"Pence", @"pence" },
            { @"Shilling", @"shillings|shilling|shilingi|sh" },
            { @"Penny", @"peni" },
            { @"United States dollar", @"abd doları|a.b.d. doları|amerika birleşik devletleri doları|amerikan doları|usd|abd $|a.b.d. $" },
            { @"East Caribbean dollar", @"doğu karayip doları|xcd" },
            { @"Australian dollar", @"avustralya doları|aud" },
            { @"Bahamian dollar", @"bahama doları|bsd" },
            { @"Barbadian dollar", @"barbados doları|bbd" },
            { @"Belize dollar", @"belize doları|bzd" },
            { @"Bermudian dollar", @"bermuda doları|bmd" },
            { @"Brunei dollar", @"brunei doları|bnd" },
            { @"Sen", @"sen" },
            { @"Singapore dollar", @"singapur doları|sgd" },
            { @"Canadian dollar", @"kanada doları|cad|$ c" },
            { @"Cayman Islands dollar", @"cayman adaları doları|kyd" },
            { @"New Zealand dollar", @"yeni zelanda doları|nzd|kiwi" },
            { @"Fijian dollar", @"fiji doları|fjd" },
            { @"Guyanese dollar", @"guyana doları|gyd" },
            { @"Hong Kong dollar", @"hong kong doları|hkd" },
            { @"Jamaican dollar", @"jamaika doları|jmd" },
            { @"Liberian dollar", @"liberya dolları|lrd" },
            { @"Namibian dollar", @"namibya doları|nad" },
            { @"Pitcairn Islands dollar", @"pitcairn adaları doları" },
            { @"Solomon Islands dollar", @"solomon adaları doları|sbd" },
            { @"Surinamese dollar", @"surinam doları|srd" },
            { @"New Taiwan dollar", @"yeni tayvan doları|twd|ntd" },
            { @"Trinidad and Tobago dollar", @"trinidad ve tobago doları|ttd" },
            { @"Tuvaluan dollar", @"tuvalu doları" },
            { @"Dollar", @"dolar|$" },
            { @"Chinese yuan", @"yuan|kuai|çin yuanı|renminbi|cny|rmb|￥|元|yuanı" },
            { @"Fen", @"fen" },
            { @"Jiao", @"jiao|mao" },
            { @"Finnish markka", @"fin markkası|mk|fim|markka|fin markı" },
            { @"Penni", @"penni" }
        };
      public static readonly Dictionary<string, string> CurrencyNameToIsoCodeMap = new Dictionary<string, string>
        {
            { @"Afghan afghani", @"AFN" },
            { @"Euro", @"EUR" },
            { @"Albanian lek", @"ALL" },
            { @"Angolan kwanza", @"AOA" },
            { @"Armenian dram", @"AMD" },
            { @"Aruban florin", @"AWG" },
            { @"Bangladeshi taka", @"BDT" },
            { @"Bhutanese ngultrum", @"BTN" },
            { @"Bolivian boliviano", @"BOB" },
            { @"Bosnia and Herzegovina convertible mark", @"BAM" },
            { @"Botswana pula", @"BWP" },
            { @"Brazilian real", @"BRL" },
            { @"Bulgarian lev", @"BGN" },
            { @"Cambodian riel", @"KHR" },
            { @"Cape Verdean escudo", @"CVE" },
            { @"Costa Rican colón", @"CRC" },
            { @"Croatian kuna", @"HRK" },
            { @"Czech koruna", @"CZK" },
            { @"Eritrean nakfa", @"ERN" },
            { @"Ethiopian birr", @"ETB" },
            { @"Gambian dalasi", @"GMD" },
            { @"Georgian lari", @"GEL" },
            { @"Ghanaian cedi", @"GHS" },
            { @"Guatemalan quetzal", @"GTQ" },
            { @"Haitian gourde", @"HTG" },
            { @"Honduran lempira", @"HNL" },
            { @"Hungarian forint", @"HUF" },
            { @"Iranian rial", @"IRR" },
            { @"Yemeni rial", @"YER" },
            { @"Israeli new shekel", @"ILS" },
            { @"Japanese yen", @"JPY" },
            { @"Kazakhstani tenge", @"KZT" },
            { @"Kenyan shilling", @"KES" },
            { @"North Korean won", @"KPW" },
            { @"South Korean won", @"KRW" },
            { @"Kyrgyzstani som", @"KGS" },
            { @"Lao kip", @"LAK" },
            { @"Lesotho loti", @"LSL" },
            { @"South African rand", @"ZAR" },
            { @"Macanese pataca", @"MOP" },
            { @"Macedonian denar", @"MKD" },
            { @"Malagasy ariary", @"MGA" },
            { @"Malawian kwacha", @"MWK" },
            { @"Malaysian ringgit", @"MYR" },
            { @"Mauritanian ouguiya", @"MRO" },
            { @"Mongolian tögrög", @"MNT" },
            { @"Mozambican metical", @"MZN" },
            { @"Burmese kyat", @"MMK" },
            { @"Nicaraguan córdoba", @"NIO" },
            { @"Nigerian naira", @"NGN" },
            { @"Turkish lira", @"TRY" },
            { @"Omani rial", @"OMR" },
            { @"Panamanian balboa", @"PAB" },
            { @"Papua New Guinean kina", @"PGK" },
            { @"Paraguayan guaraní", @"PYG" },
            { @"Peruvian sol", @"PEN" },
            { @"Polish złoty", @"PLN" },
            { @"Qatari riyal", @"QAR" },
            { @"Saudi riyal", @"SAR" },
            { @"Samoan tālā", @"WST" },
            { @"São Tomé and Príncipe dobra", @"STD" },
            { @"Sierra Leonean leone", @"SLL" },
            { @"Swazi lilangeni", @"SZL" },
            { @"Tajikistani somoni", @"TJS" },
            { @"Thai baht", @"THB" },
            { @"Ukrainian hryvnia", @"UAH" },
            { @"Vanuatu vatu", @"VUV" },
            { @"Venezuelan bolívar", @"VEF" },
            { @"Zambian kwacha", @"ZMW" },
            { @"Moroccan dirham", @"MAD" },
            { @"United Arab Emirates dirham", @"AED" },
            { @"Azerbaijani manat", @"AZN" },
            { @"Turkmenistan manat", @"TMT" },
            { @"Somali shilling", @"SOS" },
            { @"Tanzanian shilling", @"TZS" },
            { @"Ugandan shilling", @"UGX" },
            { @"Romanian leu", @"RON" },
            { @"Moldovan leu", @"MDL" },
            { @"Nepalese rupee", @"NPR" },
            { @"Pakistani rupee", @"PKR" },
            { @"Indian rupee", @"INR" },
            { @"Seychellois rupee", @"SCR" },
            { @"Mauritian rupee", @"MUR" },
            { @"Maldivian rufiyaa", @"MVR" },
            { @"Sri Lankan rupee", @"LKR" },
            { @"Indonesian rupiah", @"IDR" },
            { @"Danish krone", @"DKK" },
            { @"Norwegian krone", @"NOK" },
            { @"Icelandic króna", @"ISK" },
            { @"Swedish krona", @"SEK" },
            { @"West African CFA franc", @"XOF" },
            { @"Central African CFA franc", @"XAF" },
            { @"Comorian franc", @"KMF" },
            { @"Congolese franc", @"CDF" },
            { @"Burundian franc", @"BIF" },
            { @"Djiboutian franc", @"DJF" },
            { @"CFP franc", @"XPF" },
            { @"Guinean franc", @"GNF" },
            { @"Swiss franc", @"CHF" },
            { @"Rwandan franc", @"RWF" },
            { @"Russian ruble", @"RUB" },
            { @"Transnistrian ruble", @"PRB" },
            { @"Belarusian ruble", @"BYN" },
            { @"Algerian dinar", @"DZD" },
            { @"Bahraini dinar", @"BHD" },
            { @"Iraqi dinar", @"IQD" },
            { @"Jordanian dinar", @"JOD" },
            { @"Kuwaiti dinar", @"KWD" },
            { @"Libyan dinar", @"LYD" },
            { @"Serbian dinar", @"RSD" },
            { @"Tunisian dinar", @"TND" },
            { @"Argentine peso", @"ARS" },
            { @"Chilean peso", @"CLP" },
            { @"Colombian peso", @"COP" },
            { @"Cuban convertible peso", @"CUC" },
            { @"Cuban peso", @"CUP" },
            { @"Dominican peso", @"DOP" },
            { @"Mexican peso", @"MXN" },
            { @"Uruguayan peso", @"UYU" },
            { @"British pound", @"GBP" },
            { @"Saint Helena pound", @"SHP" },
            { @"Egyptian pound", @"EGP" },
            { @"Falkland Islands pound", @"FKP" },
            { @"Gibraltar pound", @"GIP" },
            { @"Manx pound", @"IMP" },
            { @"Jersey pound", @"JEP" },
            { @"Lebanese pound", @"LBP" },
            { @"South Sudanese pound", @"SSP" },
            { @"Sudanese pound", @"SDG" },
            { @"Syrian pound", @"SYP" },
            { @"United States dollar", @"USD" },
            { @"Australian dollar", @"AUD" },
            { @"Bahamian dollar", @"BSD" },
            { @"Barbadian dollar", @"BBD" },
            { @"Belize dollar", @"BZD" },
            { @"Bermudian dollar", @"BMD" },
            { @"Brunei dollar", @"BND" },
            { @"Singapore dollar", @"SGD" },
            { @"Canadian dollar", @"CAD" },
            { @"Cayman Islands dollar", @"KYD" },
            { @"New Zealand dollar", @"NZD" },
            { @"Fijian dollar", @"FJD" },
            { @"Guyanese dollar", @"GYD" },
            { @"Hong Kong dollar", @"HKD" },
            { @"Jamaican dollar", @"JMD" },
            { @"Liberian dollar", @"LRD" },
            { @"Namibian dollar", @"NAD" },
            { @"Solomon Islands dollar", @"SBD" },
            { @"Surinamese dollar", @"SRD" },
            { @"New Taiwan dollar", @"TWD" },
            { @"Trinidad and Tobago dollar", @"TTD" },
            { @"Tuvaluan dollar", @"TVD" },
            { @"Chinese yuan", @"CNY" },
            { @"Pitcairn Islands dollar", @"PND" },
            { @"Guernsey pound", @"GGP" }
        };
      public static readonly Dictionary<string, string> FractionalUnitNameToCodeMap = new Dictionary<string, string>
        {
            { @"Jiao", @"JIAO" },
            { @"Kopek", @"KOPEK" },
            { @"Pul", @"PUL" },
            { @"Cent", @"CENT" },
            { @"Qindarkë", @"QINDARKE" },
            { @"Penny", @"PENNY" },
            { @"Santeem", @"SANTEEM" },
            { @"Cêntimo", @"CENTIMO" },
            { @"Centavo", @"CENTAVO" },
            { @"Luma", @"LUMA" },
            { @"Qəpik", @"QƏPIK" },
            { @"Fils", @"FILS" },
            { @"Poisha", @"POISHA" },
            { @"Kapyeyka", @"KAPYEYKA" },
            { @"Centime", @"CENTIME" },
            { @"Chetrum", @"CHETRUM" },
            { @"Paisa", @"PAISA" },
            { @"Fening", @"FENING" },
            { @"Thebe", @"THEBE" },
            { @"Sen", @"SEN" },
            { @"Stotinka", @"STOTINKA" },
            { @"Fen", @"FEN" },
            { @"Céntimo", @"CENTIMO" },
            { @"Lipa", @"LIPA" },
            { @"Haléř", @"HALER" },
            { @"Øre", @"ØRE" },
            { @"Piastre", @"PIASTRE" },
            { @"Santim", @"SANTIM" },
            { @"Oyra", @"OYRA" },
            { @"Butut", @"BUTUT" },
            { @"Tetri", @"TETRI" },
            { @"Pesewa", @"PESEWA" },
            { @"Fillér", @"FILLER" },
            { @"Eyrir", @"EYRIR" },
            { @"Dinar", @"DINAR" },
            { @"Agora", @"AGORA" },
            { @"Tïın", @"TIIN" },
            { @"Chon", @"CHON" },
            { @"Jeon", @"JEON" },
            { @"Tyiyn", @"TYIYN" },
            { @"Att", @"ATT" },
            { @"Sente", @"SENTE" },
            { @"Dirham", @"DIRHAM" },
            { @"Rappen", @"RAPPEN" },
            { @"Avo", @"AVO" },
            { @"Deni", @"DENI" },
            { @"Iraimbilanja", @"IRAIMBILANJA" },
            { @"Tambala", @"TAMBALA" },
            { @"Laari", @"LAARI" },
            { @"Khoums", @"KHOUMS" },
            { @"Ban", @"BAN" },
            { @"Möngö", @"MONGO" },
            { @"Pya", @"PYA" },
            { @"Kobo", @"KOBO" },
            { @"Kuruş", @"KURUS" },
            { @"Baisa", @"BAISA" },
            { @"Centésimo", @"CENTESIMO" },
            { @"Toea", @"TOEA" },
            { @"Sentimo", @"SENTIMO" },
            { @"Grosz", @"GROSZ" },
            { @"Sene", @"SENE" },
            { @"Halala", @"HALALA" },
            { @"Para", @"PARA" },
            { @"Öre", @"ORE" },
            { @"Diram", @"DIRAM" },
            { @"Satang", @"SATANG" },
            { @"Seniti", @"SENITI" },
            { @"Millime", @"MILLIME" },
            { @"Tennesi", @"TENNESI" },
            { @"Kopiyka", @"KOPIYKA" },
            { @"Tiyin", @"TIYIN" },
            { @"Hào", @"HAO" },
            { @"Ngwee", @"NGWEE" }
        };
      public const string CompoundUnitConnectorRegex = @"(?<spacer>\s)";
      public static readonly Dictionary<string, string> CurrencyPrefixList = new Dictionary<string, string>
        {
            { @"Türk lirası", @"₺" }
        };
      public static readonly IList<string> AmbiguousCurrencyUnitList = new List<string>
        {
            @"din",
            @"kina",
            @"para",
            @"sfr.",
            @"taka",
            @"tala",
            @"cop",
            @"cup",
            @"lak",
            @"pul",
            @"sar",
            @"sek",
            @"sen",
            @"sol",
            @"sos",
            @"std",
            @"yer",
            @"yen",
            @"yeni"
        };
      public static readonly Dictionary<string, string> InformationSuffixList = new Dictionary<string, string>
        {
            { @"Bit", @"bit|-bit" },
            { @"Kilobit", @"kilobit|kb|Kb|kbit" },
            { @"Megabit", @"megabit|mb|Mb|mbit" },
            { @"Gigabit", @"gigabit|gb|Gb|gbit" },
            { @"Terabit", @"terabit|tb|Tb|tbit" },
            { @"Petabit", @"petabit|pb|Pb|pbit" },
            { @"Byte", @"byte|bayt" },
            { @"Kilobyte", @"kilobayt|kilobyte|kB|KB|kilo byte|kbyte" },
            { @"Megabyte", @"megabayt|megabyte|mB|MB|mega byte|mbyte" },
            { @"Gigabyte", @"gigabayt|gigabyte|gB|GB|giga byte|gbyte" },
            { @"Terabyte", @"terabayt|terabyte|tB|TB|tera byte|tbyte" },
            { @"Petabyte", @"petabayt|petabyte|pB|PB|peta byte|pbyte" }
        };
      public static readonly IList<string> AmbiguousDimensionUnitList = new List<string>
        {
            @"pound",
            @"dram",
            @"varil",
            @"cup",
            @"in",
            @""""
        };
      public const string BuildPrefix = @"(?<=(\s|^))";
      public const string BuildSuffix = @"(?=(\s|\W|$))";
      public static readonly Dictionary<string, string> LengthSuffixList = new Dictionary<string, string>
        {
            { @"Kilometer", @"km|kilometre" },
            { @"Hectometer", @"hm|hektometre" },
            { @"Decameter", @"dam|dekametre" },
            { @"Meter", @"m|metre" },
            { @"Decimeter", @"dm|desimetre" },
            { @"Centimeter", @"cm|santimetre" },
            { @"Millimeter", @"mm|milimetre" },
            { @"Micrometer", @"μm|mikrometre" },
            { @"Nanometer", @"nm|nanometre" },
            { @"Picometer", @"pm|pikometre" },
            { @"Mile", @"mil|mi|milden" },
            { @"Yard", @"yarda|yd" },
            { @"Inch", @"inç|in|'""'" },
            { @"Foot", @"fit|ft|ayak|adım|ayakla" },
            { @"Light year", @"ışık yılı|Iy" },
            { @"Pt", @"pt|pts" }
        };
      public static readonly IList<string> AmbiguousLengthUnitList = new List<string>
        {
            @"m",
            @"fit",
            @"adım"
        };
      public static readonly Dictionary<string, string> SpeedSuffixList = new Dictionary<string, string>
        {
            { @"Meter per second", @"metre bölü saniye|metre/saniye|m/s|m/sn" },
            { @"Kilometer per hour", @"kilometre bölü saat|kilometre/saat|km/sa" },
            { @"Kilometer per minute", @"kilometre bölü dakika|kilometre/dakika|km/dk" },
            { @"Kilometer per second", @"kilometre bölü saniye|kilometre/saniye|km/s|km/sn" },
            { @"Mile per hour", @"mph|mil bölü saat|mil/saat|mil/sa" },
            { @"Knot", @"knot|kn" },
            { @"Foot per second", @"fit bölü saniye|fit/saniye|ft/sn|ft/s" },
            { @"Foot per minute", @"ft/dk|fit bölü dakika|fit/dakika" },
            { @"Yard per minute", @"yarda bölü dakika|yarda/dakika|yd/dk" },
            { @"Yard per second", @"yarda bölü saniye|yarda/saniye|yd/s|yd/sn" }
        };
      public static readonly Dictionary<string, string> SpeedPrefixList = new Dictionary<string, string>
        {
            { @"PerHour", @"saatte" },
            { @"PerMinute", @"dakikada" },
            { @"PerSecond", @"saniyede" }
        };
      public static readonly Dictionary<string, string> TemperatureSuffixList = new Dictionary<string, string>
        {
            { @"F", @"derece fahrenhayt|derece fahrenheit|derece f|fahrenheit derece|fahrenhayt derece|fahrenheit|°f|f|fahrenhayta|fahrenhaytı|fahrenhayttan|fahrenhayt|derece fahrenhaytı|derece fahrenhayttır" },
            { @"K", @"k|K|kelvin" },
            { @"R", @"rankine|°r" },
            { @"D", @"delisle|°de" },
            { @"C", @"santigrat derece|derece c|celsius|°c|c|santigratı|santigrata|santigrat dereceyi|santigratta|santigrat" },
            { @"Degree", @"derece|°|derecede|dereceyi|dereceye" }
        };
      public static readonly IList<string> AmbiguousTemperatureUnitList = new List<string>
        {
            @"c",
            @"f",
            @"k",
            @"K"
        };
      public static readonly Dictionary<string, string> VolumeSuffixList = new Dictionary<string, string>
        {
            { @"Cubic meter", @"metreküp|m3|m^3|m³" },
            { @"Cubic centimeter", @"santimetreküp|cm3|cm^3|cm³" },
            { @"Cubic millimiter", @"milimetreküp|mm3|mm^3|mm³" },
            { @"Hectoliter", @"hektolitre|hl" },
            { @"Decaliter", @"dekalitre|dal" },
            { @"Liter", @"litre|l" },
            { @"Deciliter", @"desilitre|dl" },
            { @"Centiliter", @"santilitre|cl" },
            { @"Milliliter", @"mililitre|ml" },
            { @"Cubic yard", @"kübik yard|kübik yds|cu yds|cu yd|yard/-3|yds/-3|yd/-3|yards^3|yard^3|yds^3|yd^3|yard³|yds³|yd³|yarda küp" },
            { @"Cubic inch", @"inç küp" },
            { @"Cubic foot", @"fit küp" },
            { @"Cubic mile", @"mil küp" },
            { @"Fluid ounce", @"sıvı ons" },
            { @"Teaspoon", @"tatlı kaşığı" },
            { @"Tablespoon", @"yemek kaşığı" },
            { @"Pint", @"pint" },
            { @"Volume unit", @"sıvı dram|çeyrek pint|kuart|minim|kord|peck|buşel|fıçı" }
        };
      public static readonly IList<string> AmbiguousVolumeUnitList = new List<string>
        {
            @"dal"
        };
      public static readonly Dictionary<string, string> WeightSuffixList = new Dictionary<string, string>
        {
            { @"Kilogram", @"kg|kilogram|kilo" },
            { @"Gram", @"g|gram" },
            { @"Milligram", @"mg|miligram" },
            { @"Barrel", @"varil" },
            { @"Gallon", @"galon|galonluk" },
            { @"Metric ton", @"metrik tonu|metrik tona|metrik tondan|metrik ton" },
            { @"Ton", @"t|ton|tona" },
            { @"Pound", @"lb|libre|libreden|libreye" },
            { @"Ounce", @"oz|ons" },
            { @"Weight unit", @"karat|zerre|dram" }
        };
      public static readonly IList<string> AmbiguousWeightUnitList = new List<string>
        {
            @"pound",
            @"ton"
        };
    }
}