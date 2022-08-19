using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.DTOs.Character;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character() { Id = 1, Name = "Konrad", Class = Enums.RpgClass.Cleric }
        };

        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(CharacterDTO newCharacter)
        {
            characters.Add(_mapper.Map<Character>(newCharacter));
            return new ServiceResponse<List<GetCharacterDTO>>(_mapper.Map<List<GetCharacterDTO>>(characters));
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
        {
            return new ServiceResponse<GetCharacterDTO>(
                _mapper.Map<GetCharacterDTO>(
                    characters.FirstOrDefault(x => x.
                    Id == id))
                );
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetCharacters()
        {
            return new ServiceResponse<List<GetCharacterDTO>>(_mapper.Map<List<GetCharacterDTO>>(characters));
        }
    }
}