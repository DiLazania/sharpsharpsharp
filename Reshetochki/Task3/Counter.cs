using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Counter
    {
        public static int ObjectsCounter { get; private set; } = 0;

        public Counter()
        {
            ObjectsCounter++;
        }

    }
}
