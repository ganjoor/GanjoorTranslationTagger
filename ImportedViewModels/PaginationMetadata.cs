using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanjoorTranslationTagger.ImportedViewModels
{
    //
    // Summary:
    //     pagination metadat
    public class PaginationMetadata
    {
        //
        // Summary:
        //     total count
        public int totalCount { get; set; }

        //
        // Summary:
        //     page size
        public int pageSize { get; set; }

        //
        // Summary:
        //     current page
        public int currentPage { get; set; }

        //
        // Summary:
        //     total pages
        public int totalPages { get; set; }

        //
        // Summary:
        //     has previous page
        public bool hasPreviousPage { get; set; }

        //
        // Summary:
        //     has next page
        public bool hasNextPage { get; set; }
    }
}
