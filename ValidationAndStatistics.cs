using System;

namespace ResourceManagement
{
    public static class Validation
    {
        public static bool IsValidDuration(int minutes) => minutes > 0 && minutes < 1000;
    }

    public static class Statistics
    {
        private static int _resourcesAdded = 0;
        public static int ResourcesAdded => _resourcesAdded;

        public static void IncrementAddedResources()
        {
            _resourcesAdded++;
        }

        // خاصية ساكنة تحسب قيمة إجمالية (مثال بسيط)
    }
}
