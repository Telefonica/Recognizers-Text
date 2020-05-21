// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

package com.microsoft.recognizers.text.numberwithunit.resources;

import java.util.Arrays;
import java.util.List;
import java.util.Map;

import com.google.common.collect.ImmutableMap;

public class FrenchNumericWithUnit {

    public static final ImmutableMap<String, String> AgeSuffixList = ImmutableMap.<String, String>builder()
        .put("Ans", "ans")
        .put("Mois", "mois d'âge|mois d'age|mois")
        .put("Semaines", "semaine|semaines|semaines d'âge|semaines d'age")
        .put("Jour", "jours|jour")
        .build();

    public static final ImmutableMap<String, String> AreaSuffixList = ImmutableMap.<String, String>builder()
        .put("Kilomètre carré", "km2|km^2|km²|kilomètres carrés|kilomètre carré")
        .put("Hectomètre carré", "hm2|hm^2|hm²|hectomètre carré|hectomètres carrés")
        .put("Décamètre carré", "dam2|dam^2|dam²|décamètre carré|décamètres carrés")
        .put("Mètre carré", "m2|m^2|m²|mètre carré|mètres carrés")
        .put("Décimètre carré", "dm2|dm^2|dm²|décimètre carré|décimètres carrés")
        .put("Centimètre carré", "cm2|cm^2|cm²|centimètre carré|centimètres carrés")
        .put("Millimètre carré", "mm2|mm^2|mm²|millimètre carré|millimètres carrés")
        .put("Pouce carré", "pouces2|po2|pouce carré|pouces carrés|in^2|in²|in2")
        .put("Pied carré", "pied carré|pieds carrés|pi2|pi^2|pi²")
        .put("Mile carré", "mile carré|miles carrés|mi2|mi^2|mi²")
        .put("Acre", "acre|acres")
        .build();

