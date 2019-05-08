﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Lol;

namespace FantasyData.Api.Client
{
    public partial class Lolv3StatsClient : BaseClient
    {
        public Lolv3StatsClient(string apiKey) : base(apiKey) { }
        public Lolv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Areas (Countries) Asynchronous
        /// </summary>
        public Task<List<Area>> GetAreasAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Area>>(() =>
                base.Get<List<Area>>("/v3/lol/stats/{format}/Areas", parameters)
            );
        }

        /// <summary>
        /// Get Areas (Countries)
        /// </summary>
        public List<Area> GetAreas()
        {
            return this.GetAreasAsync().Result;
        }

        /// <summary>
        /// Get Box Score Asynchronous
        /// </summary>
        /// <param name="gameid">Unique FantasyData Game ID. Example:<code>100002649</code>.</param>
        public Task<List<BoxScore>> GetBoxScoreAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/lol/stats/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score
        /// </summary>
        /// <param name="gameid">Unique FantasyData Game ID. Example:<code>100002649</code>.</param>
        public List<BoxScore> GetBoxScore(int gameid)
        {
            return this.GetBoxScoreAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-01-20</code></param>
        public Task<List<BoxScore>> GetBoxScoresAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/lol/stats/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-01-20</code></param>
        public List<BoxScore> GetBoxScores(string date)
        {
            return this.GetBoxScoresAsync(date).Result;
        }

        /// <summary>
        /// Get Champions Asynchronous
        /// </summary>
        public Task<List<Champion>> GetChampionsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Champion>>(() =>
                base.Get<List<Champion>>("/v3/lol/stats/{format}/Champions", parameters)
            );
        }

        /// <summary>
        /// Get Champions
        /// </summary>
        public List<Champion> GetChampions()
        {
            return this.GetChampionsAsync().Result;
        }

        /// <summary>
        /// Get Competition Fixtures (League Details) Asynchronous
        /// </summary>
        /// <param name="competitionid">A LoL competition/league unique CompetitionId. Possible values include: <code>100000019</code>, etc.</param>
        public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competitionid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competitionid", competitionid.ToString()));
            return Task.Run<CompetitionDetail>(() =>
                base.Get<CompetitionDetail>("/v3/lol/stats/{format}/CompetitionDetails/{competitionid}", parameters)
            );
        }

        /// <summary>
        /// Get Competition Fixtures (League Details)
        /// </summary>
        /// <param name="competitionid">A LoL competition/league unique CompetitionId. Possible values include: <code>100000019</code>, etc.</param>
        public CompetitionDetail GetCompetitionDetails(string competitionid)
        {
            return this.GetCompetitionDetailsAsync(competitionid).Result;
        }

        /// <summary>
        /// Get Competitions (Leagues) Asynchronous
        /// </summary>
        public Task<List<Competition>> GetCompetitionsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Competition>>(() =>
                base.Get<List<Competition>>("/v3/lol/stats/{format}/Competitions", parameters)
            );
        }

        /// <summary>
        /// Get Competitions (Leagues)
        /// </summary>
        public List<Competition> GetCompetitions()
        {
            return this.GetCompetitionsAsync().Result;
        }

        /// <summary>
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-01-20</code></param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/lol/stats/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-01-20</code></param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Items Asynchronous
        /// </summary>
        public Task<List<Item>> GetItemsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Item>>(() =>
                base.Get<List<Item>>("/v3/lol/stats/{format}/Items", parameters)
            );
        }

        /// <summary>
        /// Get Items
        /// </summary>
        public List<Item> GetItems()
        {
            return this.GetItemsAsync().Result;
        }

        /// <summary>
        /// Get Memberships (Active) Asynchronous
        /// </summary>
        public Task<List<Membership>> GetActiveMembershipsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/stats/{format}/ActiveMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Active)
        /// </summary>
        public List<Membership> GetActiveMemberships()
        {
            return this.GetActiveMembershipsAsync().Result;
        }

        /// <summary>
        /// Get Memberships (Historical) Asynchronous
        /// </summary>
        public Task<List<Membership>> GetHistoricalMembershipsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/stats/{format}/HistoricalMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Historical)
        /// </summary>
        public List<Membership> GetHistoricalMemberships()
        {
            return this.GetHistoricalMembershipsAsync().Result;
        }

        /// <summary>
        /// Get Memberships by Team (Active) Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
        public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/stats/{format}/MembershipsByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Active)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
        public List<Membership> GetMembershipsByTeam(int teamid)
        {
            return this.GetMembershipsByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Memberships by Team (Historical) Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
        public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/stats/{format}/HistoricalMembershipsByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Historical)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
        public List<Membership> GetHistoricalMembershipsByTeam(int teamid)
        {
            return this.GetHistoricalMembershipsByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100001500</code>.</param>
        public Task<Player> GetPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/lol/stats/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100001500</code>.</param>
        public Player GetPlayer(int playerid)
        {
            return this.GetPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Players Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/lol/stats/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Players
        /// </summary>
        public List<Player> GetPlayers()
        {
            return this.GetPlayersAsync().Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
        public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/lol/stats/{format}/PlayersByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
        public List<Player> GetPlayersByTeam(int teamid)
        {
            return this.GetPlayersByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Schedule Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000278</code>, etc</param>
        public Task<List<Game>> GetScheduleAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/lol/stats/{format}/Schedule/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000278</code>, etc</param>
        public List<Game> GetSchedule(int roundid)
        {
            return this.GetScheduleAsync(roundid).Result;
        }

        /// <summary>
        /// Get Season Teams Asynchronous
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000057</code>, etc</param>
        public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<SeasonTeam>>(() =>
                base.Get<List<SeasonTeam>>("/v3/lol/stats/{format}/SeasonTeams/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Season Teams
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000057</code>, etc</param>
        public List<SeasonTeam> GetSeasonTeams(int seasonid)
        {
            return this.GetSeasonTeamsAsync(seasonid).Result;
        }

        /// <summary>
        /// Get Spells Asynchronous
        /// </summary>
        public Task<List<Spell>> GetSpellsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Spell>>(() =>
                base.Get<List<Spell>>("/v3/lol/stats/{format}/Spells", parameters)
            );
        }

        /// <summary>
        /// Get Spells
        /// </summary>
        public List<Spell> GetSpells()
        {
            return this.GetSpellsAsync().Result;
        }

        /// <summary>
        /// Get Standings Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000278</code>, etc</param>
        public Task<List<Standing>> GetStandingsAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/v3/lol/stats/{format}/Standings/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000278</code>, etc</param>
        public List<Standing> GetStandings(int roundid)
        {
            return this.GetStandingsAsync(roundid).Result;
        }

        /// <summary>
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/lol/stats/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

        /// <summary>
        /// Get Venues Asynchronous
        /// </summary>
        public Task<List<Venue>> GetVenuesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Venue>>(() =>
                base.Get<List<Venue>>("/v3/lol/stats/{format}/Venues", parameters)
            );
        }

        /// <summary>
        /// Get Venues
        /// </summary>
        public List<Venue> GetVenues()
        {
            return this.GetVenuesAsync().Result;
        }

    }
}

