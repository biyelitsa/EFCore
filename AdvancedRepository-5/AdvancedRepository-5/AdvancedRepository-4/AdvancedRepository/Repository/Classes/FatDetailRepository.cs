using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class FatDetailRepository : BaseRepository<FatDetail>, IFatDetailRepository
    {
        public FatDetailRepository(CompanyContext db) : base(db)
        {

        }

        public string FatTotal(List<FatDetailList> fd)
        {
            decimal Total = fd.Sum(x => x.Amount * x.UnitPrice);
            int Count = fd.Count();
            return $"Invoice Totals: {Count} numbers of products together with total amount of {Total}";

        }
        public List<FatDetailList> GetFatDetailList(int id)
        {
            return Set().Select(x => new FatDetailList
            {
                Id = x.Id,               
                ProductId = x.ProductId,
                Amount = x.Amount,
                ProductName = x.Product.ProductName,
                UnitPrice = x.UnitPrice,
                Total = x.UnitPrice * x.Amount,
                ProductImage = x.Product.ProductImage
            }).Where(x => x.Id == id).ToList();

        }

        //public List<FatDetailList> GetFatDetailList(int id)  
        //{
        //    var list = Qry();
        //    list = list.Where(x => x.Id == id);

        //    return list.Select(x => new FatDetailList
        //    {
        //        Id = id,
        //        ProductId = x.ProductId,
        //        Amount = x.Amount,
        //        //ProductName = x.Product.ProductName,
        //        UnitPrice = x.UnitPrice,
        //        Total = x.UnitPrice * x.Amount,
        //        //ProductImage = x.Product.ProductImage
        //    }).ToList();

    }
}



