using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using DOTNETCOREAPI_WITH_JWT_TOKEN.Model;
using DOTNETCOREAPI_WITH_JWT_TOKEN.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
namespace DOTNETCOREAPI_WITH_JWT_TOKEN.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController:ControllerBase
    {
        // dependency injection
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterservice)
        {
            _characterService = characterservice;
        }
       
        
        
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(){
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id){
            // get a single from the Mock data
            // using Linq
            var character =await _characterService.GetCharacterById(id);
            return Ok(character);

        }
        [HttpPost]
            public async Task<IActionResult> AddCharacter(Character newCharacter){
            var characters = await _characterService.AddCharacter(newCharacter);
            return Ok(characters);
        }

              
    }
}