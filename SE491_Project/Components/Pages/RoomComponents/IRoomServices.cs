using SE491_Project.Data.Entities;

namespace SE491_Project.Components.Pages.RoomComponents
{
    public interface IRoomServices
    {

        Task<Room?> GetRoomById(Guid id);
        Task<List<Room>> GetRoomsAsync();
        Task<List<Room>> CreateRoomsAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(Guid id);


        //Room Save(Room room);
        //Room Update(Room room);
        //void Delete(Room room);
        //Room GetRoomByID(Guid id);
    }
}

