using System.Collections.Generic;

namespace RiotGamesApi
{
    /// <summary>
    /// The regional endpoint, service region or host.
    /// </summary>
    public enum ApiHost
    {
        BR,
        EUNE,
        EUW,
        JP,
        KR,
        LAN,
        LAS,
        NA,
        OCE,
        TR,
        RU,
        PBE

    }

    /// <summary>
    /// The spectator endpoint or host.
    /// </summary>
    public enum SpectatorHost
    {
        NA,
        EUW,
        EUNE,
        JP,
        KR,
        OCE,
        BR,
        LAN,
        LAS,
        RU,
        TR,
        PBE

    }

    /// <summary>
    /// The API-Link.
    /// </summary>
    public enum ApiCall
    {
        /// <summary>
        /// {summonerId}
        /// </summary>
        ChampionMastery_BySummoner,

        /// <summary>
        /// {summonerId}, {championId}
        /// </summary>
        ChampionMastery_BySummoner_ByChampion,

        /// <summary>
        /// {summonerId}
        /// </summary>
        ChampionMastery_Scores_BySummoner,
        
        Champions_List,

        /// <summary>
        /// {championId}
        /// </summary>
        Champions_ById,

        /// <summary>
        /// {queue}
        /// </summary>
        League_Challenger_ByQueue,

        /// <summary>
        /// {leagueId}
        /// </summary>
        League_ByLeagueId,

        /// <summary>
        /// {queue}
        /// </summary>
        League_Master_ByQueue,

        /// <summary>
        /// {summonerId}
        /// </summary>
        League_BySummoner,

        StaticData_Champions,

        /// <summary>
        /// {championId}
        /// </summary>
        StaticData_Champion_ById,

        StaticData_Items,

        StaticData_Item_ById,

        StaticData_LanguageStrings,

        StaticData_Languages,

        StaticData_Maps,

        StaticData_Masteries,

        /// <summary>
        /// {masteryId}
        /// </summary>
        StaticData_Masteries_ById,

        StaticData_ProfileIcons,

        StaticData_Realms,

        StaticData_ReforgedRunePaths,

        /// <summary>
        /// {runePathId}
        /// </summary>
        StaticData_ReforgedRunePaths_ById,

        StaticData_ReforgedRunes,

        /// <summary>
        /// {rruneId}
        /// </summary>
        StaticData_ReforgedRunes_ById,

        StaticData_Runes,

        /// <summary>
        /// {runeId}
        /// </summary>
        StaticData_Runes_ById,

        StaticData_SummonerSpells,

        /// <summary>
        /// {summonerSpellId}
        /// </summary>
        StaticData_SummonerSpells_ById,

        StaticData_TarballLinks,

        StaticData_Versions,

        Status_ShardData,

        /// <summary>
        /// {tournamentCode}
        /// </summary>
        Match_ByTournamentCode,

        /// <summary>
        /// {matchId}
        /// </summary>
        Match_ById,

        /// <summary>
        /// {matchId}, {tournamentCode}
        /// </summary>
        Match_ById_ByTournamentCode,

        /// <summary>
        /// {accountId}
        /// </summary>
        Match_List_ById,

        /// <summary>
        /// {matchId}
        /// </summary>
        Match_Timeline_ById,

        /// <summary>
        /// {summonerId}
        /// </summary>
        Spectator_ActiveGames_ById,

        Spectator_FeaturedGames,

        /// <summary>
        /// {accountId}
        /// </summary>
        Summoner_ByAccountId,

        /// <summary>
        /// {summonerName}
        /// </summary>
        Summoner_ByName,

        /// <summary>
        /// {summonerId}
        /// </summary>
        Summoner_ById,

        /// <summary>
        /// {summonerId}
        /// </summary>
        ThirdPartyCode_BySummonerId,

        TournamentStub_Codes,

        /// <summary>
        /// {tournamentCode}
        /// </summary>
        TournamentStub_LobbyEvents_ByTournamentCode,

        TournamentStub_Providers,

        TournamentStub_Tournaments,

        Tournament_Codes,

        /// <summary>
        /// {tournamentCode}
        /// </summary>
        Tournament_Codes_ByTournamentCode,

        /// <summary>
        /// {tournamentCode}
        /// </summary>
        Tournament_LobbyEvents_ByTournamentCode,

        Tournament_Providers,

        Tournament_Tournaments

    }

    /// <summary>
    /// All possible Seasons.
    /// </summary>
    public enum Season
    {
        Preseason13,
        Season13,
        Preseason14,
        Season14,
        Preseason15,
        Season15,
        Preseason16,
        Season16,
        Preseason17,
        Season17,
        Preseason18,
        Season18

    }

    /// <summary>
    /// All active and deprecated queue types.
    /// </summary>
    public enum Queue
    {	
        /// <summary>
        /// Custom Games
        /// </summary>
        CustomGames = 0,
        
        /// <summary>
        /// Summoner's Rift, 5v5 Blind Pick games, Deprecated in patch 7.19 in favor of queueId 430
        /// </summary>
        Deprecated_SR_5v5_Normal_Blind = 2,

        /// <summary>
        /// Summoner's Rift, 5v5 Ranked Solo games, Deprecated in favor of queueId 420
        /// </summary>
        Deprecated_SR_5v5_Ranked_Solo = 2,

        /// <summary>
        /// Summoner's Rift, 5v5 Ranked Premade games, Game mode deprecated
        /// </summary>
        Deprecated_SR_5v5_Ranked_Premade = 2,

        /// <summary>
        /// Summoner's Rift, Co-op vs AI games, Deprecated in favor of queueId 32 and 33
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI = 7,

        /// <summary>
        /// Twisted Treeline, 3v3 Normal games, Deprecated in patch 7.19 in favor of queueId 460
        /// </summary>
        Deprecated_TT_3v3_Normal = 8,

        /// <summary>
        /// Twisted Treeline, 3v3 Ranked Flex games, Deprecated in patch 7.19 in favor of queueId 470
        /// </summary>
        Deprecated_TT_3v3_Ranked_Flex = 9,

        /// <summary>
        /// Summoner's Rift, 5v5 Draft Pick games, Deprecated in favor of queueId 400
        /// </summary>
        Deprecated_SR_5v5_Normal_Draft = 14,

        /// <summary>
        /// Crystal Scar, 5v5 Dominion Blind Pick games, Game mode deprecated
        /// </summary>
        Deprecated_CS_5v5_Dominion_Blind = 16,

        /// <summary>
        /// Crystal Scar, 5v5 Dominion Draft Pick games, Game mode deprecated
        /// </summary>
        Deprecated_CS_5v5_Dominion_Draft = 17,

        /// <summary>
        /// Crystal Scar, Dominion Co-op vs AI games, Game mode deprecated
        /// </summary>
        Deprecated_CS_5v5_Dominion_COOPvsAI = 25,

        /// <summary>
        /// Summoner's Rift, Co-op vs AI Intro Bot games, Deprecated in patch 7.19 in favor of queueId 830
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI_Intro = 31,

        /// <summary>
        /// Summoner's Rift, Co-op vs AI Beginner Bot games, Deprecated in patch 7.19 in favor of queueId 840
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI_Beginner = 32,

        /// <summary>
        /// Summoner's Rift, Co-op vs AI Intermediate Bot games, Deprecated in patch 7.19 in favor of queueId 850
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI_Intermediate = 33,

        /// <summary>
        /// Twisted Treeline, 3v3 Ranked Team games, Game mode deprecated
        /// </summary>
        Deprecated_TT_3v3_Ranked_Team = 41,

        /// <summary>
        /// Summoner's Rift, 5v5 Ranked Team games,	Game mode deprecated
        /// </summary>
        Deprecated_SR_5v5_Ranked_Team = 42,

        /// <summary>
        /// Twisted Treeline, Co-op vs AI games, Deprecated in patch 7.19 in favor of queueId 800
        /// </summary>
        Deprecated_TT_3v3_COOPvsAI = 52,

        /// <summary>
        /// Summoner's Rift, 5v5 Team Builder games, Game mode deprecated
        /// </summary>
        Deprecated_SR_5v5_Normal_TeamBuilder = 61,

        /// <summary>
        /// Howling Abyss, 5v5 ARAM games, Deprecated in patch 7.19 in favor of queueId 450
        /// </summary>
        Deprecated_HA_5v5_ARAM = 65,

        /// <summary>
        /// Summoner's Rift, One for All game, Deprecated in patch 8.6 in favor of queueId 1020
        /// </summary>
        Deprecated_SR_5v5_OneForAll = 70,

        /// <summary>
        /// Howling Abyss, 1v1 Snowdown Showdown games	
        /// </summary>
        DHA_1v1_SnowdownShowdown = 72,

        /// <summary>
        /// Howling Abyss, 2v2 Snowdown Showdown games	
        /// </summary>
        HA_2v2_SnowdownShowdown = 73,

        /// <summary>
        /// Summoner's Rift, 6v6 Hexakill games	
        /// </summary>
        HA_6v6_Hexakill = 75,

        /// <summary>
        /// Summoner's Rift, Ultra Rapid Fire games	
        /// </summary>
        SR_5v5_URF = 76,

        /// <summary>
        /// Howling Abyss, One For All: Mirror Mode games	
        /// </summary>
        HA_5v5_OneForeAll_MirrorMode = 78,

        /// <summary>
        /// Summoner's Rift, Co-op vs AI Ultra Rapid Fire games	
        /// </summary>
        SR_5v5_COOPvsAI_URF = 83,

        /// <summary>
        /// Summoner's Rift, Doom Bots Rank 1 games, Deprecated in patch 7.19 in favor of queueId 950
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI_Doombots_Rank1 = 91,

        /// <summary>
        /// Summoner's Rift, Doom Bots Rank 2 games, Deprecated in patch 7.19 in favor of queueId 950
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI_Doombots_Rank2 = 92,

        /// <summary>
        /// Summoner's Rift, Doom Bots Rank 5 games, Deprecated in patch 7.19 in favor of queueId 950
        /// </summary>
        Deprecated_SR_5v5_COOPvsAI_Doombots_Rank5 = 93,