    public static final ImmutableMap<String, String> CurrencySuffixList = ImmutableMap.<String, String>builder()
        .put("Abkhazie apsar", "abkhazie apsar|apsars")
        .put("Afghan afghani", "afghan afghani|؋|afn|afghanis|afghani")
        .put("Pul", "pul")
        .put("Euro", "euros|euro|€|eur|d'euros")
        .put("Cent", "cents|cent|-cents|-cent")
        .put("lek Albanais", "lek albanais|leks|lek")
        .put("Qindarkë", "qindarkë|qindarkës|qindarke|qindarkes")
        .put("Kwanza angolais", "kwanza angolais|kz|aoa|kwanza|kwanzas")
        .put("Dram arménien", "dram arménien|drams arméniens")
        .put("Florins d'Aruba", "florins aruba|ƒ|awg")
        .put("Bangladeshi taka", "bangladeshi taka|৳|bdt|taka|takas|bangladeshi takas")
        .put("Paisa", "poisha|paisa")
        .put("Ngultrum bhoutanais", "ngultrum bhoutanais|nu.|btn")
        .put("Chetrum", "chetrums|chetrum")
        .put("Boliviano bolivien", "boliviano bolivien|bolivianos bolivien|bolivianos bolivie|boliviano bolivie|bob|bs.")
        .put("Bosnie-Herzégovine mark convertible", "bosnie-herzégovine mark convertible|bosnie-et-herzégovine mark convertible|bam")
        .put("Fening", "fening|fenings")
        .put("Pula", "pula|bwp")
        .put("Thebe", "thebe")
        .put("Réal brésilien", "réal brésilien|réals brésilien|r$|brl|real bresil|reals bresilien")
        .put("Lev bulgare", "lev bulgare|levs bulgare|lv|bgn")
        .put("Stotinki búlgaro", "stotinki bulgare")
        .put("Riel cambodgien", "riel cambodgien|khr|៛")
        .put("Escudo du cap-vert", "escudo cap-verdien|cve")
        .put("Colon du costa rica", "colon du costa rica|colons du costa rica|crc|₡")
        .put("Colon du salvador", "colon du salvador|colons du salvador|svc")
        .put("Kuna croate", "kuna croate|kunas croate|kn|hrk")
        .put("Lipa", "lipa")
        .put("Couronne tchèque", "couronne tchèque|couronnes tchèque|czk|Kč")
        .put("Haléř", "haléř")
        .put("Nakfas érythréens", "nakfas érythréens|nfk|ern|nakfa érythréens")
        .put("Birr éthiopien", "birr éthiopien|birrs éthiopien|etb")
        .put("Dalasi gambienne", "gmd")
        .put("Butut", "bututs|butut")
        .put("Lari géorgien", "lari géorgie|lari géorgiens|gel|₾")
        .put("Tetri géorgien", "tetri géorgie|tetris géorgiens")
        .put("Cedi", "cedi|ghs|cedi ghanéen|gh₵")
        .put("Pesewa", "pesewa|pesewas")
        .put("Quetzal guatémaltèque", "quetzal guatémaltèque|gtq|quetzal|quetzales")
        .put("Gourdes haïtiennes", "gourdes haïtiennes|gourdes|htg|gourde haïtienne")
        .put("Lempira hondurien", "lempira hondurien|hnl")
        .put("Forint hongrois", "forint hongrois|huf|fg|forints hongrois")
        .put("Fillér", "fillér")
        .put("Rial iranien", "rial iranien|irr|rials iranien|rials iraniens")
        .put("Litas lituanien", "litas lituanien|ltl|lit lithuanien|litas lithuanie")
        .put("Yen Japonais", "yen japonais|yen japon|yens|jpy|yen|¥|-yen")
        .put("Tenge kazakh", "tenge kazakh|kzt")
        .put("Shilling kényan", "shilling kényan|kes|shillings kényans")
        .put("Won coréen", "won coréen|won coréens|₩")
        .put("Won sud-coréen", "won sud-coréen|won sud coréen|won sud-coréens|krw")
        .put("Corée du nord won", "corée du nord won|corée nord won|kpw")
        .put("Som Kirghizie", "som kirghizie|kgs")
        .put("Sum Ouzbékistan", "sum ouzbékistan|sum ouzbeks|sum ouzbéks|uzs")
        .put("Kip laotien", "kip laotien|lak|₭n|₭")
        .put("Att", "att")
        .put("Loti", "loti|maloti|lsl")
        .put("Sente", "sente|lisente")
        .put("Rand sud-africain", "rand sud-africain|zar")
        .put("Pataca macanais", "pataca macanais|mop$|mop")
        .put("Avo", "avos|avo")
        .put("Dinar macédonien", "dinar macédonien|mkd|ден")
        .put("Deni", "deni")
        .put("Ariary malagache", "ariary malagache|mga")
        .put("Iraimbilanja", "Iraimbilanja")
        .put("Kwacha malawien", "kwacha malawien|mk|mwk")
        .put("Tambala", "Tambala")
        .put("Ringitt malaisien", "ringitt malaisien|rm|myr|ringitts malaisien")
        .put("Ouguiya mauritanienne", "ouguiya|um|mro|ouguiya mauritanien|ouguiya mauritanienne")
        .put("Khoums", "khoums")
        .put("Togrogs mongoles", "togrogs mongoles|togrogs|tugriks|tögrög|mnt|₮|tögrög mongoles|tögrög mongolie|togrogs mongolie")
        .put("Metical mozambique", "metical du mozambique|metical mozambique|mt|mzn|meticals mozambique")
        .put("Kyat birmanie", "kyat birmanie|ks|mmk")
        .put("Pya", "pya")
        .put("Cordoba nicaraguayen", "cordoba nicaraguayen|córdoba nicaraguayen|nio|córdoba oro|cordoba oro nicaraguayen")
        .put("Naira nigérians", "naira nigérians|naira|ngm|₦|nairas nigérians")
        .put("Livre turque", "livre turque|try|tl|livre turques")
        .put("Kuruş", "kuruş")
        .put("Rials omanais", "rials omanais|omr|ر.ع.|rial omanais")
        .put("Balboa panaméennes", "balboa panaméennes|balboa|pab")
        .put("Kina", "kina|pkg|pgk")
        .put("Toea", "toea")
        .put("Guaraní paraguayen", "guaraní paraguayen|₲|pyg")
        .put("Sol péruvien", "nuevo sol péruvien|soles|sol|sol péruvien")
        .put("Złoty polonais", "złoty polonais|złoty|zł|pln|zloty|zloty polonais")
        .put("Groxz", "groszy|grosz|grosze")
        .put("Riyal qatari", "riyal qatari|qar|riyals qatari")
        .put("Riyal saudi", "riyal saudi|sar|riyals saudi")
        .put("Riyal", "riyal|riyals|rial|﷼")
        .put("Dirham", "dirham|dirhem|dirhm")
        .put("Halala", "halalas|halala")
        .put("Tala", "tala|tālā|ws$|sat|wst")
        .put("Sene", "sene")
        .put("Dobra", "dobra|db|std")
        .put("Leone", "leone|sll")
        .put("Florins Néerlandais", "florins hollandais|florins néerlandais|florins|ang|florin|fl")
        .put("Lilangeni", "lilangeni|szl")
        .put("Somoni tadjikistan", "somoni tadjikistan|tjs|somoni")
        .put("Diram", "dirams|diram")
        .put("Baht thaïlandais", "baht thaïlandais|baht thailandais|baht thaï|baht thai|baht|฿|thb")
        .put("Satang", "satang|satangs")
        .put("Paʻanga", "paʻanga|pa'anga|top")
        .put("Hryvnia ukrainien", "hryvnia ukrainien|hyrvnia|uah|₴|hryvnias ukrainien|hryvnia ukrainienne")
        .put("Vanuatu vatu", "vanuatu vatu|vatu|vuv")
        .put("Bolívar vénézuélien", "bolívar vénézuélien|bolivar venezuelien|bs.f.|vef|bolívars vénézuélien|bolivars venezuelien")
        .put("Dong vietnamien", "dong vietnamien|dongs vietnamiens|dong|đồng|vnd|dông|dông vietnamiens")
        .put("Kwacha de Zambie", "kwacha de zambie|zk|zmw|kwachas")
        .put("Dirham marocain", "dirham marocain|mad|د.م.")
        .put("Dirham des Émirats arabes unis", "dirham des Émirats arabes unis|د.إ|aed")
        .put("Manat azerbaïdjanais", "manat azerbaïdjanais|manat azerbaidjanais|azn")
        .put("Manat turkmène", "manat turkmène|tmt|manat turkmene")
        .put("Manat", "manats|manat")
        .put("Qəpik", "qəpik")
        .put("Shilling somalien", "shilling somalien|shillings somalien|sos")
        .put("Shilling tanzanien", "shilling tanzanien|shillings tanzanien|tzs|tsh|shilling tanzanienne|shillings tanzanienne")
        .put("Shilling ougandais", "shilling ougandais|shillings ougandais|ugx")
        .put("Leu roumain", "leu roumain|lei|leu roumaine|ron")
        .put("Leu moldave", "leu meoldave|mdl")
        .put("Leu", "leu")
        .put("Ban", "bani|-ban|ban")
        .put("Roupie népalaise", "roupie népalaise|roupie nepalaise|npr")
        .put("Roupie pakistanaise", "roupie pakistanaise|pkr")
        .put("Roupie indienne", "roupie indienne|inr|roupie indien|inr|₹")
        .put("Roupie seychelloise", "roupie seychelloise|scr|sr|sre")
        .put("Roupie mauricienne", "roupie mauricienne|mur")
        .put("Rufiyaa maldives", "rufiyaa maldives|mvr|.ރ|rf")
        .put("Roupie srilankaise", "roupie srilankaise|lrk|රු|ரூ")
        .put("Rupiah Indonésie", "rupia indonésie|rupia indonesie|rupiah|rp|idr")
        .put("Roupie", "roupie")
        .put("Couronne danoise", "couronne danoise|dkk|couronnes danoise|couronne danemark|couronnes danemark")
        .put("Couronne norvégienne", "couronne norvégienne|couronne norvegienne|couronnes norvégienne|couronnes norvegienne|nok")
        .put("Couronne féroïenne", "couronne féroïenne|couronne feroienne")
        .put("Couronne suédoise", "couronne suédoise|couronne suéde|sek|couronnes suédoise|couronne suedoise")
        .put("Couronne", "couronne|couronnes")
        .put("Øre", "Øre|oyra|eyrir")
        .put("Franc CFA de l'Afrique de l'Ouest", "franc cfa de l''afrique de l''ouest|franc cfa ouest africain|franc cfa|francs cfa|fcfa|frs cfa|cfa francs|xof")
        .put("Franc CFA d'Afrique centrale", "franc cfa d''afrique centrale|franc cfa centrale|frs cfa centrale|xaf")
        .put("Franc comorien", "franc comorien|kmf")
        .put("Franc congolais", "franc congolais|cdf")
        .put("Franc burundais", "franc burundais|bif")
        .put("Franc djiboutienne", "franc djiboutienne|djf")
        .put("Franc CFP", "franc cfp|xpf")
        .put("Franc guinéen", "franc guinéen|gnf")
        .put("Franc Suisse", "franc suisse|chf|sfr.|francs suisses")
        .put("Franc rwandais", "franc rwandais|rwf|rw|r₣|frw")
        .put("Franc belge", "franc belge|bi.|b.fr.|bef")
        .put("Rappen", "rappen|-rappen")
        .put("Franc", "francs|franc|fr.|fs")
        .put("Centimes", "centimes|centime|santim")
        .put("Rouble russe", "rouble russe|rub|₽|₽ russe|roubles russe|roubles russes|₽ russes")
        .put("Nouveau rouble biélorusse", "nouveau rouble biélorusse|byn|nouveau roubles biélorusse|nouveau rouble bielorusse|nouveau roubles biélorusse")
        .put("Rouble transnistriens", "rouble transnistriens|prb")
        .put("Rouble biélorusses", "rouble biélorusses|roubles biélorusses|rouble bielorusses|roubles bielorusses")
        .put("Kopek", "kopek|kopeks")
        .put("Kapyeyka", "kapyeyka")
        .put("Rouble", "roubles|rouble|br")
        .put("Dinar algérien", "dinar algérien|د.ج|dzd|dinars algérien|dinar algerien|dinars algerien")
        .put("Dinar de bahreïn", "dinar de bahreïn|bhd|.د.ب|dinar de bahrein")
        .put("Santeem", "santeem|santeems")
        .put("Dinar iraquien", "dinar iraquien|dinars iraquien|iqd|ع.د|dinar iraquienne|dinars iraquienne")
        .put("Dinar jordanien", "dinar jordanien|dinars jordanien|د.ا|jod")
        .put("Dinar koweïtien", "dinar koweïtien|dinar koweitien|dinars koweïtien|kwd|د.ك")
        .put("Dinar libyen", "dinar libyen|dinars libyen|lyd")
        .put("Dinar serbe", "dinar serbe|dinars serbe|rsd|дин.")
        .put("Dinar tunisien", "dinar tunisien|dinars tunisien|tnd")
        .put("Dinar yougoslave", "dinar yougoslave|dinars yougoslave|yun")
        .put("Dinar", "dinars|dinar|denar|-dinars|-dinar")
        .put("Fils", "fils|fulūs|-fils|-fil")
        .put("Para", "para|napa")
        .put("Millime", "millimes|millime")
        .put("Peso argentin", "peso argentin|ars|pesos argentin|peso argentine|pesos argentine")
        .put("Peso chilien", "peso chilien|pesos chilien|clp")
        .put("Peso colombien", "peso colombien|pesos colombien|cop|peso colombie|pesos colombien")
        .put("Peso cubains convertibles", "peso cubains convertibles|pesos cubains convertibles|cuc")
        .put("Peso cubains", "peso cubaines|pesos cubaines|peso cubaine|pesos cubaines|cup")
        .put("Peso dominicain", "peso dominicain|pesos dominicain|dop|peso dominicaine|pesos dominicaine")
        .put("Peso philippin", "peso philippin|pesos philippin|piso|₱|php")
        .put("Peso uruguayen", "peso uruguayen|pesos uruguayen|uyu")
        .put("Peso", "pesos|Peso")
        .put("Centavo", "centavos|Centavo")
        .put("Livre britannique", "livre britannique|livres britannique|gbp|£ britannique")
        .put("Livre guernesey", "livre guernesey|£ guernesey|ggp")
        .put("Livre ascension", "livre ascension|livres ascension|£ ascension")
        .put("Livre sainte-hélène", "livre de sainte-hélène|livre sainte-hélène|livre sainte-helene|livre de sainte hélène|shp")
        .put("Livre égyptienne", "livre égyptienne|livre egyptienne|egp|ج.م")
        .put("Livre des îles falkland", "livre des îles falkland|livre des iles falkland|fkp|£ iles falkland")
        .put("Livre gibraltar", "livre gibraltar|livre de gibraltar|£ gibraltar|gip")
        .put("Livre manx", "imp|livre manx|£ manx")
        .put("Livre jersey", "livre de jersey|livre jersey|jep|£ jersey")
        .put("Livre libanaise", "livre libanaise|£ libanaise|livres libanaise|lbp|ل.ل")
        .put("Livre des îles malouines", "livre des îles malouines|livre des iles malouines|£ iles malouines")
        .put("Livre sud-soudanaise", "livre sud-soudanaise|livre sud soudanaise|livre du soudan du sud|livres sud-soudanaises|livre sud soudan|livre soudan sud")
        .put("Livre soudanaise", "livre soudanaise|livres soudanaise|sdg|£ soudan|ج.س.|livre soudan|livres soudan")
        .put("Livre syrienne", "livre syrienne|ل.س|syp|livre syrie|livres syrie|£ syrie")
        .put("Livre", "livre|livres|-livre|-livres|£")
        .put("Pence", "pence")
        .put("Shilling", "shilling|shillings|sh")
        .put("Penny", "penny|sou")
        .put("Dollar États-Unis", "dollar américain|$ américain|$ americain|usd|$usd|$ usd|dollar americain|dollar États-Unis|dollar des États-Unis|dollar États Unis|dollar etats unis|dollar etats-unis|$ etats-unis|$ États-Unis")
        .put("Dollar des Caraïbes orientales", "dollar des caraïbes orientales|dollar des caraibes orientales|xcd|$ caraibes orientales|$ caraïbes orientales")
        .put("Dollar Australien", "dollar australien|dollars australiens|$ australien|aud|$australien|australien $|$ australie|dollar australie")
        .put("Dollar des bahamas", "dollar des bahamas|dollar bahamas|$ bahamas|bsd|bahama $|dollar bahama|$ bahamas")
        .put("Dollar des bermudes", "dollar des bermudes|dollar bermude|dollar bermudes|$ bermudes|bmd")
        .put("Dollar de belize", "dollar de Belize|dollar belizien|bzd|$ belize")
        .put("Dollar îles Vierges britanniques", "dollar îles vierges britanniques|dollar iles vierges britanniques|$ iles vierges britanniques")
        .put("Dollar de brunei", "dollar de brunei|$ brunei|bnd|dollar brunei")
        .put("Sen", "sen")
        .put("Dollar de Singapour", "dollar de singapour|dollar singapour|$ sinapour|sgd|$s")
        .put("Dollar Canadien", "dollar canadien|dollars canadien|$ canadien|cad|$can|$c|$ c|dollar canada|dollar canadienne|$ canada|$cad|cad$")
        .put("Dollar des îles Caïmans", "dollars des îles caïmanes|dollar des îles caïmanes|dollars des iles caimanes|dollar iles caimanes|kyd|$ci")
        .put("Dollar néo-zélandais", "dollar néo-zélandais|dollar néo zélandais|dollar neo-zelandais|dollar neo zelandais|$nz|$ néo-zélandais|$ neo zelandais")
        .put("Dollar îles cook", "dollar îles cook|dollar iles cook|$ iles cook")
        .put("Dollar des fidji", "dollar des fidji|$ fidji|dollar fidji|dollar de fidji|dollars des fidji|dollars de fidji")
        .put("Dollar guyanien", "dollar guyanien|dollar du guyana|dollar dre guyana|$ guayana|gyd|$gy")
        .put("Dollar de Hong Kong", "dollar hong kong|dollar hongkong|dollar de hong kong|dollar de hongkong|$hk|$ hk|hkd|hk $|hk$|dollar hk|$hongkong|dollars hongkong|dollars hong kong")
        .put("Dollar jamaïcain", "dollar jamaïcain|dollars jamaïcain|dollar jamaicain|dollars jamaicain|$j|$ jamaïque|dollar jamaïque|jmd")
        .put("Dollar libérien", "dollar libérien|dollars libérien|dollar liberien|dollars liberien|lrd|$ libérien|$ liberia|$ liberien")
        .put("Dollar namibien", "dollar namibien|dollars namibien|$ namibien|nad|$n|dollar namibie|dollars namibie|$ namibie")
        .put("Dollar des îles Salomon", "dollar des îles Salomon|dollar des iles salomon|$si|sbd|$ iles salomon|$ îles salomon")
        .put("Dollar du suriname", "dollar du suriname|srd|$ du suriname|$ suriname|dollar suriname|dollars suriname|dollars du suriname")
        .put("Nouveau dollar de Taïwan", "nouveau dollar de taïwan|nouveau dollar de taiwan|twd|ntd|$nt")
        .put("Dollar trinidadien", "dollar trinidadien|dollars trinidadien|ttd|$ trinidadien")
        .put("Dollar", "dollar|$|dollars")
        .put("Yuan Chinois", "yuan|yuans|yuan chinois|renminbi|cny|rmb|￥")
        .put("Fen", "fen")
        .put("Jiao", "jiao")
        .put("Mark Finlandais", "marks finlandais|mark finlandais|fim|mark")
        .build();

