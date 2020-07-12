using System;

namespace Aniavalon.Api.Models.Database
{
    public class PersonXSide
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int PersonId { get; set; }
        public int SideId { get; set; }
        public int PlayerCount { get; set; }
    }
}