using System.Collections.Generic;
using SE491_Project.Data.Entities;

namespace SE491_Project.Components.Pages.RoomComponents
{
    public class RoomDesignServices
    {
        public List<Room> GetRooms() {
            return [

                new Room{
               RoomId=Guid.NewGuid(),
               Number="1",
               Type="فردية",
               PricePerNight=20,
               Status=RoomStatus.Available
                },
                new Room{
               RoomId=Guid.NewGuid(),
               Number="2",
               Type="زوجية",
               PricePerNight=40,
               Status=RoomStatus.Available }
                ];
        
        
        }
    }
}