    public static final String CompoundUnitConnectorRegex = "(?<spacer>[^.])";

    public static final ImmutableMap<String, String> CurrencyPrefixList = ImmutableMap.<String, String>builder()
        .put("Dollar", "$")
        .put("Dollar États-Unis", "$us|usd|us$")
        .put("Dollar des Caraïbes orientales", "xcd|$ec")
        .put("Dollar Australien", "a$|$a|aud")
        .put("Dollar des bahamas", "bsd|b$")
        .put("Dollar barbadien", "bbd|bds$")
        .put("Dollar de belize", "bz$|bzd")
        .put("Dollar des bermudes", "bd$|bmd")
        .put("Dollar de brunei", "brunei $|bnd")
        .put("Dollar de Singapour", "s$|sgd")
        .put("Dollar Canadien", "cad|$ ca|$ca|$ c")
        .put("Dollar des îles Caïmans", "ci$|kyd")
        .put("Dollar néo-zélandais", "nz$|nzd")
        .put("Dollar de Fidji", "$fj|fjd")
        .put("Dollar guyanien", "g$|gyd")
        .put("Dollar de Hong Kong", "hkd|hk$")
        .put("Dollar jamaïcain", "j$|jmd")
        .put("Dollar libérien", "lrd|l$")
        .put("Dollar namibien", "nad|n$")
        .put("Dollar des îles Salomon", "$ si|$si|sbd")
        .put("Nouveau dollar de Taïwan", "nt$|twd")
        .put("Réal brésilien", "r$|brl|reais")
        .put("Guaraní paraguayen", "₲|gs.|pyg")
        .put("Dollar trinidadien", "ttd|titis")
        .put("Yuan Chinois", "cny|rmb|￥|元")
        .put("Yen Japonais", "¥|jpy")
        .put("Euro", "€|eur")
        .put("Livre", "£")
        .build();

