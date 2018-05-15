using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace RiotGamesApi
{
    public class Config
    {
        public string SummonerName { get; set; }
        public int ApiEndpoint { get; set; }
        //Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        public string LoLClientPath { get; set; }
    }

    public class ConfigUtility
    {

        /*
         * Utility to create and read a config.json-file using class Config.
         */
        #region CONFIG_UTILITY

        private const string pathConfig = @".\config.json";

        public static bool ConfigExists()
        {
            return File.Exists(pathConfig);
        }

        public static Config ReadConfig()
        {
            string json = "";
            if (ConfigExists())
            {
                json = File.ReadAllText(pathConfig);
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(json);
        }

        public static void WriteConfig(string summonerName, int apiEndpoint, string lolClientPath)
        {
            File.Delete(pathConfig);

            Config config = new Config()
            {
                ApiEndpoint = apiEndpoint,
                SummonerName = summonerName,
                LoLClientPath = lolClientPath
            };

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented);
            File.AppendAllText(pathConfig, json);
        }

        #endregion

    }

    public class StaticDataUtility
    {
        public enum StaticData
        {
            Champions,
            Items,
            Languages,
            Maps,
            Masteries,
            ProfileIcons,
            Realms,
            ReforgedRunePaths,
            ReforgedRunes,
            Runes,
            SummonerSpells,
            TarballLinks,
            Versions
        }

        public static bool StaticFileExists(StaticData data)
        {
            string path = @".\StaticData\" + data.ToString() + ".json";

            return File.Exists(path);
        }

        public static void BuildStaticFile(StaticData data, string json)
        {
            string path = @".\StaticData\" + data.ToString() + ".json";
            File.Delete(path);

            File.AppendAllText(path, json);
        }

        public static T ReadFromStaticFile<T>(StaticData data)
        {
            string path = @".\StaticData\" + data.ToString() + ".json";

            string json = "";
            if (StaticFileExists(data))
            {
                json = File.ReadAllText(path);
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        public static ChampionDto ReadChampionFromStaticFile(string name)
        {
            if (StaticFileExists(StaticData.Champions))
            {
                ChampionListDto champs = ReadFromStaticFile<ChampionListDto>(StaticData.Champions);

                foreach (ChampionDto champ in champs.data.Values)
                {
                    if (champ.name == name)
                    {
                        return champ;
                    }
                }
            }
            return new ChampionDto();
        }

        public static SummonerSpellDto ReadSummonerSpellFromStaticFile(string name)
        {
            if (StaticFileExists(StaticData.SummonerSpells))
            {
                SummonerSpellListDto spells = ReadFromStaticFile<SummonerSpellListDto>(StaticData.SummonerSpells);

                foreach (SummonerSpellDto spell in spells.data.Values)
                {
                    if (spell.name == name)
                    {
                        return spell;
                    }
                }
            }
            return new SummonerSpellDto();
        }

        public static ItemDto ReadItemFromStaticFile(string name)
        {
            if (StaticFileExists(StaticData.Items))
            {
                ItemListDto items = ReadFromStaticFile<ItemListDto>(StaticData.Items);

                foreach (ItemDto item in items.data.Values)
                {
                    if (item.name == name)
                    {
                        return item;
                    }
                }
            }
            return new ItemDto();
        }

        public static ReforgedRunePathDto ReadRunePathFromStaticFile(int id)
        {
            if (StaticFileExists(StaticData.ReforgedRunePaths))
            {
                List<ReforgedRunePathDto> runePaths = ReadFromStaticFile<List<ReforgedRunePathDto>>(StaticData.ReforgedRunePaths);

                foreach (ReforgedRunePathDto runePath in runePaths)
                {
                    if (runePath.id == id)
                    {
                        return runePath;
                    }
                }
            }
            return new ReforgedRunePathDto();
        }

        public static ReforgedRuneDto ReadRuneFromStaticFile(int id)
        {
            if (StaticFileExists(StaticData.ReforgedRunes))
            {
                List<ReforgedRuneDto> runes = ReadFromStaticFile<List<ReforgedRuneDto>>(StaticData.ReforgedRunes);

                foreach (ReforgedRuneDto rune in runes)
                {
                    if (rune.id == id)
                    {
                        return rune;
                    }
                }
            }
            return new ReforgedRuneDto();
        }
    }

    public class WebUtility
    {
        public static string GetFromSite(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string data = String.Empty;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }

            var a = response.StatusCode;

            return data;
        }

        public static bool RequestIsOkay(HttpStatusCode statusCode)
        {
            if (((int)statusCode) >= 200 && ((int)statusCode) <= 300)
            {
                return true;
            }
            return false;
        }
    }

    public class BuildUtility
    {
        /*
         * Utility to create the full API-Link from enums
         */
        #region RESOLVE_API_LINKS

        public static string ResolveApi(ApiHost host, ApiCall api, string[] headerParameters, params string[] apiParameters)
        {
            return ResolveApiEndpoint(host) + ResolveApiLink(api, apiParameters) + BuildParameters(headerParameters);
        }

        private static string ResolveApiEndpoint(ApiHost endpoint)
        {
            switch (endpoint)
            {
                case ApiHost.BR:
                    return ApiLink.Endpoint_BR;
                case ApiHost.EUNE:
                    return ApiLink.Endpoint_EUNE;
                case ApiHost.EUW:
                    return ApiLink.Endpoint_EUW;
                case ApiHost.JP:
                    return ApiLink.Endpoint_JP;
                case ApiHost.KR:
                    return ApiLink.Endpoint_KR;
                case ApiHost.LAN:
                    return ApiLink.Endpoint_LAN;
                case ApiHost.LAS:
                    return ApiLink.Endpoint_LAS;
                case ApiHost.NA:
                    return ApiLink.Endpoint_NA;
                case ApiHost.OCE:
                    return ApiLink.Endpoint_OCE;
                case ApiHost.PBE:
                    return ApiLink.Endpoint_PBE;
                case ApiHost.RU:
                    return ApiLink.Endpoint_RU;
                case ApiHost.TR:
                    return ApiLink.Endpoint_TR;
            }

            return "";
        }

        private static string ResolveSpectatorApiEndpoint(SpectatorHost endpoint)
        {
            switch (endpoint)
            {
                case SpectatorHost.BR:
                    return ApiLink.Endpoint_Spectator_BR;
                case SpectatorHost.EUNE:
                    return ApiLink.Endpoint_Spectator_EUNE;
                case SpectatorHost.EUW:
                    return ApiLink.Endpoint_Spectator_EUW;
                case SpectatorHost.JP:
                    return ApiLink.Endpoint_Spectator_JP;
                case SpectatorHost.KR:
                    return ApiLink.Endpoint_Spectator_KR;
                case SpectatorHost.LAN:
                    return ApiLink.Endpoint_Spectator_LAN;
                case SpectatorHost.LAS:
                    return ApiLink.Endpoint_Spectator_LAS;
                case SpectatorHost.NA:
                    return ApiLink.Endpoint_Spectator_NA;
                case SpectatorHost.OCE:
                    return ApiLink.Endpoint_Spectator_OCE;
                case SpectatorHost.PBE:
                    return ApiLink.Endpoint_Spectator_PBE;
                case SpectatorHost.RU:
                    return ApiLink.Endpoint_Spectator_RU;
                case SpectatorHost.TR:
                    return ApiLink.Endpoint_Spectator_TR;
            }

            return "";
        }

        private static string ResolveApiLink(ApiCall api, params string[] parameters)
        {
            try
            {
                switch (api)
                {
                    case ApiCall.ChampionMastery_BySummoner:
                        return ApiLink.ChampionMastery_BySummoner + parameters[0];
                    case ApiCall.ChampionMastery_BySummoner_ByChampion:
                        return ApiLink.ChampionMastery_BySummoner_ByChampion_1 + parameters[0] + ApiLink.ChampionMastery_BySummoner_ByChampion_2 + parameters[1];
                    case ApiCall.ChampionMastery_Scores_BySummoner:
                        return ApiLink.ChampionMastery_Scores_BySummoner + parameters[0];
                    case ApiCall.Champions_ById:
                        return ApiLink.Champions_ById + parameters[0];
                    case ApiCall.Champions_List:
                        return ApiLink.Champions_List;
                    case ApiCall.League_ByLeagueId:
                        return ApiLink.League_ByLeagueId + parameters[0];
                    case ApiCall.League_BySummoner:
                        return ApiLink.League_BySummoner + parameters[0];
                    case ApiCall.League_Challenger_ByQueue:
                        return ApiLink.League_Challenger_ByQueue + parameters[0];
                    case ApiCall.League_Master_ByQueue:
                        return ApiLink.League_Master_ByQueue + parameters[0];
                    case ApiCall.Match_ById:
                        return ApiLink.Match_ById + parameters[0];
                    case ApiCall.Match_ById_ByTournamentCode:
                        return ApiLink.Match_ById_ByTournamentCode_1 + parameters[0] + ApiLink.Match_ById_ByTournamentCode_2 + parameters[1];
                    case ApiCall.Match_ByTournamentCode:
                        return ApiLink.Match_ByTournamentCode_1 + parameters[0] + ApiLink.Match_ByTournamentCode_1 + parameters[1];
                    case ApiCall.Match_List_ById:
                        return ApiLink.Match_List_ById + parameters[0];
                    case ApiCall.Match_Timeline_ById:
                        return ApiLink.Match_Timeline_ById + parameters[0];
                    case ApiCall.Spectator_ActiveGames_ById:
                        return ApiLink.Spectator_ActiveGames_ById + parameters[0];
                    case ApiCall.Spectator_FeaturedGames:
                        return ApiLink.Spectator_FeaturedGames;
                    case ApiCall.StaticData_Champions:
                        return ApiLink.StaticData_Champions;
                    case ApiCall.StaticData_Champion_ById:
                        return ApiLink.StaticData_Champion_ById + parameters[0];
                    case ApiCall.StaticData_Items:
                        return ApiLink.StaticData_Items;
                    case ApiCall.StaticData_Item_ById:
                        return ApiLink.StaticData_Item_ById + parameters[0];
                    case ApiCall.StaticData_Languages:
                        return ApiLink.StaticData_Languages;
                    case ApiCall.StaticData_LanguageStrings:
                        return ApiLink.StaticData_LanguageStrings;
                    case ApiCall.StaticData_Maps:
                        return ApiLink.StaticData_Maps;
                    case ApiCall.StaticData_Masteries:
                        return ApiLink.StaticData_Masteries;
                    case ApiCall.StaticData_Masteries_ById:
                        return ApiLink.StaticData_Masteries_ById + parameters[0];
                    case ApiCall.StaticData_ProfileIcons:
                        return ApiLink.StaticData_ProfileIcons;
                    case ApiCall.StaticData_Realms:
                        return ApiLink.StaticData_Realms;
                    case ApiCall.StaticData_ReforgedRunePaths:
                        return ApiLink.StaticData_ReforgedRunePaths;
                    case ApiCall.StaticData_ReforgedRunePaths_ById:
                        return ApiLink.StaticData_ReforgedRunePaths_ById + parameters[0];
                    case ApiCall.StaticData_ReforgedRunes:
                        return ApiLink.StaticData_ReforgedRunes;
                    case ApiCall.StaticData_ReforgedRunes_ById:
                        return ApiLink.StaticData_ReforgedRunes_ById + parameters[0];
                    case ApiCall.StaticData_Runes:
                        return ApiLink.StaticData_Runes;
                    case ApiCall.StaticData_Runes_ById:
                        return ApiLink.StaticData_Runes_ById + parameters[0];
                    case ApiCall.StaticData_SummonerSpells:
                        return ApiLink.StaticData_SummonerSpells;
                    case ApiCall.StaticData_SummonerSpells_ById:
                        return ApiLink.StaticData_SummonerSpells_ById + parameters[0];
                    case ApiCall.StaticData_TarballLinks:
                        return ApiLink.StaticData_TarballLinks;
                    case ApiCall.StaticData_Versions:
                        return ApiLink.StaticData_Versions;
                    case ApiCall.Status_ShardData:
                        return ApiLink.Status_ShardData;
                    case ApiCall.Summoner_ByAccountId:
                        return ApiLink.Summoner_ByAccountId + parameters[0];
                    case ApiCall.Summoner_ById:
                        return ApiLink.Summoner_ById + parameters[0];
                    case ApiCall.Summoner_ByName:
                        return ApiLink.Summoner_ByName + parameters[0];
                    case ApiCall.ThirdPartyCode_BySummonerId:
                        return ApiLink.ThirdPartyCode_BySummonerId + parameters[0];
                    case ApiCall.TournamentStub_Codes:
                        return ApiLink.TournamentStub_Codes;
                    case ApiCall.TournamentStub_LobbyEvents_ByTournamentCode:
                        return ApiLink.TournamentStub_LobbyEvents_ByTournamentCode + parameters[0];
                    case ApiCall.TournamentStub_Providers:
                        return ApiLink.TournamentStub_Providers;
                    case ApiCall.TournamentStub_Tournaments:
                        return ApiLink.TournamentStub_Tournaments;
                    case ApiCall.Tournament_Codes:
                        return ApiLink.Tournament_Codes;
                    case ApiCall.Tournament_Codes_ByTournamentCode:
                        return ApiLink.Tournament_Codes_ByTournamentCode + parameters[0];
                    case ApiCall.Tournament_LobbyEvents_ByTournamentCode:
                        return ApiLink.Tournament_LobbyEvents_ByTournamentCode + parameters[0];
                    case ApiCall.Tournament_Providers:
                        return ApiLink.Tournament_Providers;
                    case ApiCall.Tournament_Tournaments:
                        return ApiLink.Tournament_Tournaments;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return "Wrong number of parameters";
            }

            return "";
        }

        private static string BuildParameters(params string[] parameters)
        {
            string parameterString = "?" + ApiLink.ApiPrefix + ApiLink.ApiKey;

            foreach (string parameter in parameters)
            {
                parameterString += "&" + parameter;
            }

            return parameterString;
        }

        #endregion

        /*
         *  Utility to create a Process which will start the League Client to spectate the given game.
         */
        #region SPECATOR_PROCESS

        public static System.Diagnostics.Process GetSpectatorProcess(string leagueClientExe, SpectatorHost host, string encryptionKey, long matchId, string platformId)
        {
            string arguments = "/C ";

            arguments += "cd " + GetSolutionClient(leagueClientExe);
            arguments += "&" + GetSpectatorCommand(host, encryptionKey, matchId, platformId);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo()
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = arguments
            };
            process.StartInfo = startInfo;

            return process;
        }

        private static string GetSolutionClient(string leagueClientExe)
        {
            string path = leagueClientExe.Substring(0, leagueClientExe.LastIndexOf('\\'));
            path += @"\RADS\solutions\lol_game_client_sln\releases\";

            string[] directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

            string highestVersion = directories[0];
            foreach (string directory in directories)
            {
                if (directory.CompareTo(highestVersion) > 0)
                {
                    highestVersion = directory;
                }
            }

            return highestVersion + "\\deploy\\";
        }

        private static string GetSpectatorCommand(SpectatorHost host, string encryptionKey, long matchId, string platformId)
        {
            const string fileName = "\"League of Legends.exe\"";

            const string maestroParameter1 = "8394";
            const string maestroParameter2 = "\"LeagueClient.exe\"";
            const string maestroParameter3 = "\"/path\"";

            string SpectatorDomain = ResolveSpectatorApiEndpoint(host);
            string port = "80";
            if (host == SpectatorHost.EUNE || host == SpectatorHost.PBE)
            {
                port = "8088";
            }

            return fileName + " " +
                   maestroParameter1 + " " +
                   maestroParameter2 + " " +
                   maestroParameter3 + " " +
                   "spectator " +
                   SpectatorDomain + ":" +
                   port + " " +
                   encryptionKey + " " +
                   matchId.ToString() + " " +
                   platformId + "\"";
        }

        #endregion
    }
}
