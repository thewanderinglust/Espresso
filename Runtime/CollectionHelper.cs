using System.Collections.Generic;
using UnityEngine;

namespace Espresso.DataUtilities
{
    public static class CollectionHelper
    {
        public static T GetSingleListEntry<T>(List<T> a_listOfThings)
        {
            return a_listOfThings[Random.Range(0, a_listOfThings.Count - 1)];
        }
    }
}

