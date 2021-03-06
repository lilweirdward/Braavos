﻿using Braavos.Core.Infrastructure;
using Braavos.Core.Repositories.DataObjects;
using Braavos.Core.Repositories.DbContexts;
using Braavos.Core.Repositories.DbContexts.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Braavos.Core.Repositories
{
    public class CnDbRepository : ICnDbRepository
    {
        private readonly ICybernationsDbContext _cnDbContext;

        public CnDbRepository(ICybernationsDbContext cnDbContext) => _cnDbContext = cnDbContext;

        public async Task UpsertNations(IReadOnlyCollection<Nation> data, string dataFileName)
        {
            // Load today's data into the temp table for storing this data
            await _cnDbContext.InsertTempData(data.Select(rec => new TodaysNationData(rec, dataFileName)).ToList());

            // Execute the proc that merges the data into the main table
            await _cnDbContext.ExecuteSqlCommand("CALL update_nation_data();");
        }

        public async Task UpsertWar(IReadOnlyCollection<War> data, string dataFileName)
        {
            // Load today's data into the temp table for quicker uploading
            await _cnDbContext.InsertTempData(data.Select(rec => new TodaysWarData(rec, dataFileName)).ToList());

            // Execute the proc that merges the data into the main table
            await _cnDbContext.ExecuteSqlCommand("CALL update_war_data();");
        }

        public async Task UpsertAid(IReadOnlyCollection<Aid> data, string dataFileName)
        {
            // Load today's data into the temp table for quicker uploading
            await _cnDbContext.InsertTempData(data.Select(rec => new TodaysAidData(rec, dataFileName)).ToList());

            // Execute the proc that merges the data into the main table
            await _cnDbContext.ExecuteSqlCommand("CALL update_aid_data();");
        }

        public async Task UpsertAlliances(IReadOnlyCollection<Alliance> data, string dataFileName)
        {
            // Load today's data into the temp table for quicker uploading
            await _cnDbContext.InsertTempData(data.Select(rec => new TodaysAllianceData(rec, dataFileName)).ToList());

            // Execute the proc that merges the data into the main table
            await _cnDbContext.ExecuteSqlCommand("CALL update_alliance_data();");
        }
    }
}
