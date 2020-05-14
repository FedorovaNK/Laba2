using TorgObjects.DomainObjects;
using TorgObjects.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TorgObjects.ApplicationServices.GetMedPointListUseCase
{
    public class IsPechatProductCriteria : ICriteria<TorgPoint>
    {
        public string IsPechatProduct { get; }

        public IsPechatProductCriteria(string isPechatProduct)
            => IsPechatProduct = isPechatProduct;

        public Expression<Func<MedPoint, bool>> Filter
            => (mp => mp.IsPechatProduct == IsPechatProduct);
    }
}
