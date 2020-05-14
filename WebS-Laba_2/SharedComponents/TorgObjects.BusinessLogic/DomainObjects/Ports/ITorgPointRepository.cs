using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TorgObjects.DomainObjects.Ports
{
    public interface IReadOnlyTorgPointRepository
    {
        TaskTorgPoint> GetTorgPoint(long id);

        Task<IEnumerableTorgPoint>> GetAlTorgPoints();

        Task<IEnumerableTorgPoint>> QuerTorgPoints(ICriteriaTorgPoint> criteria);

    }

    public interface TorgPointRepository
    {
        Task AdTorgPointTorgPointTorgpoint);

        Task RemovTorgPointTorgPointTorgpoint);

        Task UpdatTorgPointTorgPointTorgpoint);
    }
}