        /// <summary>
        /// Crystal Scar, Ascension games, Deprecated in patch 7.19 in favor of queueId 910
        /// </summary>
        Deprecated_CS_5v5_Ascension = 96,

        /// <summary>
        /// Twisted Treeline, 6v6 Hexakill games	
        /// </summary>
        TT_6v6_Hexakill = 98,

        /// <summary>
        /// Butcher's Bridge, 5v5 ARAM games	
        /// </summary>
        BB_5v5_ARAM = 100,

        /// <summary>
        /// Howling Abyss, Legend of the Poro King games, Deprecated in patch 7.19 in favor of queueId 920
        /// </summary>
        Deprecated_HA_5v5_PoroKing = 300,

        /// <summary>
        /// Summoner's, Rift, Nemesis games	
        /// </summary>
        SR_5v5_NemesisDraft = 310,

        /// <summary>
        /// Summoner's, Rift, Black Market Brawlers games	
        /// </summary>
        SR_5v5_BlackMarketBrawlers = 313,

        /// <summary>
        /// Summoner's Rift, Nexus Siege games, Deprecated in patch 7.19 in favor of queueId 940
        /// </summary>
        Deprecated_SR_5v5_NexusSiege = 315,

        /// <summary>
        /// Crystal Scar, Definitely Not Dominion games	
        /// </summary>
        CS_5v5_DefinitelyNotDominion = 317,

        /// <summary>
        /// Summoner's Rift, ARURF games, Deprecated in patch 7.19 in favor of queueId 900
        /// </summary>
        Deprecated_SR_5v5_ARURF = 318,

        /// <summary>
        /// Summoner's Rift, All Random games	
        /// </summary>
        SR_5v5_AllRandom = 325,

        /// <summary>
        /// Summoner's Rift, 5v5 Draft Pick games	
        /// </summary>
        SR_5v5_Normal_Draft = 400,

        /// <summary>
        /// Summoner's Rift, 5v5 Ranked Dynamic games, Game mode deprecated in patch 6.22
        /// </summary>
        Deprecated_SR_5v5_Ranked_Dynamic = 410,

        /// <summary>
        /// Summoner's Rift, 5v5 Ranked Solo games	
        /// </summary>
        SR_5v5_Ranked_Solo = 420,

        /// <summary>
        /// Summoner's Rift, 5v5 Blind Pick games	
        /// </summary>
        SR_5v5_Normal_Blind = 430,

        /// <summary>
        /// Summoner's Rift, 5v5 Ranked Flex games	
        /// </summary>
        SR_5v5_Ranked_Flex = 440,

        /// <summary>
        /// Howling Abyss, 5v5 ARAM games	
        /// </summary>
        HA_5v5_ARAM = 450,

        /// <summary>
        /// Twisted Treeline, 3v3 Blind Pick games	
        /// </summary>
        TT_3v3_Normal_Blind = 460,

        /// <summary>
        /// Twisted Treeline, 3v3 Ranked Flex games	
        /// </summary>
        TT_3v3_Ranked_Flex = 470,

        /// <summary>
        /// Summoner's Rift, Blood Hunt Assassin games	
        /// </summary>
        SR_5v5_BloodHunt = 600,

        /// <summary>
        /// Cosmic Ruins, Dark Star: Singularity games	
        /// </summary>
        CR_3v3_DarkStar = 610,

        /// <summary>
        /// Summoner's Rift, Clash games	
        /// </summary>
        SR_5v5_Clash = 700,

        /// <summary>
        /// Twisted Treeline, Co-op vs. AI Intermediate Bot games	
        /// </summary>
        TT_3v3_COOPvsAI_Intermediate = 800,

        /// <summary>
        /// Twisted Treeline, Co-op vs. AI Intro Bot games	
        /// </summary>
        TT_3v3_COOPvsAI_Intro = 810,

        /// <summary>
        /// Twisted Treeline, Co-op vs. AI Beginner Bot games	
        /// </summary>
        TT_3v3_COOPvsAI_Beginner = 820,

        /// <summary>
        /// Summoner's Rift, Co-op vs. AI Intro Bot games	
        /// </summary>
        SR_5v5_COOPvsAI_Intro = 830,

        /// <summary>
        /// Summoner's Rift, Co-op vs. AI Beginner Bot games	
        /// </summary>
        SR_5v5_COOPvsAI_Beginner = 840,

        /// <summary>
        /// Summoner's Rift, Co-op vs. AI Intermediate Bot games	
        /// </summary>
        SR_5v5_COOPvsAI_Intermediate = 850,

        /// <summary>
        /// Summoner's Rift, ARURF games	
        /// </summary>
        SR_5v5_ARURF = 900,

        /// <summary>
        /// Crystal Scar, Ascension games	
        /// </summary>
        CS_5v5_Ascension = 910,

        /// <summary>
        /// Howling Abyss, Legend of the Poro King games	
        /// </summary>
        HA_5v5_PoroKing = 920,

        /// <summary>
        /// Summoner's Rift, Nexus Siege games	
        /// </summary>
        SR_5v5_NexusSiege = 940,

        /// <summary>
        /// Summoner's Rift, Doom Bots, Voting games	
        /// </summary>
        SR_5v5_DoomBotsVoting = 950,

        /// <summary>
        /// Summoner's Rift, Doom Bots, Standard games	
        /// </summary>
        SR_5v5_DoomBotsStandard = 960,

        /// <summary>
        /// Valoran City Park, Star Guardian Invasion: Normal games	
        /// </summary>
        VCP_COOPvsAI_StarGuardianInvasionNormal = 980,

        /// <summary>
        /// Valoran City Park, Star Guardian Invasion: Onslaught games	
        /// </summary>
        VCP_COOPvsAI_StarGuardianInvasionOnslaught = 990,

        /// <summary>
        /// Overcharge, PROJECT: Hunters games	
        /// </summary>
        OC_5v5_ProjectHunters = 1000,

        /// <summary>
        /// Summoner's Rift, Snow ARURF games	
        /// </summary>
        SR_5v5_ARURFSnow = 1010,

        /// <summary>
        /// Summoner's Rift, One for All games
        /// </summary>
        SR_5v5_OneForAll = 1020

    }

    /// <summary>
    /// Champions with their championId.
    /// </summary>
    public enum Champion
    {
        Aatrox = 266,
        Ahri = 103,
        Akali = 84,
        Alistar = 12,
        Amumu = 32,
        Anivia = 34,
        Annie = 1,
        Ashe = 22,
        AurelionSol = 136,
        Azir = 268,
        Bard = 432,
        Blitzcrank = 53,
        Brand = 63,
        Braum = 201,
        Caitlyn = 51,
        Camille = 164,
        Cassiopeia = 69,
        ChoGath = 31,
        Corki = 42,
        Darius = 122,
        Diana = 131,
        DrMundo = 36,
        Draven = 119,
        Ekko = 245,
        Elise = 60,
        Evelynn = 28,
        Ezreal = 81,
        Fiddlesticks = 9,
        Fiora = 114,
        Fizz = 105,
        Galio = 3,
        Gangplank = 41,
        Garen = 86,
        Gnar = 150,
        Gragas = 79,
        Graves = 104,
        Hecarim = 120,
        Heimerdinger = 74,
        Illaoi = 420,
        Irelia = 39,
        Ivern = 427,
        Janna = 40,
        JarvanIV = 59,
        Jax = 24,
        Jayce = 126,
        Jhin = 202,
        Jinx = 222,
        Kalista = 429,
        Karma = 43,
        Karthus = 30,
        Kassadin = 38,
        Katarina = 55,
        Kayle = 10,
        Kayn = 141,
        Kennen = 85,
        KhaZix = 121,
        Kindred = 203,
        Kled = 240,
        KogMaw = 96,
        LeBlanc = 7,
        LeeSin = 64,
        Leona = 89,
        Lissandra = 127,
        Lucian = 236,
        Lulu = 117,
        Lux = 99,
        Malphite = 54,
        Malzahar = 90,
        Maokai = 57,
        MasterYi = 11,
        MissFortune = 21,
        Mordekaiser = 82,
        Morgana = 25,
        Nami = 267,
        Nasus = 75,
        Nautilus = 111,
        Nidalee = 76,
        Nocturne = 56,
        Nunu = 20,
        Olaf = 2,
        Orianna = 61,
        Ornn = 516,
        Pantheon = 80,
        Poppy = 78,
        Quinn = 133,
        Rakan = 497,
        Rammus = 33,
        RekSai = 421,
        Renekton = 58,
        Rengar = 107,
        Riven = 92,
        Rumble = 68,
        Ryze = 13,
        Sejuani = 113,
        Shaco = 35,
        Shen = 98,
        Shyvana = 102,
        Singed = 27,
        Sion = 14,
        Sivir = 15,
        Skarner = 72,
        Sona = 37,
        Soraka = 16,
        Swain = 50,
        Syndra = 134,
        TahmKench = 223,
        Taliyah = 163,
        Talon = 91,
        Taric = 44,
        Teemo = 17,
        Thresh = 412,
        Tristana = 18,
        Trundle = 48,
        Tryndamere = 23,
        TwistedFate = 4,
        Twitch = 29,
        Udyr = 77,
        Urgot = 6,
        Varus = 110,
        Vayne = 67,
        Veigar = 45,
        VelKoz = 161,
        Vi = 254,
        Viktor = 112,
        Vladimir = 8,
        Volibear = 106,
        Warwick = 19,
        Wukong = 62,
        Xayah = 498,
        Xerath = 101,
        XinZhao = 5,
        Yasuo = 157,
        Yorick = 83,
        Zac = 154,
        Zed = 238,
        Ziggs = 115,
        Zilean = 26,
        Zoe = 142,
        Zyra = 143,
    }

    /// <summary>
    /// All Maps.
    /// </summary>
    public enum Map
    {
        /// <summary>
        /// Summoner's Rift, Original Summer Variant
        /// </summary>
        Original_SummonersRift_Summer = 1,

        /// <summary>
        /// Summoner's Rift, Original Autumn Variant
        /// </summary>
        Original_SummonersRift_Autumn = 2,

        /// <summary>
        /// The Proving Grounds, Tutorial Map
        /// </summary>
        ProvingGrounds = 3,

        /// <summary>
        /// Twisted Treeline, Original Version
        /// </summary>
        Original_TwistedTreeline = 4,