    public static final List<String> AmbiguousCurrencyUnitList = Arrays.asList("din.", "kina", "lari", "taka", "tala", "vatu", "yuan", "bob", "btn", "cop", "cup", "dop", "gip", "jod", "kgs", "lak", "mga", "mop", "nad", "omr", "sar", "sbd", "scr", "sdg", "sek", "sos", "std", "try", "yer");

    public static final ImmutableMap<String, String> InformationSuffixList = ImmutableMap.<String, String>builder()
        .put("Bit", "-bit|bit|bits")
        .put("Kilobit", "kilobit|kilobits|kb|kbit|kbits")
        .put("Megabit", "megabit|megabits|Mb|Mbit|mégabit|mégabits")
        .put("Gigabit", "gigabit|gigabits|Gb|Gbit")
        .put("Terabit", "terabit|terabits|Tb|Tbit|térabit|térabits")
        .put("Petabit", "petabit|petabits|Pb|Pbit|pétabit|pétabits")
        .put("octet", "octet|octets|-octet")
        .put("Kilooctet", "kilo-octet|kilo-octets|kilooctet|kilooctets|ko|kio|kB|KiB|kilobyte|kilobytes")
        .put("Mégaoctet", "mégaoctet|mégaoctets|méga-octet|méga-octets|Mo|Mio|MB|mégabyte|mégabytes")
        .put("Gigaoctet", "gigaoctet|gigaoctets|Go|Gio|GB|GiB|gigabyte|gigabytes")
        .put("Téraoctet", "téraoctet|téraoctets|To|Tio|TB|TiB|térabyte|térabytes")
        .put("Pétaoctet", "pétaoctet|pétaoctets|Po|Pio|PB|PiB|pétabyte|pétabytes")
        .build();

