// عرض ملخص إحصائي (Static property & static class)
Console.WriteLine(Statistics.Summary);
Console.WriteLine($"CourseManager.TotalResourcesCount (static): {CourseManager.TotalResourcesCount}");
Console.WriteLine();

// تشغيل جميع الموارد (يظهر Polymorphism لأن Start() مختلف)  
        manager.StartAll();  
        Console.WriteLine();  

        // اكتمال موارد محددة  
        manager.CompleteResource(lesson1.Id);  
        manager.CompleteResource(quiz1.Id);  
        // المحاولة اكتمال مورد غير موجودة تُعيد false (مثال)  
        var fakeId = Guid.NewGuid();  
        bool ok = manager.CompleteResource(fakeId);  
        Console.WriteLine($"Attempt to complete fake resource: {ok}");  
        Console.WriteLine();  

        // عرض معلومات عن الموارد (Encapsulation عبر GetInfo)  
        foreach (var info in manager.ListResourcesInfo())  
            Console.WriteLine(info);  

        Console.WriteLine();  
        Console.WriteLine("End of demo. Press any key to exit.");

Console.ReadKey();
}
}
#endregion
}