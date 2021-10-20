using DemoInteraktiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Retrieves a covid summary
        /// </summary>
        /// <returns></returns>
        Task<SummaryDto> GetSummaryAsync();
    }
}