    public static final List<String> AmbiguousDimensionUnitList = Arrays.asList("mi", "barils", "grain", "l", "pierre", "fps", "pts");

    public static final String BuildPrefix = "(?<=(\\s|^|\\P{L}))";

    public static final String BuildSuffix = "(?=(\\s|\\P{L}|$))";

    public static final String ConnectorToken = "de";

    public static final ImmutableMap<String, String> LengthSuffixList = ImmutableMap.<String, String>builder()
        .put("Kilomètres", "km|kilomètres|kilomètre|kilometres|kilometre|-km")
        .put("Hectomètre", "hm|hectomètre|hectomètres|hectometre|hectometres|-hm")
        .put("Décamètre", "dam|décamètre|décamètres|decametre|decametres|-dm")
        .put("Mètres", "m|mètres|mètre|metres|metre|m.|-m")
        .put("Décimètres", "dm|décimètres|décimètre|decimetres|decimetre")
        .put("Centimètres", "cm|centimètres|centimètre|centimetres|centimetre")
        .put("Millimètres", "mm|millimètres|millimètre|millimetre|millimetres")
        .put("Micromètres", "µm|um|micromètres|micromètre|micrometres|micrometre")
        .put("Nanomètres", "nm|nanometre|nanometres|nanomètres|nanomètre")
        .put("Picomètres", "pm|picomètre|picomètres|picometres|picometre")
        .put("Mile", "mi|mile|miles")
        .put("Pied", "pied|pieds")
        .put("Yard", "yards|yard|yd")
        .put("Pouce", "pouce|pouces")
        .build();

