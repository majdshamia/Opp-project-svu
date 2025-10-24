using System;

namespace ResourceManagement
{
    public static class Statistics
    {
        private static int _resourcesAdded = 0;
        public static int ResourcesAdded => _resourcesAdded;
        public static string Summary => $"Total resources added: {_resourcesAdded}";

        public static void IncrementAddedResources()
        {
            _resourcesAdded++;
        }
    }

    #region Program Demo
    class Program
    {
        static void Main(string[] args)
        {
            // إنشاء مدير الدورة
            CourseManager manager = new CourseManager();

            // الاشتراك لحدث مكتمل المورد (مثال على التفويض والأحداث)
            ResourceCompletedHandler globalHandler = (sender, e) =>
            {
                Console.WriteLine($"[Global Handler] -> Resource finished: {e.ResourceTitle} (ID: {e.ResourceId})");
            };

            // إنشاء موارد
            Lesson lesson1 = new Lesson("مقدمة في قواعد اللغة الفرنسية (Present tense)", 30);
            Quiz quiz1 = new Quiz("اختبار القواعد - المضارع", 10);
            ConversationExercise conv1 = new ConversationExercise("محادثة بسيطة: التعارف", "Partner A");

            // الاشتراك في الحدث للموردين
            lesson1.ResourceCompleted += globalHandler;
            quiz1.ResourceCompleted += globalHandler;
            conv1.ResourceCompleted += globalHandler;

            // إضافة الموارد إلى المدير
            manager.AddResource(lesson1);
            manager.AddResource(quiz1);
            manager.AddResource(conv1);
        }
    }
    #endregion
}
