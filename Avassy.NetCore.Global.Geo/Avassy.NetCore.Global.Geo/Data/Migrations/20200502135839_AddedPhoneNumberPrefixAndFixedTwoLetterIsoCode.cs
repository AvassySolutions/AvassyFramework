﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Avassy.NetCore.Global.Geo.Data.Migrations
{
    public partial class AddedPhoneNumberPrefixAndFixedTwoLetterIsoCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumberPrefix",
                table: "Countries",
                nullable: true);

            migrationBuilder.UpdateData("Countries", "IsoCode", "AD", "PhoneNumberPrefix", "+376");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AE", "PhoneNumberPrefix", "+971");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AF", "PhoneNumberPrefix", "+93");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AG", "PhoneNumberPrefix", "+1268");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AI", "PhoneNumberPrefix", "+1264");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AL", "PhoneNumberPrefix", "+355");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AM", "PhoneNumberPrefix", "+374");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AO", "PhoneNumberPrefix", "+244");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AR", "PhoneNumberPrefix", "+54");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AS", "PhoneNumberPrefix", "+1684");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AT", "PhoneNumberPrefix", "+43");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AU", "PhoneNumberPrefix", "+61");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AW", "PhoneNumberPrefix", "+297");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AX", "PhoneNumberPrefix", "+358");
            migrationBuilder.UpdateData("Countries", "IsoCode", "AZ", "PhoneNumberPrefix", "+994");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BA", "PhoneNumberPrefix", "+387");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BB", "PhoneNumberPrefix", "+1246");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BD", "PhoneNumberPrefix", "+880");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BE", "PhoneNumberPrefix", "+32");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BF", "PhoneNumberPrefix", "+226");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BG", "PhoneNumberPrefix", "+359");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BH", "PhoneNumberPrefix", "+973");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BI", "PhoneNumberPrefix", "+257");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BJ", "PhoneNumberPrefix", "+229");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BL", "PhoneNumberPrefix", "+590");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BM", "PhoneNumberPrefix", "+1441");
            migrationBuilder.UpdateData("Countries", "IsoCode", "B", "PhoneNumberPrefix", "+673");
            migrationBuilder.UpdateData("Countries", "IsoCode", "B", "IsoCode", "BN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BO", "PhoneNumberPrefix", "+591");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BQ", "PhoneNumberPrefix", "+599");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BR", "PhoneNumberPrefix", "+55");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BS", "PhoneNumberPrefix", "+1242");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BT", "PhoneNumberPrefix", "+975");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BW", "PhoneNumberPrefix", "+267");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BY", "PhoneNumberPrefix", "+375");
            migrationBuilder.UpdateData("Countries", "IsoCode", "BZ", "PhoneNumberPrefix", "+501");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CA", "PhoneNumberPrefix", "+1");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CC", "PhoneNumberPrefix", "+61");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CD", "PhoneNumberPrefix", "+243");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CF", "PhoneNumberPrefix", "+236");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CG", "PhoneNumberPrefix", "+242");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CH", "PhoneNumberPrefix", "+41");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CI", "PhoneNumberPrefix", "+225");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CK", "PhoneNumberPrefix", "+682");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CL", "PhoneNumberPrefix", "+56");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CM", "PhoneNumberPrefix", "+237");
            migrationBuilder.UpdateData("Countries", "IsoCode", "C", "PhoneNumberPrefix", "+86");
            migrationBuilder.UpdateData("Countries", "IsoCode", "C", "IsoCode", "CN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CO", "PhoneNumberPrefix", "+57");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CR", "PhoneNumberPrefix", "+509");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CU", "PhoneNumberPrefix", "+53");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CV", "PhoneNumberPrefix", "+238");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CW", "PhoneNumberPrefix", "+599");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CX", "PhoneNumberPrefix", "+61");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CY", "PhoneNumberPrefix", "+357");
            migrationBuilder.UpdateData("Countries", "IsoCode", "CZ", "PhoneNumberPrefix", "+420");
            migrationBuilder.UpdateData("Countries", "IsoCode", "DE", "PhoneNumberPrefix", "+49");
            migrationBuilder.UpdateData("Countries", "IsoCode", "DJ", "PhoneNumberPrefix", "+53");
            migrationBuilder.UpdateData("Countries", "IsoCode", "DK", "PhoneNumberPrefix", "+45");
            migrationBuilder.UpdateData("Countries", "IsoCode", "DM", "PhoneNumberPrefix", "+1767");
            migrationBuilder.UpdateData("Countries", "IsoCode", "DO", "PhoneNumberPrefix", "+1849");
            migrationBuilder.UpdateData("Countries", "IsoCode", "DZ", "PhoneNumberPrefix", "+213");
            migrationBuilder.UpdateData("Countries", "IsoCode", "EC", "PhoneNumberPrefix", "+593");
            migrationBuilder.UpdateData("Countries", "IsoCode", "EE", "PhoneNumberPrefix", "+372");
            migrationBuilder.UpdateData("Countries", "IsoCode", "EG", "PhoneNumberPrefix", "+20");
            migrationBuilder.UpdateData("Countries", "IsoCode", "EH", "PhoneNumberPrefix", "+212");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ER", "PhoneNumberPrefix", "+291");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ES", "PhoneNumberPrefix", "+34");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ET", "PhoneNumberPrefix", "+251");
            migrationBuilder.UpdateData("Countries", "IsoCode", "FI", "PhoneNumberPrefix", "+358");
            migrationBuilder.UpdateData("Countries", "IsoCode", "FJ", "PhoneNumberPrefix", "+679");
            migrationBuilder.UpdateData("Countries", "IsoCode", "FK", "PhoneNumberPrefix", "+500");
            migrationBuilder.UpdateData("Countries", "IsoCode", "FM", "PhoneNumberPrefix", "+691");
            migrationBuilder.UpdateData("Countries", "IsoCode", "FO", "PhoneNumberPrefix", "+298");
            migrationBuilder.UpdateData("Countries", "IsoCode", "FR", "PhoneNumberPrefix", "+33");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GA", "PhoneNumberPrefix", "+241");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GB", "PhoneNumberPrefix", "+44");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GD", "PhoneNumberPrefix", "+1473");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GE", "PhoneNumberPrefix", "+995");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GF", "PhoneNumberPrefix", "+594");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GG", "PhoneNumberPrefix", "+44");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GH", "PhoneNumberPrefix", "+233");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GI", "PhoneNumberPrefix", "+350");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GL", "PhoneNumberPrefix", "+299");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GM", "PhoneNumberPrefix", "+220");
            migrationBuilder.UpdateData("Countries", "IsoCode", "G", "PhoneNumberPrefix", "+224");
            migrationBuilder.UpdateData("Countries", "IsoCode", "G", "IsoCode", "GN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GP", "PhoneNumberPrefix", "+590");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GQ", "PhoneNumberPrefix", "+240");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GR", "PhoneNumberPrefix", "+30");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GS", "PhoneNumberPrefix", "+500");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GT", "PhoneNumberPrefix", "+502");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GU", "PhoneNumberPrefix", "+1671");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GW", "PhoneNumberPrefix", "+245");
            migrationBuilder.UpdateData("Countries", "IsoCode", "GY", "PhoneNumberPrefix", "+595");
            migrationBuilder.UpdateData("Countries", "IsoCode", "HK", "PhoneNumberPrefix", "+852");
            migrationBuilder.UpdateData("Countries", "IsoCode", "H", "PhoneNumberPrefix", "+504");
            migrationBuilder.UpdateData("Countries", "IsoCode", "H", "IsoCode", "HN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "HR", "PhoneNumberPrefix", "+385");
            migrationBuilder.UpdateData("Countries", "IsoCode", "HT", "PhoneNumberPrefix", "+509");
            migrationBuilder.UpdateData("Countries", "IsoCode", "HU", "PhoneNumberPrefix", "+36");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ID", "PhoneNumberPrefix", "+62");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IE", "PhoneNumberPrefix", "+353");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IL", "PhoneNumberPrefix", "+972");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IM", "PhoneNumberPrefix", "+44");
            migrationBuilder.UpdateData("Countries", "IsoCode", "I", "PhoneNumberPrefix", "+91");
            migrationBuilder.UpdateData("Countries", "IsoCode", "I", "IsoCode", "IN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IO", "PhoneNumberPrefix", "+246");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IQ", "PhoneNumberPrefix", "+964");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IR", "PhoneNumberPrefix", "+98");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IS", "PhoneNumberPrefix", "+354");
            migrationBuilder.UpdateData("Countries", "IsoCode", "IT", "PhoneNumberPrefix", "+39");
            migrationBuilder.UpdateData("Countries", "IsoCode", "JE", "PhoneNumberPrefix", "+44");
            migrationBuilder.UpdateData("Countries", "IsoCode", "JM", "PhoneNumberPrefix", "+1876");
            migrationBuilder.UpdateData("Countries", "IsoCode", "JO", "PhoneNumberPrefix", "+962");
            migrationBuilder.UpdateData("Countries", "IsoCode", "JP", "PhoneNumberPrefix", "+81");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KE", "PhoneNumberPrefix", "+254");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KG", "PhoneNumberPrefix", "+996");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KH", "PhoneNumberPrefix", "+855");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KI", "PhoneNumberPrefix", "+686");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KM", "PhoneNumberPrefix", "+269");
            migrationBuilder.UpdateData("Countries", "IsoCode", "K", "PhoneNumberPrefix", "+1869");
            migrationBuilder.UpdateData("Countries", "IsoCode", "K", "IsoCode", "KN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KP", "PhoneNumberPrefix", "+850");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KR", "PhoneNumberPrefix", "+82");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KW", "PhoneNumberPrefix", "+965");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KY", "PhoneNumberPrefix", "+345");
            migrationBuilder.UpdateData("Countries", "IsoCode", "KZ", "PhoneNumberPrefix", "+77");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LA", "PhoneNumberPrefix", "+856");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LB", "PhoneNumberPrefix", "+961");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LC", "PhoneNumberPrefix", "+1758");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LI", "PhoneNumberPrefix", "+423");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LK", "PhoneNumberPrefix", "+94");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LR", "PhoneNumberPrefix", "+231");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LS", "PhoneNumberPrefix", "+266");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LT", "PhoneNumberPrefix", "+370");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LU", "PhoneNumberPrefix", "+352");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LV", "PhoneNumberPrefix", "+371");
            migrationBuilder.UpdateData("Countries", "IsoCode", "LY", "PhoneNumberPrefix", "+218");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MA", "PhoneNumberPrefix", "+212");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MC", "PhoneNumberPrefix", "+377");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MD", "PhoneNumberPrefix", "+373");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ME", "PhoneNumberPrefix", "+382");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MF", "PhoneNumberPrefix", "+590");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MG", "PhoneNumberPrefix", "+261");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MH", "PhoneNumberPrefix", "+692");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MK", "PhoneNumberPrefix", "+389");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ML", "PhoneNumberPrefix", "+223");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MM", "PhoneNumberPrefix", "+95");
            migrationBuilder.UpdateData("Countries", "IsoCode", "M", "PhoneNumberPrefix", "+976");
            migrationBuilder.UpdateData("Countries", "IsoCode", "M", "IsoCode", "MN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MO", "PhoneNumberPrefix", "+853");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MP", "PhoneNumberPrefix", "+1670");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MQ", "PhoneNumberPrefix", "+596");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MR", "PhoneNumberPrefix", "+222");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MS", "PhoneNumberPrefix", "+1664");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MT", "PhoneNumberPrefix", "+356");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MU", "PhoneNumberPrefix", "+230");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MV", "PhoneNumberPrefix", "+960");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MW", "PhoneNumberPrefix", "+265");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MX", "PhoneNumberPrefix", "+52");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MY", "PhoneNumberPrefix", "+60");
            migrationBuilder.UpdateData("Countries", "IsoCode", "MZ", "PhoneNumberPrefix", "+258");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NA", "PhoneNumberPrefix", "+264");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NC", "PhoneNumberPrefix", "+687");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NE", "PhoneNumberPrefix", "+227");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NF", "PhoneNumberPrefix", "+672");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NG", "PhoneNumberPrefix", "+234");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NI", "PhoneNumberPrefix", "+505");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NL", "PhoneNumberPrefix", "+31");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NO", "PhoneNumberPrefix", "+47");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NP", "PhoneNumberPrefix", "+977");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NR", "PhoneNumberPrefix", "+674");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NU", "PhoneNumberPrefix", "+683");
            migrationBuilder.UpdateData("Countries", "IsoCode", "NZ", "PhoneNumberPrefix", "+64");
            migrationBuilder.UpdateData("Countries", "IsoCode", "OM", "PhoneNumberPrefix", "+968");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PA", "PhoneNumberPrefix", "+507");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PE", "PhoneNumberPrefix", "+51");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PF", "PhoneNumberPrefix", "+689");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PG", "PhoneNumberPrefix", "+675");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PH", "PhoneNumberPrefix", "+63");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PK", "PhoneNumberPrefix", "+92");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PL", "PhoneNumberPrefix", "+48");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PM", "PhoneNumberPrefix", "+508");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PR", "PhoneNumberPrefix", "+1939");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PS", "PhoneNumberPrefix", "+970");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PT", "PhoneNumberPrefix", "+351");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PW", "PhoneNumberPrefix", "+680");
            migrationBuilder.UpdateData("Countries", "IsoCode", "PY", "PhoneNumberPrefix", "+595");
            migrationBuilder.UpdateData("Countries", "IsoCode", "QA", "PhoneNumberPrefix", "+974");
            migrationBuilder.UpdateData("Countries", "IsoCode", "RE", "PhoneNumberPrefix", "+262");
            migrationBuilder.UpdateData("Countries", "IsoCode", "RO", "PhoneNumberPrefix", "+40");
            migrationBuilder.UpdateData("Countries", "IsoCode", "RS", "PhoneNumberPrefix", "+381");
            migrationBuilder.UpdateData("Countries", "IsoCode", "RU", "PhoneNumberPrefix", "+7");
            migrationBuilder.UpdateData("Countries", "IsoCode", "RW", "PhoneNumberPrefix", "+250");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SA", "PhoneNumberPrefix", "+966");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SB", "PhoneNumberPrefix", "+677");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SC", "PhoneNumberPrefix", "+248");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SD", "PhoneNumberPrefix", "+249");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SE", "PhoneNumberPrefix", "+46");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SG", "PhoneNumberPrefix", "+65");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SH", "PhoneNumberPrefix", "+290");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SI", "PhoneNumberPrefix", "+386");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SJ", "PhoneNumberPrefix", "+47");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SK", "PhoneNumberPrefix", "+421");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SL", "PhoneNumberPrefix", "+232");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SM", "PhoneNumberPrefix", "+378");
            migrationBuilder.UpdateData("Countries", "IsoCode", "S", "PhoneNumberPrefix", "+221");
            migrationBuilder.UpdateData("Countries", "IsoCode", "S", "IsoCode", "SN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SO", "PhoneNumberPrefix", "+252");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SR", "PhoneNumberPrefix", "+597");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SS", "PhoneNumberPrefix", "+211");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ST", "PhoneNumberPrefix", "+239");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SV", "PhoneNumberPrefix", "+503");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SX", "PhoneNumberPrefix", "+599");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SY", "PhoneNumberPrefix", "+963");
            migrationBuilder.UpdateData("Countries", "IsoCode", "SZ", "PhoneNumberPrefix", "+268");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TC", "PhoneNumberPrefix", "+1649");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TD", "PhoneNumberPrefix", "+235");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TF", "PhoneNumberPrefix", "+262");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TG", "PhoneNumberPrefix", "+228");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TH", "PhoneNumberPrefix", "+66");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TJ", "PhoneNumberPrefix", "+992");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TK", "PhoneNumberPrefix", "+690");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TL", "PhoneNumberPrefix", "+670");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TM", "PhoneNumberPrefix", "+993");
            migrationBuilder.UpdateData("Countries", "IsoCode", "T", "PhoneNumberPrefix", "+216");
            migrationBuilder.UpdateData("Countries", "IsoCode", "T", "IsoCode", "TN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TO", "PhoneNumberPrefix", "+676");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TR", "PhoneNumberPrefix", "+90");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TT", "PhoneNumberPrefix", "+1868");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TV", "PhoneNumberPrefix", "+688");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TW", "PhoneNumberPrefix", "+886");
            migrationBuilder.UpdateData("Countries", "IsoCode", "TZ", "PhoneNumberPrefix", "+255");
            migrationBuilder.UpdateData("Countries", "IsoCode", "UA", "PhoneNumberPrefix", "+380");
            migrationBuilder.UpdateData("Countries", "IsoCode", "UG", "PhoneNumberPrefix", "+256");
            migrationBuilder.UpdateData("Countries", "IsoCode", "UM", "PhoneNumberPrefix", "+246");
            migrationBuilder.UpdateData("Countries", "IsoCode", "US", "PhoneNumberPrefix", "+1");
            migrationBuilder.UpdateData("Countries", "IsoCode", "UY", "PhoneNumberPrefix", "+598");
            migrationBuilder.UpdateData("Countries", "IsoCode", "UZ", "PhoneNumberPrefix", "+998");
            migrationBuilder.UpdateData("Countries", "IsoCode", "VC", "PhoneNumberPrefix", "+1784");
            migrationBuilder.UpdateData("Countries", "IsoCode", "VE", "PhoneNumberPrefix", "+58");
            migrationBuilder.UpdateData("Countries", "IsoCode", "VG", "PhoneNumberPrefix", "+1284");
            migrationBuilder.UpdateData("Countries", "IsoCode", "VI", "PhoneNumberPrefix", "+1340");
            migrationBuilder.UpdateData("Countries", "IsoCode", "V", "PhoneNumberPrefix", "+84");
            migrationBuilder.UpdateData("Countries", "IsoCode", "V", "IsoCode", "VN");
            migrationBuilder.UpdateData("Countries", "IsoCode", "VU", "PhoneNumberPrefix", "+678");
            migrationBuilder.UpdateData("Countries", "IsoCode", "WF", "PhoneNumberPrefix", "+681");
            migrationBuilder.UpdateData("Countries", "IsoCode", "WS", "PhoneNumberPrefix", "+685");
            migrationBuilder.UpdateData("Countries", "IsoCode", "XK", "PhoneNumberPrefix", "+383");
            migrationBuilder.UpdateData("Countries", "IsoCode", "YE", "PhoneNumberPrefix", "+967");
            migrationBuilder.UpdateData("Countries", "IsoCode", "YT", "PhoneNumberPrefix", "+262");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ZA", "PhoneNumberPrefix", "+27");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ZM", "PhoneNumberPrefix", "+260");
            migrationBuilder.UpdateData("Countries", "IsoCode", "ZW", "PhoneNumberPrefix", "+263");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumberPrefix",
                table: "Countries");
        }
    }
}