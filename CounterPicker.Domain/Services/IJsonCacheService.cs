using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterPicker.Domain.Models;

namespace CounterPicker.Domain.Services
{
    public interface IJsonCacheService
    {
        public Task<Board?> GetDataAsync();
    }
}
