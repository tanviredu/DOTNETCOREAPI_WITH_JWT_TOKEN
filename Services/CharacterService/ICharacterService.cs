using System;
using DOTNETCOREAPI_WITH_JWT_TOKEN.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace DOTNETCOREAPI_WITH_JWT_TOKEN.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>>GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
        


    }
}