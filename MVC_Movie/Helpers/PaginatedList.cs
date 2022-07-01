using System;
using System.Collections.Generic;

namespace MVC_Movie.Helpers
{
    public class PaginatedList<T> : List<T>
    {
        // pageSize là kích thước sản phẩm trong 1 trang, count là tổng số sản phẩm
        public PaginatedList(IEnumerable<T> items, int count, int pageIndex, int pageSize) {
            this.AddRange(items);
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            if(PageIndex > TotalPages){
                PageIndex = TotalPages;
            }
            if(PageIndex < 1){
                PageIndex = 1;
            }
        }

        // Trang hiện tại
        public int PageIndex { get; }

        // Tổng số trang
        public int TotalPages { get; }
        public bool HasPreviousPage { get => PageIndex > 1; }
        public bool HasNextPage { get => PageIndex < TotalPages; }
    }
}