using Microsoft.AspNetCore.Mvc;
using StudieApplication.Context;
using StudieApplication.Models;
using StudieApplication.Repository;

namespace StudieApplication.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Room> rooms = _roomRepository.GetAllRooms();
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Room room)
        {
            if (room != null)
            {
                _roomRepository.Create(room);
            }
            return View();
        }


        public ActionResult Delete(int id)
        {
            _roomRepository.Delete(id);
            return View();
        }
    }
}