        /// <summary>
        /// The Crystal Scar, Dominion Map
        /// </summary>
        CrystalScar = 8,

        /// <summary>
        /// Twisted Treeline, Current Version
        /// </summary>
        TwistedTreeline = 10,

        /// <summary>
        /// Summoner's Rift, Current Version
        /// </summary>
        SummonersRift = 11,

        /// <summary>
        /// Howling Abyss, ARAM Map
        /// </summary>
        HowlingAbyss = 12,

        /// <summary>
        /// Butcher's Bridge, ARAM Map
        /// </summary>
        ButchersBridge = 14,

        /// <summary>
        /// Cosmic Ruins, Dark Star: Singularity Map
        /// </summary>
        CosmicRuins = 16,

        /// <summary>
        /// Valoran City Park, Star Guardian Invasion Map
        /// </summary>
        ValoranCityPark = 18,

        /// <summary>
        /// Substructure 43, PROJECT: Hunters Map
        /// </summary>
        Substructure43 = 19

    }

    /// <summary>
    /// All Gamemodes.
    /// </summary>
    public class GameMode
    {
        /// <summary>
        /// Classic Summoner's Rift and Twisted Treeline games
        /// </summary>
        public static string Classic { get { return "CLASSIC"; } }

        /// <summary>
        ///  Dominion/Crystal Scar games
        /// </summary>
        public static string Dominion { get { return "ODIN"; } }

        /// <summary>
        ///  ARAM games
        /// </summary>
        public static string Aram { get { return "ARAM   "; } }

        /// <summary>
        ///  Tutorial games
        /// </summary>
        public static string Tutorial { get { return "TUTORIAL"; } }

        /// <summary>
        ///  URF games
        /// </summary>
        public static string URF { get { return "URF"; } }

        /// <summary>
        ///  Doom Bot games
        /// </summary>
        public static string DoomBots { get { return "DOOMBOTSTEEMO"; } }

        /// <summary>
        ///  One for All games
        /// </summary>
        public static string OneForAll { get { return "ONEFORALL"; } }

        /// <summary>
        ///  Ascension games
        /// </summary>
        public static string Ascension { get { return "ASCENSION"; } }

        /// <summary>
        ///  Snowdown Showdown games
        /// </summary>
        public static string SnowdownShowdown { get { return "FIRSTBLOOD "; } }

        /// <summary>
        ///  Legend of the Poro King games
        /// </summary>
        public static string PoroKing { get { return "KINGPORO   "; } }

        /// <summary>
        ///  Nexus Siege games
        /// </summary>
        public static string NexusSiege { get { return "SIEGE"; } }

        /// <summary>
        ///  Blood Hunt Assassin games
        /// </summary>
        public static string BloodHunt { get { return "ASSASSINATE"; } }

        /// <summary>
        ///  All Random Summoner's Rift games
        /// </summary>
        public static string AllRandomSummonersRift { get { return "ARSR   "; } }

        /// <summary>
        ///  Dark Star: Singularity games
        /// </summary>
        public static string DarkStar { get { return "DARKSTAR"; } }

        /// <summary>
        ///  Star Guardian Invasion games
        /// </summary>
        public static string StarGuardian { get { return "STARGUARDIAN"; } }

        /// <summary>
        ///  PROJECT: Hunters games
        /// </summary>
        public static string ProjectHunters { get { return "PROJECT"; } }

    }

    /// <summary>
    /// All GameTypes.
    /// </summary>
    public class GameType
    {
        /// <summary>
        ///  Custom games
        /// </summary>
        public static string Custom { get { return "CUSTOM_GAME"; } }

        /// <summary>
        ///  Tutorial games
        /// </summary>
        public static string Tutorial { get { return "TUTORIAL_GAME  "; } }

        /// <summary>
        ///  All other games
        /// </summary>
        public static string Matched { get { return "MATCHED_GAME"; } }

    }

    /// <summary>
    /// Contains constant strings to all possible Api-Links.
    /// </summary>
    public class ApiLink
    {

        #region API_KEY

        public const string ApiPrefix = "api_key=";
        public const string ApiKey = "RGAPI-b36c0935-6203-4b83-853b-ec0c1420f14b";

        #endregion
        
        #region SERVICE_HOSTS

        public const string Endpoint_BR = @"https://br1.api.riotgames.com";
        public const string Endpoint_EUNE = @"https://eun1.api.riotgames.com";
        public const string Endpoint_EUW = @"https://euw1.api.riotgames.com";
        public const string Endpoint_JP = @"https://jp1.api.riotgames.com";
        public const string Endpoint_KR = @"https://kr.api.riotgames.com";
        public const string Endpoint_LAN = @"https://la1.api.riotgames.com";
        public const string Endpoint_LAS = @"https://la2.api.riotgames.com";
        public const string Endpoint_NA = @"https://na1.api.riotgames.com";
        public const string Endpoint_OCE = @"https://oc1.api.riotgames.com";
        public const string Endpoint_TR = @"https://tr1.api.riotgames.com";
        public const string Endpoint_RU = @"https://ru.api.riotgames.com";
        public const string Endpoint_PBE = @"https://pbe1.api.riotgames.com";

        public const string Endpoint_Spectator_BR = @"https://spectator.br.lol.riotgames.com";
        public const string Endpoint_Spectator_EUNE = @"https://spectator.eu.lol.riotgames.com";
        public const string Endpoint_Spectator_EUW = @"https://spectator.euw1.lol.riotgames.com";
        public const string Endpoint_Spectator_JP = @"https://spectator.jp1.lol.riotgames.com";
        public const string Endpoint_Spectator_KR = @"https://spectator.kr.lol.riotgames.com";
        public const string Endpoint_Spectator_LAN = @"https://spectator.la1.lol.riotgames.com";
        public const string Endpoint_Spectator_LAS = @"https://spectator.la2.lol.riotgames.com";
        public const string Endpoint_Spectator_NA = @"https://spectator.na.lol.riotgames.com";
        public const string Endpoint_Spectator_OCE = @"https://spectator.oc1.lol.riotgames.com";
        public const string Endpoint_Spectator_TR = @"https://spectator.tr.lol.riotgames.com";
        public const string Endpoint_Spectator_RU = @"https://spectator.ru.lol.riotgames.com";
        public const string Endpoint_Spectator_PBE = @"https://spectator.pbe1.lol.riotgames.com";

        #endregion
        
        #region CHAMPION_MASTERY

        /// <summary>
        /// <see cref="ChampionMastery_BySummoner"/> + {summonerId}
        /// </summary>
        public const string ChampionMastery_BySummoner = @"/lol/champion-mastery/v3/champion-masteries/by-summoner/";

        /// <summary>
        /// <see cref="ChampionMastery_BySummoner_ByChampion_1"/> + {summonerId} + <see cref="ChampionMastery_BySummoner_ByChampion_2"/> + {championId}
        /// </summary>
        public const string ChampionMastery_BySummoner_ByChampion_1 = @"/lol/champion-mastery/v3/champion-masteries/by-summoner/";
        public const string ChampionMastery_BySummoner_ByChampion_2 = @"/by-champion/";

        /// <summary>
        /// <see cref="ChampionMastery_Scores_BySummoner"/> + {summonerId}
        /// </summary>
        public const string ChampionMastery_Scores_BySummoner = @"/lol/champion-mastery/v3/scores/by-summoner/";

        #endregion
        
        #region CHAMPION

        public const string Champions_List = @"/lol/platform/v3/champions";

        /// <summary>
        /// <see cref="Champions_ById"/> + {championId}
        /// </summary>
        public const string Champions_ById = @"/lol/platform/v3/champions/";

        #endregion
        
        #region LEAGUE

        /// <summary>
        /// <see cref="League_Challenger_ByQueue"/> + {queue}
        /// </summary>
        public const string League_Challenger_ByQueue = @"/lol/league/v3/challengerleagues/by-queue/";

        /// <summary>
        /// <see cref="League_ByLeagueId"/> + {leagueId}
        /// </summary>
        public const string League_ByLeagueId = @"/lol/league/v3/leagues/";

        /// <summary>
        /// <see cref="League_Master_ByQueue"/> + {queue}
        /// </summary>
        public const string League_Master_ByQueue = @"/lol/league/v3/masterleagues/by-queue/";

        /// <summary>
        /// <see cref="League_BySummoner"/> + {summonerId}
        /// </summary>
        public const string League_BySummoner = @"/lol/league/v3/positions/by-summoner/";

        #endregion
        
        #region STATIC_DATA

        public const string StaticData_Champions = @"/lol/static-data/v3/champions";

        /// <summary>
        /// <see cref="StaticData_Champion_ById"/> + {championId}
        /// </summary>
        public const string StaticData_Champion_ById = @"/lol/static-data/v3/champions";

        public const string StaticData_Items = @"/lol/static-data/v3/items";

        /// <summary>
        /// <see cref="StaticData_Item_ById"/> + {itemId}
        /// </summary>
        public const string StaticData_Item_ById = @"/lol/static-data/v3/items/";

        public const string StaticData_LanguageStrings = @"/lol/static-data/v3/language-strings";

        public const string StaticData_Languages = @"/lol/static-data/v3/languages";

        public const string StaticData_Maps = @"/lol/static-data/v3/maps";

        public const string StaticData_Masteries = @"/lol/static-data/v3/masteries";

        /// <summary>
        /// <see cref="StaticData_Masteries_ById"/> + {masteryId}
        /// </summary>
        public const string StaticData_Masteries_ById = @"/lol/static-data/v3/masteries/";

        public const string StaticData_ProfileIcons = @"/lol/static-data/v3/profile-icons";

        public const string StaticData_Realms = @"/lol/static-data/v3/realms";

        public const string StaticData_ReforgedRunePaths = @"/lol/static-data/v3/reforged-rune-paths";

        /// <summary>
        /// <see cref="StaticData_ReforgedRunePaths_ById"/> + {runePathId}
        /// </summary>
        public const string StaticData_ReforgedRunePaths_ById = @"/lol/static-data/v3/reforged-rune-paths/";

        public const string StaticData_ReforgedRunes = @"/lol/static-data/v3/reforged-runes";

