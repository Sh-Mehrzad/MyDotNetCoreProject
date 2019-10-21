using Data.Context;
using Data.Entities;
using DTO;
using Repo;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;

namespace Service.EFServices
{
    public class UnitService : IUnitService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Unit> _unit;
        
        public UnitService(IUnitOfWork uow, IGenericRepository<Unit> unit)
        {
            _uow = uow;
            _unit = unit;            
        }


        public int Active(int unitid)
        {
            throw new NotImplementedException();
        }

        public int Add(UnitViewModel unit)
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

        public UnitViewModel find(int unitid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UnitViewModel>> GetAll()
        {
            //Map Unit(Domain) to UnitViewModel
            var list = await _unit.GetAllAsync();
            return list.Select(x => new UnitViewModel
            {
                ID = x.ID,
                Description = x.Description,
                Room = x.RoomID,
                Title = x.Title
            }).ToList();
            //var y = Mapper.Map<UnitViewModel>(x);
            //return (y).;            
        }

        public async Task<IEnumerable<UnitViewModel>> GetAll(int RoomID)
        {
            var list = await _unit.GetAllAsync();
            return list.Where(l => l.RoomID == RoomID).Select(x=>  new UnitViewModel
            {
                ID = x.ID,
                Description = x.Description,
                Room = x.RoomID,
                Title = x.Title
            }).ToList();
        }

        public void update(UnitViewModel unit)
        {
            throw new NotImplementedException();
        }        
    }
}
