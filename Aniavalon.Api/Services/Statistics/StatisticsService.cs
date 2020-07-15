using System;
using Aniavalon.Api.ApiModels;
using Aniavalon.Api.DAL;
using Aniavalon.Api.Models.Database;

namespace Aniavalon.Api.Services.Statistics
{
    public class StatisticsService : IStatisticsService
    {
        private readonly StatisticsContext _context;

        public StatisticsService(StatisticsContext context)
        {
            _context = context;
        }
        
        public void AddEntry(AddEntryRequest request)
        {
            if (request.PersonId == 0 
                || request.SideId == 0
                || request.PlayerCount == 0)
            {
                throw new InvalidOperationException("No argument can be zero or null");
            }

            _context.Database.EnsureCreated();

            _context.Database.BeginTransaction();
            
            _context.PersonXSides.Add(new PersonXSide
            {
                CreateDate = DateTime.Now,
                PersonId = request.PersonId,
                SideId = request.SideId,
                PlayerCount = request.PlayerCount
            });

            _context.SaveChanges();
            
            _context.Database.CurrentTransaction.Commit();
        }

        public void GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}