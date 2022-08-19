using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Enums;

namespace dotnet_rpg.DTOs.Character
{
    public class GetCharacterDTO : CharacterDTO
    {
        public int Id { get; set; }
    }
    public class CharacterDTO
    {
        public string Name { get; set; } = "Adam";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}