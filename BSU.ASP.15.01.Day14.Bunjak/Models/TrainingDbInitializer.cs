using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BSU.ASP._15._01.Day14.Bunjak.Models
{
    public class TrainingDbInitializer : DropCreateDatabaseAlways<TrainingContext>
    {
        protected override void Seed(TrainingContext db)
        {
            db.Tranings.Add(new Training {Id=1, Name = "Тестирование программного обеспечения" });
            db.Tranings.Add(new Training {Id=2, Name = "Разработка web-приложений на Java" });
            db.Tranings.Add(new Training {Id=3, Name = "Программирование Web приложений на ASP.NET MVC" });

            db.Students.Add(new RegistrationStudent() { Name = "Иван", Surname="Иванов", Course = 3, Email = "dfdf@mail.ru", University = "BSU", TrainingId = 2});
            db.Students.Add(new RegistrationStudent() { Name = "Семён", Surname = "Петров", Course = 3, Email = "dsdsf@mail.ru", University = "BSU", TrainingId = 2 });
            db.Students.Add(new RegistrationStudent() { Name = "Иван", Surname = "Смернов", Course = 3, Email = "sdvf@mail.ru", University = "BSU", TrainingId = 2 });

            db.Students.Add(new RegistrationStudent() { Name = "Иван", Surname = "Иванов", Course = 3, Email = "dfdf@mail.ru", University = "BSU", TrainingId = 3 });
            db.Students.Add(new RegistrationStudent() { Name = "Семён", Surname = "Петров", Course = 3, Email = "dsdsf@mail.ru", University = "BSU", TrainingId = 3 });
            db.Students.Add(new RegistrationStudent() { Name = "Иван", Surname = "Смернов", Course = 3, Email = "sdvf@mail.ru", University = "BSU", TrainingId = 3 });
            base.Seed(db);
        }
    }
}