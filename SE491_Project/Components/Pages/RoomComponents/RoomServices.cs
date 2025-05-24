using Microsoft.EntityFrameworkCore;
using SE491_Project.Data;
using SE491_Project.Data.Entities;

namespace SE491_Project.Components.Pages.RoomComponents
{

   
public class RoomServices : IRoomServices
    {


        private readonly ApplicationDbContext _dbContext;

        public RoomServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // جلب الغرف بشكل غير متزامنblazor)
        public async Task<List<Room>> GetRoomsAsync()
        {
            return await _dbContext.Rooms.ToListAsync();
        }
        public async Task<List<Room>> CreateRoomsAsync(Room room)
        {
            if (room != null)
            {
                room.RoomId = Guid.NewGuid(); // Ensure a new ID is generated for the room
                await _dbContext.AddAsync(room);
                await _dbContext.SaveChangesAsync();
                return [room]; // Fixed the syntax error here
            }

            // Return an empty list if the input note is null
            return [];
        }

        public async Task DeleteRoomAsync(Guid id)
        {
            {
                var room = await _dbContext.Rooms.FindAsync(id);
                if (room != null)
                {
                    _dbContext.Rooms.Remove(room);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task<Room?> GetRoomById(Guid id)
        {
            return await _dbContext.Rooms.FindAsync(id);
        }



       

        public async Task UpdateRoomAsync(Room room)
        {
            _dbContext.Rooms.Update(room);
            await _dbContext.SaveChangesAsync();
        }




      
    }
}


   
