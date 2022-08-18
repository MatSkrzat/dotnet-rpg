using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<CharacterModel> characters = new List<CharacterModel>(){
            new CharacterModel(),
            new CharacterModel() { Id = 1, Name = "Konrad", Class = Enums.RpgClass.Cleric }
        };

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterModel>> Get(int id)
        {
            var character = characters.FirstOrDefault(x => x.Id == id);
            if (character == null) return BadRequest("Character not found");
            return Ok(character);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<CharacterModel>>> Get()
        {
            if (characters == null || characters.Count == 0) return BadRequest("Characters empty");
            return Ok(characters);
        }

        [HttpPost]
        public async Task<ActionResult<List<CharacterModel>>> AddCharacter(CharacterModel newCharacter)
        {
            if (newCharacter != null)
                characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}