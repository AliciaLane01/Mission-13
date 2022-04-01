using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models
{
    public class EFBowlerDBRepository : IBowlerDBRepository
    {
        private BowlerDbContext _context { get; set; }

        public EFBowlerDBRepository(BowlerDbContext context)
        {
            _context = context;
        }
        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        public IQueryable<Team> Teams => _context.Teams;
    }
}
