using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual.Infrastructure.Entity
{
    public class MissionEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
       

        //Тип и сложность
        public MissionType Type { get; set; }
        public MissionDifficulty Difficulty { get; set; } 


    }

    public enum MissionType
    {
        Daily = 0,
        Weekly = 1,
        Special = 2,
        Main = 3,
    }

    public enum MissionDifficulty
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Expert = 3,
    }

}
