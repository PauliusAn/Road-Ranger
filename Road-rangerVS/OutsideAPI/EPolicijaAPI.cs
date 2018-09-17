﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Road_rangerVS.OutsideAPI
{
	class EPolicijaAPI
	{
		private static readonly HttpClient client = new HttpClient(); // HTTP servisas
		private static readonly string URL = "https://www.epolicija.lt/itpr_paieska/transportas_lt.php"; // ePolicijos URl
		private static EPolicijaAPI instance; // sio API serviso instance jei yra

		public static EPolicijaAPI getInstance() // jei jau yra toks objektas ji grazina, jei ne sukuria
		{
			if (instance != null)
			{
				return instance;
			}
			else
			{
				instance = new EPolicijaAPI();
				return instance;
			}
		}

		private EPolicijaAPI() { } // padaro, kad nebutu galima sukurt objekto, ne per methoda

		public async Task<Boolean> IsCarStolen(string licenseNumbers) { // siuncia uzklausa ePolicijai pagal duotus numerius ir grazina ar vogta
			var body = new Dictionary<string, string>
			{
				{ "knr", "" },
				{ "opt", "1" },
				{ "varnr", "" },
				{ "vnr", licenseNumbers }
			};

			var content = new FormUrlEncodedContent(body);

			var response = await client.PostAsync(URL, content);

			var responseString = await response.Content.ReadAsStringAsync();
			return parsePhpIfStolen(responseString);
		}

		private Boolean parsePhpIfStolen(string phpString) { // pagal grazinta php suranda ar vogta ar ne
			if (phpString.Contains("IEŠKOMA (-AS) NĖRA"))
			{
				return false;
			}
			else if (phpString.Contains("IEŠKOMA."))
			{
				return true;
			}
			else
			{
				throw new LicenceNumberParseException("Couldn't Parse If Stolen.");
			}

		}
	}

	class LicenceNumberParseException : Exception {
		public LicenceNumberParseException(string message) : base(message)
		{
		}
	}
}
