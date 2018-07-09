using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookLibraryManagerWebApp.ViewModels
{
    /// <summary>
    /// View model for the "Delete Comic Book" view.
    /// </summary>
    public class ComicBooksDeleteViewModel : ComicBooksBaseViewModel
    {


            /// <summary>
            /// This property enables model binding to be able to bind the "id"
            /// route parameter value to the "ComicBook.Id" model property.
            /// </summary>
            public int Id
            {
                get { return ComicBook.Id; }
                set { ComicBook.Id = value; }
            }

            public bool ComicBookHasBeenDeleted { get; set; }
        
    }
}