    public static final List<String> AmbiguousLengthUnitList = Arrays.asList("m", "yard", "yards", "pm", "pt", "pts");

    public static final List<String> AmbuguousLengthUnitList = Arrays.asList("m", "pouce", "pm");

    public static final ImmutableMap<String, String> SpeedSuffixList = ImmutableMap.<String, String>builder()
        .put("Mètre par seconde", "m/s|metres/seconde|metres par seconde|metre par seconde|metres par secondes|mètre par seconde|mètres par seconde|mètres par secondes")
        .put("Kilomètre par heure", "km/h|kilomètre par heure|kilomètres par heure|kilomètres par heures|kilometres par heure|kilometre par heure")
        .put("Kilomètre par minute", "km/m|kilomètre par minute|kilomètres par minute|kilomètres par minutes|kilometre par minute|kilometre par minutes")
        .put("Kilomètre par seconde", "km/s|km à la seconde|km a la seconde|kilomètre par seconde|kilomètres par seconde|kilometre par seconde|kilometres par seconde")
        .put("Miles par heure", "mph|miles par heure|miles à l'heure|miles a l'heure|miles un heure")
        .put("Noeuds", "noeud|noeuds|nuds")
        .put("Pied par seconde", "ft/s|pied par seconde|pieds par seconde|pied/s|pieds/s")
        .put("Pied par minute", "pieds/minute|pied/minute|ft/minute|ft/min|pied/min")
        .build();

