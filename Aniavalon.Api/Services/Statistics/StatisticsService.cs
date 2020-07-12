using System;
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
        
        public void AddEntry(int personId, int sideId, int playerCount)
        {
            if (personId == 0)
            {
                throw new InvalidOperationException("PersonId cannot be zero or null");
            }

            _context.Database.EnsureCreated();

            _context.Database.BeginTransaction();
            
            _context.PersonXSides.Add(new PersonXSide
            {
                CreateDate = DateTime.Now,
                PersonId = personId,
                SideId = sideId,
                PlayerCount = playerCount
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