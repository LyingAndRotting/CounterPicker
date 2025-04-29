using CounterPicker.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterPicker.Domain.Services
{
    public interface IHeroService
    {
        Task<Hero?> Get(int id);
        Task<Board?> GetAll();
    }
}
