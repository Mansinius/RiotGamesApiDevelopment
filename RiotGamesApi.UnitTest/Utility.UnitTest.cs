namespace RiotGamesApi.UnitTest
{
    using System;
    using System.IO;

    using NUnit.Framework;


    public class UtilityUnitTest
    {
        /// <summary>
        /// Unit Test for RiotGamesApi.Config class.
        /// </summary>
        [Test]
        public void ConfigTest()
        {
            Config instance = new Config();

            Assert.That(instance.SummonerName, Is.Null);
            Assert.That(instance.ApiEndpoint, Is.EqualTo(0));
            Assert.That(instance.LoLClientPath, Is.Null);
        }

        /// <summary>
        /// Unit Test for RiotGamesApi.ConfigUtility class.
        /// Requires VS to be started with administrator privileges, because FileAccess is needed. 
        /// </summary>
        [Test]
        public void ConfigUtilityTest()
        {
            File.Delete(@".\config.json");

            Assert.That(ConfigUtility.ConfigExists(), Is.False);

            Config emptyInstance = ConfigUtility.ReadConfig();
            Assert.That(emptyInstance, Is.Null);

            ConfigUtility.WriteConfig("Mansinius", (int)ApiHost.EUW,
                @"D:\Riot Games\League of Legends\LeagueClient.exe");

            Config instance = ConfigUtility.ReadConfig();
            Assert.That(instance.SummonerName, Is.EqualTo("Mansinius"));
            Assert.That(instance.ApiEndpoint, Is.EqualTo((int)ApiHost.EUW));
            Assert.That(instance.LoLClientPath, 
               Is.EqualTo(@"D:\Riot Games\League of Legends\LeagueClient.exe"));

        }


        /// <summary>
        /// Unit Test for RiotGamesApi.StaticDataUtility class.
        /// Requires VS to be started with administrator privileges, because FileAccess is needed. 
        /// </summary>
        [Test]
        public void StaticDataUtilityTest()
        {
            StaticDataUtility.BuildStaticFileChampion();

            ChampionDto champRengar = StaticDataUtility.ReadChampionFromStaticFile("Rengar");

            Assert.That(champRengar.id, Is.EqualTo(107));
            Assert.That(champRengar.title, Is.EqualTo("the Pridestalker"));


            StaticDataUtility.BuildStaticFileItem();

            ItemDto itemDBlade = StaticDataUtility.ReadItemFromStaticFile("Doran's Blade");

            Assert.That(itemDBlade.id, Is.EqualTo(1055));
            Assert.That(itemDBlade.plaintext, Is.EqualTo("Good starting item for attackers"));


            StaticDataUtility.BuildStaticFileSummonerSpell();

            SummonerSpellDto summonerFlash = 
                StaticDataUtility.ReadSummonerSpellFromStaticFile("Flash");

            Assert.That(summonerFlash.id, Is.EqualTo(4));
            Assert.That(summonerFlash.description, Is.EqualTo("Teleports your champion a short" +
                " distance toward your cursor's location."));


            StaticDataUtility.BuildStaticFileRune();

            ReforgedRuneDto runeFleetFootwork = StaticDataUtility.ReadRuneFromStaticFile(8021);

            Assert.That(runeFleetFootwork.key, Is.EqualTo("FleetFootwork"));
            Assert.That(runeFleetFootwork.shortDesc, Is.EqualTo("Attacking and moving builds " +
                "Energy stacks. At 100 stacks, your next attack heals you and grants increased " +
                "<lol-uikit-tooltipped-keyword key='LinkTooltip_Description_MS'>MS" +
                "</lol-uikit-tooltipped-keyword>."));


            StaticDataUtility.BuildStaticFileRunePath();

            ReforgedRunePathDto pathSorcery = StaticDataUtility.ReadRunePathFromStaticFile(8200);

            Assert.That(pathSorcery.key, Is.EqualTo("Sorcery"));
            Assert.That(pathSorcery.name, Is.EqualTo("Sorcery"));


            Assert.That(StaticDataUtility.StaticFileExists(
                StaticDataUtility.StaticData.Champions), Is.True);

            Assert.That(StaticDataUtility.StaticFileExists(
                StaticDataUtility.StaticData.Languages), Is.False);
        }


        /// <summary>
        /// Unit Test for RiotGamesApi.WebUtility class.
        /// </summary>
        [Test]
        public void WebUtilityTest()
        {
            Assert.Throws<ArgumentNullException>(() => WebUtility.GetFromSite(null));
        }


        /// <summary>
        /// Unit Test for RiotGamesApi.BuildUtility class.
        /// </summary>
        [Test]
        public void BuildUtilityTest()
        {
            
        }
    }
}