        /// <summary>
        /// <see cref="StaticData_ReforgedRunes_ById"/> + {rruneId}
        /// </summary>
        public const string StaticData_ReforgedRunes_ById = @"/lol/static-data/v3/reforged-runes/";

        public const string StaticData_Runes = @"/lol/static-data/v3/runes";

        /// <summary>
        /// <see cref="StaticData_Runes_ById"/> + {runeId}
        /// </summary>
        public const string StaticData_Runes_ById = @"/lol/static-data/v3/runes/";

        public const string StaticData_SummonerSpells = @"/lol/static-data/v3/summoner-spells";

        /// <summary>
        /// <see cref="StaticData_SummonerSpells_ById"/> + {summonerSpellId}
        /// </summary>
        public const string StaticData_SummonerSpells_ById = @"/lol/static-data/v3/summoner-spells/";

        public const string StaticData_TarballLinks = @"/lol/static-data/v3/tarball-links";

        public const string StaticData_Versions = @"/lol/static-data/v3/versions";

        #endregion
        
        #region STATUS

        public const string Status_ShardData = @"/lol/status/v3/shard-data";

        #endregion
        
        #region MATCH

        /// <summary>
        /// <see cref="Match_ByTournamentCode_1"/> + {tournamentCode} + <see cref="Match_ByTournamentCode_2"/> 
        /// </summary>
        public const string Match_ByTournamentCode_1 = @"/lol/match/v3/matches/by-tournament-code/{tournamentCode}/ids";
        public const string Match_ByTournamentCode_2 = @"/ids";

        /// <summary>
        /// <see cref="Match_ById"/> + {matchId}
        /// </summary>
        public const string Match_ById = @"/lol/match/v3/matches/";

        /// <summary>
        /// <see cref="Match_ById_ByTournamentCode_1"/> + {matchId} + <see cref="Match_ById_ByTournamentCode_2"/> + {tournamentCode}
        /// </summary>
        public const string Match_ById_ByTournamentCode_1 = @"/lol/match/v3/matches/";
        public const string Match_ById_ByTournamentCode_2 = @"/by-tournament-code/";

        /// <summary>
        /// <see cref="Match_List_ById"/> + {accountId}
        /// </summary>
        public const string Match_List_ById = @"/lol/match/v3/matchlists/by-account/";

        /// <summary>
        /// <see cref="Match_Timeline_ById"/> + {matchId}
        /// </summary>
        public const string Match_Timeline_ById = @"/lol/match/v3/timelines/by-match/";

        #endregion
        
        #region SPECTATOR

        /// <summary>
        /// <see cref="Spectator_ActiveGames_ById"/> + {summonerId}
        /// </summary>
        public const string Spectator_ActiveGames_ById = @"/lol/spectator/v3/active-games/by-summoner/";

        public const string Spectator_FeaturedGames = @"/lol/spectator/v3/featured-games";

        #endregion
        
        #region SUMMONER

        /// <summary>
        /// <see cref="Summoner_ByAccountId"/> + {accountId}
        /// </summary>
        public const string Summoner_ByAccountId = @"/lol/summoner/v3/summoners/by-account/";

        /// <summary>
        /// <see cref="Summoner_ByName"/> + {summonerName}
        /// </summary>
        public const string Summoner_ByName = @"/lol/summoner/v3/summoners/by-name/";

        /// <summary>
        /// <see cref="Summoner_ById"/> + {summonerId}
        /// </summary>
        public const string Summoner_ById = @"/lol/summoner/v3/summoners/";

        #endregion
        
        #region THIRD_PARTY_CODE

        /// <summary>
        /// <see cref="ThirdPartyCode_BySummonerId"/> + {summonerId}
        /// </summary>
        public const string ThirdPartyCode_BySummonerId = @"/lol/platform/v3/third-party-code/by-summoner/";

        #endregion
        
        #region TOURNAMENT_STUB

        public const string TournamentStub_Codes = @"/lol/tournament-stub/v3/codes";

        /// <summary>
        /// <see cref="TournamentStub_LobbyEvents_ByTournamentCode"/> + {tournamentCode}
        /// </summary>
        public const string TournamentStub_LobbyEvents_ByTournamentCode = @"/lol/tournament-stub/v3/lobby-events/by-code/";

        public const string TournamentStub_Providers = @"/lol/tournament-stub/v3/providers";

        public const string TournamentStub_Tournaments = @"/lol/tournament-stub/v3/tournaments";

        #endregion
        
        #region TOURNAMENT

        public const string Tournament_Codes = @"/lol/tournament/v3/codes";

        /// <summary>
        /// <see cref="Tournament_Codes_ByTournamentCode"/> + {tournamentCode}
        /// </summary>
        public const string Tournament_Codes_ByTournamentCode = @"/lol/tournament/v3/codes/";

        /// <summary>
        /// <see cref="Tournament_LobbyEvents_ByTournamentCode"/> + {tournamentCode}
        /// </summary>
        public const string Tournament_LobbyEvents_ByTournamentCode = @"/lol/tournament/v3/lobby-events/by-code/";

        public const string Tournament_Providers = @"/lol/tournament/v3/providers";

        public const string Tournament_Tournaments = @"/lol/tournament/v3/tournaments";

        #endregion

    }




    /// <summary>
    /// This object contains single Champion Mastery information for player and champion combination.
    /// </summary>
    public class ChampionMasteryDTO
    {
        /// <summary>
        /// Is chest granted for this champion or not in current season.
        /// </summary>
        public bool chestGranted;

        /// <summary>
        /// Champion level for specified player and champion combination.
        /// </summary>
        public int championLevel;

        /// <summary>
        /// Total number of champion points for this player and champion combination - they are used to determine championLevel.
        /// </summary>
        public int championPoints;

        /// <summary>
        /// Champion ID for this entry.
        /// </summary>
        public long championId;

        /// <summary>
        /// Player ID for this entry.
        /// </summary>
        public long playerId;

        /// <summary>
        /// Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.
        /// </summary>
        public long championPointsUntilNextLevel;

        /// <summary>
        /// The token earned for this champion to levelup.
        /// </summary>
        public int tokensEarned;

        /// <summary>
        /// Number of points earned since current level has been achieved.
        /// </summary>
        public long championPointsSinceLastLevel;

        /// <summary>
        /// Last time this champion was played by this player - in Unix milliseconds time format.
        /// </summary>
        public long lastPlayTime;
    }

    /// <summary>
    /// This object contains a collection of champion information.
    /// </summary>
    public class ChampionInfoListDto
    {
        /// <summary>
        /// The collection of champion information.
        /// </summary>
        public List<ChampionInfoDto> champions;
    }
    
    /// <summary>
     /// This object contains champion information.
     /// </summary>
    public class ChampionInfoDto
    {
        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        public bool rankedPlayEnabled;

        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        public bool botEnabled;

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        public bool botMmEnabled;

        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        public bool active;

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        public bool freeToPlay;

        /// <summary>
        /// Champion ID. For static information correlating to champion IDs, please refer to the LoL Static Data API.
        /// </summary>
        public long id;
    }

    /// <summary>
    /// 
    /// </summary>
    public class LeagueListDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public string leagueId;

        /// <summary>
        /// 
        /// </summary>
        public string tier;

        /// <summary>
        /// 
        /// </summary>
        public List<LeagueItemDTO> entries;

        /// <summary>
        /// 
        /// </summary>
        public string queue;

