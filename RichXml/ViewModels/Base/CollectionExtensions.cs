using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RichXml.ViewModels
{
    public static class CollectionExtensions
    {
        public static ObservableCollection<T> ToVM<T>(this List<T> arg)
        {
            return new ObservableCollection<T>(arg);
        }

        public static ObservableCollection<T> ToVM<T>(this IQueryable<T> arg)
        {
            return new ObservableCollection<T>(arg.ToList());
        }
    }
}