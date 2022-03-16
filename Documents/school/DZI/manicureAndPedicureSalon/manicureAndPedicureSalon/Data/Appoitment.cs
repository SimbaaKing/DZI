﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manicureAndPedicureSalon.Data
{
    public class Appoitment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        
        public DateTime DateVisit { get; set; }
        public DateTime TimeVisit { get; set; }
        public DateTime Date { get; set; }
      

    }
}