        /// <summary>
        /// 
        /// </summary>
        public string name;
    }

    /// <summary>
    /// 
    /// </summary>
    public class LeagueItemDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public string rank;

        /// <summary>
        /// 
        /// </summary>
        public bool hotStreak;

        /// <summary>
        /// 
        /// </summary>
        public MiniSeriesDTO miniSeries;

        /// <summary>
        /// 
        /// </summary>
        public int wins;

        /// <summary>
        /// 
        /// </summary>
        public bool veteran;

        /// <summary>
        /// 
        /// </summary>
        public int losses;

        /// <summary>
        /// 
        /// </summary>
        public bool freshBlood;

        /// <summary>
        /// 
        /// </summary>
        public string playerOrTeamName;

        /// <summary>
        /// 
        /// </summary>
        public bool inactive;

        /// <summary>
        /// 
        /// </summary>
        public string playerOrTeamId;

        /// <summary>
        /// 
        /// </summary>
        public int leaguePoints;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MiniSeriesDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public int wins;

        /// <summary>
        /// 
        /// </summary>
        public int losses;

        /// <summary>
        /// 
        /// </summary>
        public int target;

        /// <summary>
        /// 
        /// </summary>
        public string progress;
    }

    /// <summary>
    /// 
    /// </summary>
    public class LeaguePositionDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public string rank;

        /// <summary>
        /// 
        /// </summary>
        public string queueType;

        /// <summary>
        /// 
        /// </summary>
        public bool hotStreak;

        /// <summary>
        /// 
        /// </summary>
        public MiniSeriesDTO miniSeries;

        /// <summary>
        /// 
        /// </summary>
        public int wins;

        /// <summary>
        /// 
        /// </summary>
        public bool veteran;

        /// <summary>
        /// 
        /// </summary>
        public int losses;

        /// <summary>
        /// 
        /// </summary>
        public bool freshBlood;

        /// <summary>
        /// 
        /// </summary>
        public string leagueId;

        /// <summary>
        /// 
        /// </summary>
        public string playerOrTeamName;

        /// <summary>
        /// 
        /// </summary>
        public bool inactive;

        /// <summary>
        /// 
        /// </summary>
        public string playerOrTeamId;

        /// <summary>
        /// 
        /// </summary>
        public string leagueName;

        /// <summary>
        /// 
        /// </summary>
        public string tier;

        /// <summary>
        /// 
        /// </summary>
        public int leaguePoints;
    }

    /// <summary>
    /// This object contains champion list data.
    /// </summary>
    public class ChampionListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> keys;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, ChampionDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public string type;

        /// <summary>
        /// 
        /// </summary>
        public string format;
    }

    /// <summary>
    /// This object contains champion data.
    /// </summary>
    public class ChampionDto
    {
        /// <summary>
        /// 
        /// </summary>
        public InfoDto info;

        /// <summary>
        /// 
        /// </summary>
        public List<string> enemytips;

        /// <summary>
        /// 
        /// </summary>
        public StatsDto stats;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public string title;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public List<string> tags;

        /// <summary>
        /// 
        /// </summary>
        public string partype;

        /// <summary>
        /// 
        /// </summary>
        public List<SkinDto> skins;

        /// <summary>
        /// 
        /// </summary>
        public PassiveDto passive;

        /// <summary>
        /// 
        /// </summary>
        public List<RecommendedDto> recommended;

        /// <summary>
        /// 
        /// </summary>
        public List<string> allytips;

        /// <summary>
        /// 
        /// </summary>
        public string key;

        /// <summary>
        /// 
        /// </summary>
        public string lore;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public string blurb;

        /// <summary>
        /// 
        /// </summary>
        public List<ChampionSpellDto> spells;
    }

    /// <summary>
    /// This object contains champion information.
    /// </summary>
    public class InfoDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int difficulty;

        /// <summary>
        /// 
        /// </summary>
        public int attack;

        /// <summary>
        /// 
        /// </summary>
        public int defense;

        /// <summary>
        /// 
        /// </summary>
        public int magic;
    }

    /// <summary>
    /// This object contains champion stats data.
    /// </summary>
    public class StatsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public double armorperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double hpperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double attackdamage;

        /// <summary>
        /// 
        /// </summary>
        public double mpperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double attackspeedoffset;

        /// <summary>
        /// 
        /// </summary>
        public double armor;

        /// <summary>
        /// 
        /// </summary>
        public double hp;

        /// <summary>
        /// 
        /// </summary>
        public double hpregenperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double spellblock;

        /// <summary>
        /// 
        /// </summary>
        public double attackrange;

        /// <summary>
        /// 
        /// </summary>
        public double movespeed;

        /// <summary>
        /// 
        /// </summary>
        public double attackdamageperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double mpregenperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double mp;

        /// <summary>
        /// 
        /// </summary>
        public double spellblockperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double crit;

        /// <summary>
        /// 
        /// </summary>
        public double mpregen;

        /// <summary>
        /// 
        /// </summary>
        public double attackspeedperlevel;

        /// <summary>
        /// 
        /// </summary>
        public double hpregen;

        /// <summary>
        /// 
        /// </summary>
        public double critperlevel;
    }

    /// <summary>
    /// This object contains image data.
    /// </summary>
    public class ImageDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string full;

        /// <summary>
        /// 
        /// </summary>
        public string group;

        /// <summary>
        /// 
        /// </summary>
        public string sprite;

        /// <summary>
        /// 
        /// </summary>
        public int h;

        /// <summary>
        /// 
        /// </summary>
        public int w;

        /// <summary>
        /// 
        /// </summary>
        public int y;

        /// <summary>
        /// 
        /// </summary>
        public int x;
    }

    /// <summary>
    /// This object contains champion skin data.
    /// </summary>
    public class SkinDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int num;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public int id;
    }

    /// <summary>
    /// This object contains champion passive data.
    /// </summary>
    public class PassiveDto
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedDescription;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public string description;
    }

    /// <summary>
    /// This object contains champion recommended data.
    /// </summary>
    public class RecommendedDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string map;

        /// <summary>
        /// 
        /// </summary>
        public List<BlockDto> blocks;

        /// <summary>
        /// 
        /// </summary>
        public string champion;

        /// <summary>
        /// 
        /// </summary>
        public string title;

        /// <summary>
        /// 
        /// </summary>
        public bool priority;

        /// <summary>
        /// 
        /// </summary>
        public string mode;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains champion recommended block data.
    /// </summary>
    public class BlockDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<BlockItemDto> items;

        /// <summary>
        /// 
        /// </summary>
        public bool recMath;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains champion recommended block item data.
    /// </summary>
    public class BlockItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int count;

        /// <summary>
        /// 
        /// </summary>
        public int id;
    }

    /// <summary>
    /// This object contains champion spell data.
    /// </summary>
    public class ChampionSpellDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string cooldownBurn;

        /// <summary>
        /// 
        /// </summary>
        public string resource;

        /// <summary>
        /// 
        /// </summary>
        public LevelTipDto leveltip;

        /// <summary>
        /// 
        /// </summary>
        public List<SpellVarsDto> vars;

        /// <summary>
        /// 
        /// </summary>
        public string costType;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedDescription;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedTooltip;

        /// <summary>
        /// This field is a List of List of Double.
        /// </summary>
        public List<object> effect;

        /// <summary>
        /// 
        /// </summary>
        public string tooltip;

        /// <summary>
        /// 
        /// </summary>
        public int maxrank;

        /// <summary>
        /// 
        /// </summary>
        public string costBurn;

        /// <summary>
        /// 
        /// </summary>
        public string rangeBurn;

        /// <summary>
        /// This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        /// </summary>
        public object range;

        /// <summary>
        /// 
        /// </summary>
        public List<double> cooldown;

        /// <summary>
        /// 
        /// </summary>
        public List<int> cost;

        /// <summary>
        /// 
        /// </summary>
        public string key;

        /// <summary>
        /// 
        /// </summary>
        public string description;

        /// <summary>
        /// 
        /// </summary>
        public List<string> effectBurn;

        /// <summary>
        /// 
        /// </summary>
        public List<ImageDto> altimages;

        /// <summary>
        /// 
        /// </summary>
        public string name;
    }

    /// <summary>
    /// This object contains champion level tip data.
    /// </summary>
    public class LevelTipDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> effect;

        /// <summary>
        /// 
        /// </summary>
        public List<string> label;
    }

    /// <summary>
    /// This object contains spell vars data.
    /// </summary>
    public class SpellVarsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string ranksWith;

        /// <summary>
        /// 
        /// </summary>
        public string dyn;

        /// <summary>
        /// 
        /// </summary>
        public string link;

        /// <summary>
        /// 
        /// </summary>
        public List<double> coeff;

        /// <summary>
        /// 
        /// </summary>
        public string key;
    }
    
    /// <summary>
    /// This object contains item list data.
    /// </summary>
    public class ItemListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, ItemDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public List<ItemTreeDto> tree;

        /// <summary>
        /// 
        /// </summary>
        public List<GroupDto> groups;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains item tree data.
    /// </summary>
    public class ItemTreeDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string header;

        /// <summary>
        /// 
        /// </summary>
        public List<string> tags;
    }

    /// <summary>
    /// This object contains item data.
    /// </summary>
    public class ItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        public GoldDto gold;

        /// <summary>
        /// 
        /// </summary>
        public string plaintext;

        /// <summary>
        /// 
        /// </summary>
        public bool hideFromAll;

        /// <summary>
        /// 
        /// </summary>
        public bool inStore;

        /// <summary>
        /// 
        /// </summary>
        public List<string> into;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public InventoryDataStatsDto stats;

        /// <summary>
        /// 
        /// </summary>
        public string colloq;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, bool> maps;

        /// <summary>
        /// 
        /// </summary>
        public int specialRecipe;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public string description;

        /// <summary>
        /// 
        /// </summary>
        public List<string> tags;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> effect;

        /// <summary>
        /// 
        /// </summary>
        public string requiredChampion;

        /// <summary>
        /// 
        /// </summary>
        public List<string> from;

        /// <summary>
        /// 
        /// </summary>
        public string group;

        /// <summary>
        /// 
        /// </summary>
        public bool consumeOnFull;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public bool consumed;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedDescription;

        /// <summary>
        /// 
        /// </summary>
        public int depth;

        /// <summary>
        /// 
        /// </summary>
        public int stacks;
    }

    /// <summary>
    /// This object contains item gold data.
    /// </summary>
    public class GoldDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int sell;

        /// <summary>
        /// 
        /// </summary>
        public int total;

        /// <summary>
        /// 
        /// </summary>
        public int @base;

        /// <summary>
        /// 
        /// </summary>
        public bool purchasable;
    }

    /// <summary>
    /// This object contains stats for inventory (e.g., runes and items).
    /// </summary>
    public class InventoryDataStatsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public double PercentCritDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentSpellBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentHPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMovementSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatSpellBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatCritDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEnergyPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentLifeStealMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMovementSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentAttackSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEnergyRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentSpellVampMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentDodgeMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatAttackSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatArmorMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatHPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMagicDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMagicDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentPhysicalDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatPhysicalDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentHPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentArmorMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentCritChanceMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentEXPBonus;

        /// <summary>
        /// 
        /// </summary>
        public double FlatHPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatCritChanceMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEXPBonus;
    }

    /// <summary>
    /// This object contains item group data.
    /// </summary>
    public class GroupDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string MaxGroupOwnable;

        /// <summary>
        /// 
        /// </summary>
        public string key;
    }

    /// <summary>
    /// This object contains language strings data.
    /// </summary>
    public class LanguageStringsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains map data.
    /// </summary>
    public class MapDataDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, MapDetailsDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains map details data.
    /// </summary>
    public class MapDetailsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string mapName;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public long mapId;

        /// <summary>
        /// 
        /// </summary>
        public List<long> unpurchasableItemList;
    }

    /// <summary>
    /// This object contains mastery list data.
    /// </summary>
    public class MasteryListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, MasteryDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public MasteryTreeDto tree;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains mastery tree data.
    /// </summary>
    public class MasteryTreeDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeListDto> Resolve;

        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeListDto> Defense;

        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeListDto> Utility;

        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeListDto> Offense;

        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeListDto> Ferocity;

        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeListDto> Cunning;
    }

    /// <summary>
    /// This object contains mastery tree list data.
    /// </summary>
    public class MasteryTreeListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<MasteryTreeItemDto> masteryTreeItems;
    }

    /// <summary>
    /// This object contains mastery tree item data.
    /// </summary>
    public class MasteryTreeItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int masteryId;

        /// <summary>
        /// 
        /// </summary>
        public string prereq;
    }

    /// <summary>
    /// This object contains mastery data.
    /// </summary>
    public class MasteryDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string prereq;

        /// <summary>
        /// (Legal values:  Cunning,  Ferocity,  Resolve,  Defense,  Offense,  Utility)
        /// </summary>
        public string masteryTree;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public int ranks;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public List<string> sanitizedDescription;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public List<string> description;
    }

    /// <summary>
    /// This object contains profile icon data.
    /// </summary>
    public class ProfileIconDataDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, ProfileIconDetailsDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains profile icon details data.
    /// </summary>
    public class ProfileIconDetailsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public long id;
    }

    /// <summary>
    /// This object contains realm data.
    /// </summary>
    public class RealmDto
    {
        /// <summary>
        /// Legacy script mode for IE6 or older.
        /// </summary>
        public string lg;

        /// <summary>
        /// Latest changed version of Dragon Magic.
        /// </summary>
        public string dd;

        /// <summary>
        /// Default language for this realm.
        /// </summary>
        public string l;

        /// <summary>
        /// Latest changed version for each data type listed.
        /// </summary>
        public Dictionary<string, string> n;

        /// <summary>
        /// Special behavior number identifying the largest profile icon ID that can be used under 500. Any profile icon that is requested between this number and 500 should be mapped to 0.
        /// </summary>
        public int profileiconmax;

        /// <summary>
        /// Additional API data drawn from other sources that may be related to Data Dragon functionality.
        /// </summary>
        public string store;

        /// <summary>
        /// Current version of this file for this realm.
        /// </summary>
        public string v;

        /// <summary>
        /// The base CDN URL.
        /// </summary>
        public string cdn;

        /// <summary>
        /// Latest changed version of Dragon Magic's CSS file.
        /// </summary>
        public string css;
    }

    /// <summary>
    /// This object contains reforged rune path data.
    /// </summary>
    public class ReforgedRunePathDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ReforgedRuneSlotDto> slots;

        /// <summary>
        /// 
        /// </summary>
        public string icon;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public string key;

        /// <summary>
        /// 
        /// </summary>
        public string name;
    }

    /// <summary>
    /// This object contains reforged rune slot data.
    /// </summary>
    public class ReforgedRuneSlotDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ReforgedRuneDto> runes;
    }

    /// <summary>
    /// This object contains reforged rune data.
    /// </summary>
    public class ReforgedRuneDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string runePathName;

        /// <summary>
        /// 
        /// </summary>
        public int runePathId;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public string key;

        /// <summary>
        /// 
        /// </summary>
        public string shortDesc;

        /// <summary>
        /// 
        /// </summary>
        public string longDesc;

        /// <summary>
        /// 
        /// </summary>
        public string icon;
    }
    
    /// <summary>
    /// This object contains rune list data.
    /// </summary>
    public class RuneListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, RuneDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains rune data.
    /// </summary>
    public class RuneDto
    {
        /// <summary>
        /// 
        /// </summary>
        public RuneStatsDto stats;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public List<string> tags;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedDescription;

        /// <summary>
        /// 
        /// </summary>
        public MetaDataDto rune;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public string description;
    }

    /// <summary>
    /// This object contains stats for runes.
    /// </summary>
    public class RuneStatsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public double PercentTimeDeadModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentArmorPenetrationModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentCritDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentSpellBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentHPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMovementSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatSpellBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEnergyRegenModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEnergyPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMagicPenetrationModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentLifeStealMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentCooldownMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMagicPenetrationMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatArmorPenetrationModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMovementSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatTimeDeadModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatArmorModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentAttackSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatDodgeModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMagicDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatDodgeMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEnergyRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatHPModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentAttackSpeedModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentSpellVampMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentHPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentDodgeMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatAttackSpeedMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatArmorMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMagicDamageModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatHPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentPhysicalDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatCritChanceModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatSpellBlockModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentTimeDeadMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatBlockMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMagicDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMPRegenMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMovementSpeedModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentCooldownModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMPModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEnergyModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatPhysicalDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatHPRegenModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatCritDamageMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentArmorMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMagicPenetrationMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentCritChanceMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatPhysicalDamageModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentArmorPenetrationMod;

        /// <summary>
        /// 
        /// </summary>
        public double PercentEXPBonus;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMPRegenModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double PercentMagicPenetrationModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatTimeDeadMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatMovementSpeedModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatGoldPer10Mod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatArmorPenetrationMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatCritDamageModPerLevel;

        /// <summary>
        /// 
        /// </summary>
        public double FlatHPPoolMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatCritChanceMod;

        /// <summary>
        /// 
        /// </summary>
        public double FlatEXPBonus;
    }

    /// <summary>
    /// This object contains meta data.
    /// </summary>
    public class MetaDataDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string tier;

        /// <summary>
        /// 
        /// </summary>
        public string type;

        /// <summary>
        /// 
        /// </summary>
        public bool isRune;
    }

    /// <summary>
    /// This object contains summoner spell list data.
    /// </summary>
    public class SummonerSpellListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, SummonerSpellDto> data;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public string type;
    }

    /// <summary>
    /// This object contains summoner spell data.
    /// </summary>
    public class SummonerSpellDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<SpellVarsDto> vars;

        /// <summary>
        /// 
        /// </summary>
        public ImageDto image;

        /// <summary>
        /// 
        /// </summary>
        public string costBurn;

        /// <summary>
        /// 
        /// </summary>
        public List<double> cooldown;

        /// <summary>
        /// 
        /// </summary>
        public List<string> effectBurn;

        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public string cooldownBurn;

        /// <summary>
        /// 
        /// </summary>
        public string tooltip;

        /// <summary>
        /// 
        /// </summary>
        public int maxrank;

        /// <summary>
        /// 
        /// </summary>
        public string rangeBurn;

        /// <summary>
        /// 
        /// </summary>
        public string description;

        /// <summary>
        /// This field is a List of List of Double.
        /// </summary>
        public List<object> effect;

        /// <summary>
        /// 
        /// </summary>
        public string key;

        /// <summary>
        /// 
        /// </summary>
        public LevelTipDto leveltip;

        /// <summary>
        /// 
        /// </summary>
        public List<string> modes;

        /// <summary>
        /// 
        /// </summary>
        public string resource;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public string costType;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedDescription;

        /// <summary>
        /// 
        /// </summary>
        public string sanitizedTooltip;

        /// <summary>
        /// This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        /// </summary>
        public object range;

        /// <summary>
        /// 
        /// </summary>
        public List<int> cost;

        /// <summary>
        /// 
        /// </summary>
        public int summonerLevel;
    }

    /// <summary>
    /// 
    /// </summary>
    public class ShardStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public string region_tag;

        /// <summary>
        /// 
        /// </summary>
        public string hostname;

        /// <summary>
        /// 
        /// </summary>
        public List<Service> services;

        /// <summary>
        /// 
        /// </summary>
        public string slug;

        /// <summary>
        /// 
        /// </summary>
        public List<string> locales;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Service
    {
        /// <summary>
        /// 
        /// </summary>
        public string status;

        /// <summary>
        /// 
        /// </summary>
        public List<Incident> incidents;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public string slug;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// 
        /// </summary>
        public bool active;

        /// <summary>
        /// 
        /// </summary>
        public string created_at;

        /// <summary>
        /// 
        /// </summary>
        public long id;

        /// <summary>
        /// 
        /// </summary>
        public List<Message> updates;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 
        /// </summary>
        public string severity;

        /// <summary>
        /// 
        /// </summary>
        public string author;

        /// <summary>
        /// 
        /// </summary>
        public string created_at;

        /// <summary>
        /// 
        /// </summary>
        public List<Translation> translations;

        /// <summary>
        /// 
        /// </summary>
        public string updated_at;

        /// <summary>
        /// 
        /// </summary>
        public string content;

        /// <summary>
        /// 
        /// </summary>
        public string id;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// 
        /// </summary>
        public string locale;

        /// <summary>
        /// 
        /// </summary>
        public string content;

        /// <summary>
        /// 
        /// </summary>
        public string updated_at;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int seasonId;

        /// <summary>
        /// 
        /// </summary>
        public int queueId;

        /// <summary>
        /// 
        /// </summary>
        public long gameId;

        /// <summary>
        /// 
        /// </summary>
        public List<ParticipantIdentityDto> participantIdentities;

        /// <summary>
        /// 
        /// </summary>
        public string gameVersion;

        /// <summary>
        /// 
        /// </summary>
        public string platformId;

        /// <summary>
        /// 
        /// </summary>
        public string gameMode;

        /// <summary>
        /// 
        /// </summary>
        public int mapId;

        /// <summary>
        /// 
        /// </summary>
        public string gameType;

        /// <summary>
        /// 
        /// </summary>
        public List<TeamStatsDto> teams;

        /// <summary>
        /// 
        /// </summary>
        public List<ParticipantDto> participants;

        /// <summary>
        /// 
        /// </summary>
        public long gameDuration;

        /// <summary>
        /// 
        /// </summary>
        public long gameCreation;
    }

    /// <summary>
    /// 
    /// </summary>
    public class ParticipantIdentityDto
    {
        /// <summary>
        /// 
        /// </summary>
        public PlayerDto player;

        /// <summary>
        /// 
        /// </summary>
        public int participantId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class PlayerDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string currentPlatformId;

        /// <summary>
        /// 
        /// </summary>
        public string summonerName;

        /// <summary>
        /// 
        /// </summary>
        public string matchHistoryUri;

        /// <summary>
        /// 
        /// </summary>
        public string platformId;

        /// <summary>
        /// 
        /// </summary>
        public long currentAccountId;

        /// <summary>
        /// 
        /// </summary>
        public int profileIcon;

        /// <summary>
        /// 
        /// </summary>
        public long summonerId;

        /// <summary>
        /// 
        /// </summary>
        public long accountId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class TeamStatsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public bool firstDragon;

        /// <summary>
        /// 
        /// </summary>
        public bool firstInhibitor;

        /// <summary>
        /// 
        /// </summary>
        public List<TeamBansDto> bans;

        /// <summary>
        /// 
        /// </summary>
        public int baronKills;

        /// <summary>
        /// 
        /// </summary>
        public bool firstRiftHerald;

        /// <summary>
        /// 
        /// </summary>
        public bool firstBaron;

        /// <summary>
        /// 
        /// </summary>
        public int riftHeraldKills;

        /// <summary>
        /// 
        /// </summary>
        public bool firstBlood;

        /// <summary>
        /// 
        /// </summary>
        public int teamId;

        /// <summary>
        /// 
        /// </summary>
        public bool firstTower;

        /// <summary>
        /// 
        /// </summary>
        public int vilemawKills;

        /// <summary>
        /// 
        /// </summary>
        public int inhibitorKills;

        /// <summary>
        /// 
        /// </summary>
        public int towerKills;

        /// <summary>
        /// 
        /// </summary>
        public int dominionVictoryScore;

        /// <summary>
        /// 
        /// </summary>
        public string win;

        /// <summary>
        /// 
        /// </summary>
        public int dragonKills;
    }

    /// <summary>
    /// 
    /// </summary>
    public class TeamBansDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int pickTurn;

        /// <summary>
        /// 
        /// </summary>
        public int championId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class ParticipantDto
    {
        /// <summary>
        /// 
        /// </summary>
        public ParticipantStatsDto stats;

        /// <summary>
        /// 
        /// </summary>
        public int participantId;

        /// <summary>
        /// 
        /// </summary>
        public List<RuneDto> runes;

        /// <summary>
        /// 
        /// </summary>
        public ParticipantTimelineDto timeline;

        /// <summary>
        /// 
        /// </summary>
        public int teamId;

        /// <summary>
        /// 
        /// </summary>
        public int spell2Id;

        /// <summary>
        /// 
        /// </summary>
        public List<MasteryDto> masteries;

        /// <summary>
        /// 
        /// </summary>
        public string highestAchievedSeasonTier;

        /// <summary>
        /// 
        /// </summary>
        public int spell1Id;

        /// <summary>
        /// 
        /// </summary>
        public int championId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class ParticipantStatsDto
    {
        /// <summary>
        /// 
        /// </summary>
        public long physicalDamageDealt;

        /// <summary>
        /// 
        /// </summary>
        public int neutralMinionsKilledTeamJungle;

        /// <summary>
        /// 
        /// </summary>
        public long magicDamageDealt;

        /// <summary>
        /// 
        /// </summary>
        public int totalPlayerScore;

        /// <summary>
        /// 
        /// </summary>
        public int deaths;

        /// <summary>
        /// 
        /// </summary>
        public bool win;

        /// <summary>
        /// 
        /// </summary>
        public int neutralMinionsKilledEnemyJungle;

        /// <summary>
        /// 
        /// </summary>
        public int altarsCaptured;

        /// <summary>
        /// 
        /// </summary>
        public int largestCriticalStrike;

        /// <summary>
        /// 
        /// </summary>
        public long totalDamageDealt;

        /// <summary>
        /// 
        /// </summary>
        public long magicDamageDealtToChampions;

        /// <summary>
        /// 
        /// </summary>
        public int visionWardsBoughtInGame;

        /// <summary>
        /// 
        /// </summary>
        public long damageDealtToObjectives;

        /// <summary>
        /// 
        /// </summary>
        public int largestKillingSpree;

        /// <summary>
        /// 
        /// </summary>
        public int item1;

        /// <summary>
        /// 
        /// </summary>
        public int quadraKills;

        /// <summary>
        /// 
        /// </summary>
        public int teamObjective;

        /// <summary>
        /// 
        /// </summary>
        public int totalTimeCrowdControlDealt;

        /// <summary>
        /// 
        /// </summary>
        public int longestTimeSpentLiving;

        /// <summary>
        /// 
        /// </summary>
        public int wardsKilled;

        /// <summary>
        /// 
        /// </summary>
        public bool firstTowerAssist;

        /// <summary>
        /// 
        /// </summary>
        public bool firstTowerKill;

        /// <summary>
        /// 
        /// </summary>
        public int item2;

        /// <summary>
        /// 
        /// </summary>
        public int item3;

        /// <summary>
        /// 
        /// </summary>
        public int item0;

        /// <summary>
        /// 
        /// </summary>
        public bool firstBloodAssist;

        /// <summary>
        /// 
        /// </summary>
        public long visionScore;

        /// <summary>
        /// 
        /// </summary>
        public int wardsPlaced;

        /// <summary>
        /// 
        /// </summary>
        public int item4;

        /// <summary>
        /// 
        /// </summary>
        public int item5;

        /// <summary>
        /// 
        /// </summary>
        public int item6;

        /// <summary>
        /// 
        /// </summary>
        public int turretKills;

        /// <summary>
        /// 
        /// </summary>
        public int tripleKills;

        /// <summary>
        /// 
        /// </summary>
        public long damageSelfMitigated;

        /// <summary>
        /// 
        /// </summary>
        public int champLevel;

        /// <summary>
        /// 
        /// </summary>
        public int nodeNeutralizeAssist;

        /// <summary>
        /// 
        /// </summary>
        public bool firstInhibitorKill;

        /// <summary>
        /// 
        /// </summary>
        public int goldEarned;

        /// <summary>
        /// 
        /// </summary>
        public long magicalDamageTaken;

        /// <summary>
        /// 
        /// </summary>
        public int kills;

        /// <summary>
        /// 
        /// </summary>
        public int doubleKills;

        /// <summary>
        /// 
        /// </summary>
        public int nodeCaptureAssist;

        /// <summary>
        /// 
        /// </summary>
        public long trueDamageTaken;

        /// <summary>
        /// 
        /// </summary>
        public int nodeNeutralize;

        /// <summary>
        /// 
        /// </summary>
        public bool firstInhibitorAssist;

        /// <summary>
        /// 
        /// </summary>
        public int assists;

        /// <summary>
        /// 
        /// </summary>
        public int unrealKills;

        /// <summary>
        /// 
        /// </summary>
        public int neutralMinionsKilled;

        /// <summary>
        /// 
        /// </summary>
        public int objectivePlayerScore;

        /// <summary>
        /// 
        /// </summary>
        public int combatPlayerScore;

        /// <summary>
        /// 
        /// </summary>
        public long damageDealtToTurrets;

        /// <summary>
        /// 
        /// </summary>
        public int altarsNeutralized;

        /// <summary>
        /// 
        /// </summary>
        public long physicalDamageDealtToChampions;

        /// <summary>
        /// 
        /// </summary>
        public int goldSpent;

        /// <summary>
        /// 
        /// </summary>
        public long trueDamageDealt;

        /// <summary>
        /// 
        /// </summary>
        public long trueDamageDealtToChampions;

        /// <summary>
        /// 
        /// </summary>
        public int participantId;

        /// <summary>
        /// 
        /// </summary>
        public int pentaKills;

        /// <summary>
        /// 
        /// </summary>
        public long totalHeal;

        /// <summary>
        /// 
        /// </summary>
        public int totalMinionsKilled;

        /// <summary>
        /// 
        /// </summary>
        public bool firstBloodKill;

        /// <summary>
        /// 
        /// </summary>
        public int nodeCapture;

        /// <summary>
        /// 
        /// </summary>
        public int largestMultiKill;

        /// <summary>
        /// 
        /// </summary>
        public int sightWardsBoughtInGame;

        /// <summary>
        /// 
        /// </summary>
        public long totalDamageDealtToChampions;

        /// <summary>
        /// 
        /// </summary>
        public int totalUnitsHealed;

        /// <summary>
        /// 
        /// </summary>
        public int inhibitorKills;

        /// <summary>
        /// 
        /// </summary>
        public int totalScoreRank;

        /// <summary>
        /// 
        /// </summary>
        public long totalDamageTaken;

        /// <summary>
        /// 
        /// </summary>
        public int killingSprees;

        /// <summary>
        /// 
        /// </summary>
        public long timeCCingOthers;

        /// <summary>
        /// 
        /// </summary>
        public long physicalDamageTaken;
    }

    /// <summary>
    /// 
    /// </summary>
    public class ParticipantTimelineDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string lane;

        /// <summary>
        /// 
        /// </summary>
        public int participantId;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> csDiffPerMinDeltas;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> goldPerMinDeltas;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> xpDiffPerMinDeltas;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> creepsPerMinDeltas;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> xpPerMinDeltas;

        /// <summary>
        /// 
        /// </summary>
        public string role;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> damageTakenDiffPerMinDeltas;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, double> damageTakenPerMinDeltas;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchlistDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<MatchReferenceDto> matches;

        /// <summary>
        /// 
        /// </summary>
        public int totalGames;

        /// <summary>
        /// 
        /// </summary>
        public int startIndex;

        /// <summary>
        /// 
        /// </summary>
        public int endIndex;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchReferenceDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string lane;

        /// <summary>
        /// 
        /// </summary>
        public long gameId;

        /// <summary>
        /// 
        /// </summary>
        public int champion;

        /// <summary>
        /// 
        /// </summary>
        public string platformId;

        /// <summary>
        /// 
        /// </summary>
        public int season;

        /// <summary>
        /// 
        /// </summary>
        public int queue;

        /// <summary>
        /// 
        /// </summary>
        public string role;

        /// <summary>
        /// 
        /// </summary>
        public long timestamp;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchTimelineDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<MatchFrameDto> frames;

        /// <summary>
        /// 
        /// </summary>
        public long frameInterval;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchFrameDto
    {
        /// <summary>
        /// 
        /// </summary>
        public long timestamp;

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, MatchParticipantFrameDto> participantFrames;

        /// <summary>
        /// 
        /// </summary>
        public List<MatchEventDto> events;
    }
    
    /// <summary>
    /// 
    /// </summary>
    public class MatchParticipantFrameDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalGold;

        /// <summary>
        /// 
        /// </summary>
        public int teamScore;

        /// <summary>
        /// 
        /// </summary>
        public int participantId;

        /// <summary>
        /// 
        /// </summary>
        public int level;

        /// <summary>
        /// 
        /// </summary>
        public int currentGold;

        /// <summary>
        /// 
        /// </summary>
        public int minionsKilled;

        /// <summary>
        /// 
        /// </summary>
        public int dominionScore;

        /// <summary>
        /// 
        /// </summary>
        public MatchPositionDto position;

        /// <summary>
        /// 
        /// </summary>
        public int xp;

        /// <summary>
        /// 
        /// </summary>
        public int jungleMinionsKilled;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchPositionDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int y;

        /// <summary>
        /// 
        /// </summary>
        public int x;
    }

    /// <summary>
    /// 
    /// </summary>
    public class MatchEventDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string eventType;

        /// <summary>
        /// 
        /// </summary>
        public string towerType;

        /// <summary>
        /// 
        /// </summary>
        public int teamId;

        /// <summary>
        /// 
        /// </summary>
        public string ascendedType;

        /// <summary>
        /// 
        /// </summary>
        public int killerId;

        /// <summary>
        /// 
        /// </summary>
        public string levelUpType;

        /// <summary>
        /// 
        /// </summary>
        public string pointCaptured;

        /// <summary>
        /// 
        /// </summary>
        public List<int> assistingParticipantIds;

        /// <summary>
        /// 
        /// </summary>
        public string wardType;

        /// <summary>
        /// 
        /// </summary>
        public string monsterType;

        /// <summary>
        /// (Legal values:  CHAMPION_KILL,  WARD_PLACED,  WARD_KILL,  BUILDING_KILL,  ELITE_MONSTER_KILL,  ITEM_PURCHASED,  ITEM_SOLD,  ITEM_DESTROYED,  ITEM_UNDO,  SKILL_LEVEL_UP,  ASCENDED_EVENT,  CAPTURE_POINT,  PORO_KING_SUMMON)
        /// </summary>
        public string type;

        /// <summary>
        /// 
        /// </summary>
        public int skillSlot;

        /// <summary>
        /// 
        /// </summary>
        public int victimId;

        /// <summary>
        /// 
        /// </summary>
        public long timestamp;

        /// <summary>
        /// 
        /// </summary>
        public int afterId;

        /// <summary>
        /// 
        /// </summary>
        public string monsterSubType;

        /// <summary>
        /// 
        /// </summary>
        public string laneType;

        /// <summary>
        /// 
        /// </summary>
        public int itemId;

        /// <summary>
        /// 
        /// </summary>
        public int participantId;

        /// <summary>
        /// 
        /// </summary>
        public string buildingType;

        /// <summary>
        /// 
        /// </summary>
        public int creatorId;

        /// <summary>
        /// 
        /// </summary>
        public MatchPositionDto position;

        /// <summary>
        /// 
        /// </summary>
        public int beforeId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class CurrentGameInfo
    {
        /// <summary>
        /// The ID of the game
        /// </summary>
        public long gameId;

        /// <summary>
        /// The game start time represented in epoch milliseconds
        /// </summary>
        public long gameStartTime;

        /// <summary>
        /// The ID of the platform on which the game is being played
        /// </summary>
        public string platformId;

        /// <summary>
        /// The game mode
        /// </summary>
        public string gameMode;

        /// <summary>
        /// The ID of the map
        /// </summary>
        public long mapId;

        /// <summary>
        /// The game type
        /// </summary>
        public string gameType;

        /// <summary>
        /// Banned champion information
        /// </summary>
        public List<BannedChampion> bannedChampions;

        /// <summary>
        /// The observer information
        /// </summary>
        public Observer observers;

        /// <summary>
        /// The participant information
        /// </summary>
        public List<CurrentGameParticipant> participants;

        /// <summary>
        /// The amount of time in seconds that has passed since the game started
        /// </summary>
        public long gameLength;

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants page)
        /// </summary>
        public long gameQueueConfigId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class BannedChampion
    {
        /// <summary>
        /// The turn during which the champion was banned
        /// </summary>
        public int pickTurn;

        /// <summary>
        /// The ID of the banned champion
        /// </summary>
        public long championId;

        /// <summary>
        /// The ID of the team that banned the champion
        /// </summary>
        public long teamId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Key used to decrypt the spectator grid game data for playback
        /// </summary>
        public string encryptionKey;
    }

    /// <summary>
    /// 
    /// </summary>
    public class CurrentGameParticipant
    {
        /// <summary>
        /// The ID of the profile icon used by this participant
        /// </summary>
        public long profileIconId;

        /// <summary>
        /// The ID of the champion played by this participant
        /// </summary>
        public long championId;

        /// <summary>
        /// The summoner name of this participant
        /// </summary>
        public string summonerName;

        /// <summary>
        /// List of Game Customizations
        /// </summary>
        public List<GameCustomizationObject> gameCustomizationObjects;

        /// <summary>
        /// Flag indicating whether or not this participant is a bot
        /// </summary>
        public bool bot;

        /// <summary>
        /// Perks/Runes Reforged Information
        /// </summary>
        public Perks perks;

        /// <summary>
        /// The ID of the second summoner spell used by this participant
        /// </summary>
        public long spell2Id;

        /// <summary>
        /// The team ID of this participant, indicating the participant's team
        /// </summary>
        public long teamId;

        /// <summary>
        /// The ID of the first summoner spell used by this participant
        /// </summary>
        public long spell1Id;

        /// <summary>
        /// The summoner ID of this participant
        /// </summary>
        public long summonerId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class GameCustomizationObject
    {
        /// <summary>
        /// Category identifier for Game Customization
        /// </summary>
        public string category;

        /// <summary>
        /// Game Customization content
        /// </summary>
        public string content;
    }

    /// <summary>
    /// 
    /// </summary>
    public class Perks
    {
        /// <summary>
        /// Primary runes path
        /// </summary>
        public long perkStyle;

        /// <summary>
        /// IDs of the perks/runes assigned.
        /// </summary>
        public List<long> perkIds;

        /// <summary>
        /// Secondary runes path
        /// </summary>
        public long perkSubStyle;
    }

    /// <summary>
    /// 
    /// </summary>
    public class FeaturedGames
    {
        /// <summary>
        /// The suggested interval to wait before requesting FeaturedGames again
        /// </summary>
        public long clientRefreshInterval;

        /// <summary>
        /// The list of featured games
        /// </summary>
        public List<FeaturedGameInfo> gameList;
    }

    /// <summary>
    /// 
    /// </summary>
    public class FeaturedGameInfo
    {
        /// <summary>
        /// The ID of the game
        /// </summary>
        public long gameId;

        /// <summary>
        /// The game start time represented in epoch milliseconds
        /// </summary>
        public long gameStartTime;

        /// <summary>
        /// The ID of the platform on which the game is being played
        /// </summary>
        public string platformId;

        /// <summary>
        /// The game mode (Legal values:  CLASSIC,  ODIN,  ARAM,  TUTORIAL,  ONEFORALL,  ASCENSION,  FIRSTBLOOD,  KINGPORO)
        /// </summary>
        public string gameMode;

        /// <summary>
        /// The ID of the map
        /// </summary>
        public long mapId;

        /// <summary>
        /// The game type (Legal values:  CUSTOM_GAME,  MATCHED_GAME,  TUTORIAL_GAME)
        /// </summary>
        public string gameType;

        /// <summary>
        /// Banned champion information
        /// </summary>
        public List<BannedChampion> bannedChampions;

        /// <summary>
        /// The observer information
        /// </summary>
        public Observer observers;

        /// <summary>
        /// The participant information
        /// </summary>
        public List<Participant> participants;

        /// <summary>
        /// The amount of time in seconds that has passed since the game started
        /// </summary>
        public long gameLength;

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants page)
        /// </summary>
        public long gameQueueConfigId;
    }
    /// <summary>
    /// 
    /// </summary>

    public class Participant
    {
        /// <summary>
        /// The ID of the profile icon used by this participant
        /// </summary>
        public long profileIconId;

        /// <summary>
        /// The ID of the champion played by this participant
        /// </summary>
        public long championId;

        /// <summary>
        /// The summoner name of this participant
        /// </summary>
        public string summonerName;

        /// <summary>
        /// Flag indicating whether or not this participant is a bot
        /// </summary>
        public bool bot;

        /// <summary>
        /// The ID of the second summoner spell used by this participant
        /// </summary>
        public long spell2Id;

        /// <summary>
        /// The team ID of this participant, indicating the participant's team
        /// </summary>
        public long teamId;

        /// <summary>
        /// The ID of the first summoner spell used by this participant
        /// </summary>
        public long spell1Id;
    }

    /// <summary>
    /// represents a summoner
    /// </summary>
    public class SummonerDTO
    {
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        public int profileIconId;

        /// <summary>
        /// Summoner name.
        /// </summary>
        public string name;

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        public long summonerLevel;

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
        /// </summary>
        public long revisionDate;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long id;

        /// <summary>
        /// Account ID.
        /// </summary>
        public long accountId;
    }

    /// <summary>
    /// 
    /// </summary>
    public class LobbyEventDTOWrapper
    {
        /// <summary>
        /// 
        /// </summary>
        public List<LobbyEventDTO> eventList;
    }

    /// <summary>
    /// 
    /// </summary>
    public class LobbyEventDTO
    {
        /// <summary>
        /// The type of event that was triggered
        /// </summary>
        public string eventType;

        /// <summary>
        /// The summoner that triggered the event
        /// </summary>
        public string summonerId;

        /// <summary>
        /// Timestamp from the event
        /// </summary>
        public string timestamp;
    }

    /// <summary>
    /// 
    /// </summary>
    public class TournamentCodeDTO
    {
        /// <summary>
        /// The game map for the tournament code game
        /// </summary>
        public string map;

        /// <summary>
        /// The tournament code.
        /// </summary>
        public string code;

        /// <summary>
        /// The spectator mode for the tournament code game.
        /// </summary>
        public string spectators;

        /// <summary>
        /// The tournament code's region. (Legal values:  BR,  EUNE,  EUW,  JP,  LAN,  LAS,  NA,  OCE,  PBE,  RU,  TR)
        /// </summary>
        public string region;

        /// <summary>
        /// The provider's ID.
        /// </summary>
        public int providerId;

        /// <summary>
        /// The team size for the tournament code game.
        /// </summary>
        public int teamSize;

        /// <summary>
        /// 
        /// </summary>
        public long[] participants;

        /// <summary>
        /// The pick mode for tournament code game.
        /// </summary>
        public string pickType;

        /// <summary>
        /// The tournament's ID.
        /// </summary>
        public int tournamentId;

        /// <summary>
        /// The lobby name for the tournament code game.
        /// </summary>
        public string lobbyName;

        /// <summary>
        /// The password for the tournament code game.
        /// </summary>
        public string password;

        /// <summary>
        /// The tournament code's ID.
        /// </summary>
        public int id;

        /// <summary>
        /// The metadata for tournament code.
        /// </summary>
        public string metaData;
    }
}