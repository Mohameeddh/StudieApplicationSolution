using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudieApplication.Context;
using StudieApplication.Models;

namespace StudieApplication.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MyContext _myDbConnection;

        public RoomRepository(MyContext myContext)
        {
            _myDbConnection = myContext;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = (from rObj in _myDbConnection.Rooms
                                select rObj).ToList().ToList();
            return rooms;
        }

        public void Create(Room room)
        {
            _myDbConnection.Rooms.Add(room);
            _myDbConnection.SaveChanges();
        }

        public void Delete(int id)
        {
            Room room = (from rObj in _myDbConnection.Rooms
                         where rObj.RoomId == id
                         select rObj).FirstOrDefault();

            _myDbConnection.Rooms.Remove(room);
            _myDbConnection.SaveChanges();
        }
    }
}
