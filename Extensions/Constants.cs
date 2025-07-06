using System.Collections.Generic;

namespace Fractals.Extensions
{
    public class Constants
    {
        public static readonly Dictionary<int, int> geometricMaxIterations = new Dictionary<int, int>
        {
            { 0, 5  },
            { 1, 5  },
            { 2, 6  },
            { 3, 6  },
            { 4, 12 },
            { 5, 6  }
        };
    }
}
