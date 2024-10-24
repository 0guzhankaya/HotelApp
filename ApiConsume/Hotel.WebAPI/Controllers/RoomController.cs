﻿using AutoMapper;
using Hotel.Business.Abstract;
using Hotel.Dto.Dtos.RoomDto;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetRoom(int id) 
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.TInsert(values);

            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var values = _mapper.Map<Room>(roomUpdateDto);
            _roomService.TUpdate(values);

            return Ok("Güncelleme Başarılı!");
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok("Silme İşlemi Başarılı!");
        }
    }
}
