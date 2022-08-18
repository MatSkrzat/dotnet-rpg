using dotnet_rpg.Enums;

namespace dotnet_rpg.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Adam";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}