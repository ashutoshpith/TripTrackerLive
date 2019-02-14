using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private  List<Trip> MyTrips = new List<Trip>{
            new Trip{
                    Id = 1,
                    Name = "ashutosh",
                    StartDate = new DateTime(2018, 5, 9),
                    EndDate = new DateTime(2018,5, 9)
                     },
            new Trip{
                    Id = 2,
                    Name = "Bhavana",
                    StartDate = new DateTime(2019,2,17),
                    EndDate = new DateTime(2019,5,7)
                     },
            new Trip{
                    Id = 3,
                    Name = "Unknown",
                    StartDate = new DateTime(2019,2,17),
                    EndDate = new DateTime(2019,5,7)
                     }

    };

       
        public void Add(Trip newTrip) { 
            MyTrips.Add(newTrip);
 
                              }
        public void Update(Trip tripToUpdate) {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
                                              }

        public void Remove(int Id){
            // MyTrips.Remove(MyTrips(t => t.Id == Id));
                                  }



  }
    }
