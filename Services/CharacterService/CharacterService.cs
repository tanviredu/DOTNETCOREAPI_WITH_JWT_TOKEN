using System.Collections.Generic;
using System.Threading.Tasks;
using DOTNETCOREAPI_WITH_JWT_TOKEN.Model;
using System.Linq;

namespace DOTNETCOREAPI_WITH_JWT_TOKEN.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         // MOCK Data storage
         // a generic List
        private  List<Character> Characters = new List<Character>{
            new Character{Id=0},
            new Character {Id=1,Name="Sam"},
            new Character{Id=2,Name="John"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);
            return Characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return Characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return Characters.FirstOrDefault(c=>c.Id ==id);
        }
    }
}