    public static final ImmutableMap<String, String> TemperatureSuffixList = ImmutableMap.<String, String>builder()
        .put("Kelvin", "k|K|kelvin")
        .put("F", "°f|degres f|degrés f|deg f|° f|degrés fahrenheit|degres fahrenheit|fahrenheit")
        .put("R", "rankine|°r|° r")
        .put("C", "°c|deg c|degrés celsius|degrés c|degres celsius|celsius|deg celsius|degs celsius|centigrade|deg centigrade|degs centigrade|degrés centigrade|degres centigrade|degré centigrade|degre centigrade")
        .put("Degré", "degrés|degres|deg.|°| °|degré|degre|deg")
        .build();

    public static final ImmutableMap<String, String> VolumeSuffixList = ImmutableMap.<String, String>builder()
        .put("Mètre cube", "m3|m^3|m³|mètre cube|mètres cube|metre cube|metres cube")
        .put("Centimètre cube", "cm3|cm^3|cm³|centimètre cube|centimètres cube|centimetre cube|centimetres cube")
        .put("Millimètre cube", "mm3|mm^3|mm³|millimètre cube|millimètres cube|millimetre cube|millimetres cube")
        .put("Kilomètre cube", "km3|km^3|km³|kilomètre cube|kilomètres cube|kilometre cube|kilometres cube")
        .put("Pieds cube", "pieds cubes|pieds cube|pied cube|pied cubes")
        .put("Litre", "litre|litres|lts|l")
        .put("Millilitre", "ml|millilitre|millilitres")
        .put("Gallon", "gallon|gallons")
        .put("Pintes", "pintes")
        .put("Onces", "onces|once|oz")
        .put("Décilitre", "dl|décilitre|decilitre|décilitres|decilitres")
        .put("Centilitre", "cl|centilitres|centilitre")
        .put("Onces liquides", "onces liquides|once liquide|once liquides")
        .put("Baril", "baril|barils|bbl")
        .build();

    public static final List<String> AmbiguousVolumeUnitList = Arrays.asList("ounce", "oz", "l", "cup", "peck", "cord", "gill");

    public static final ImmutableMap<String, String> WeightSuffixList = ImmutableMap.<String, String>builder()
        .put("Kilogramme", "kg|kilogramme|kilogrammes|kilo|kilos")
        .put("Gram", "g|gramme|grammes")
        .put("Milligramme", "mg|milligramme|milligrammes")
        .put("Tonne métrique", "tonne métrique|tonnes métrique|tonnes métriques|tonne metrique|tonnes metrique")
        .put("Tonne", "tonne|tonnes|-tonnes|-tonne")
        .put("Livre", "livre|livres")
        .build();

    public static final List<String> AmbiguousWeightUnitList = Arrays.asList("g", "oz", "stone", "dram");

    public static final ImmutableMap<String, String> AmbiguityFiltersDict = ImmutableMap.<String, String>builder()
        .put("\\bcent\\b", "\\bpour\\s+cent\\b")
        .build();
}
