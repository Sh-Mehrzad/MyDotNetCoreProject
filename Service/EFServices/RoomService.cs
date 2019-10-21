using Data.Context;
using Data.Entities;
using DTO;
using Repo;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.EFServices
{
    public class RoomService : IRoomService
    {

        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Room> _room;

        public RoomService(IUnitOfWork uow, IGenericRepository<Room> room)
        {
            _uow = uow;
            _room = room;
        }

        public int Active(int unitid)
        {
            throw new NotImplementedException();
        }

        public int Add(RoomViewModel unit)
        {
            throw new NotImplementedException();
        }

        public int DeActive(int unitid)
        {
            throw new NotImplementedException();
        }

        public int Delete(int unitid)
        {
            throw new NotImplementedException();
        }

        public RoomViewModel find(int unitid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomViewModel>> GetAll()
        {
            var list = await _room.GetAllAsync();
            return list.Select(x => new RoomViewModel
            {
                ID = x.ID,
                Floor = x.Floor,
                RoomNo = x.RoomNo,
                Title = x.Title
            }).ToList();
        }

        public IEnumerable<RoomViewModel> getAllDeActive()
        {
            throw new NotImplementedException();
        }

        public void update(RoomViewModel unit)
        {
            throw new NotImplementedException();
        }
    }
}
