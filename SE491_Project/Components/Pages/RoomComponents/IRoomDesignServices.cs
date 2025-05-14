using SE491_Project.Data.Entities;

namespace SE491_Project.Components.Pages.RoomComponents
{
    public interface IRoomDesignServices
    {
        void Delete(Room room);
        Room GetRoomByID(Guid id);
        List<Room> GetRooms();
        Room Save(Room room);
        Room Update(Room room);
    }
}