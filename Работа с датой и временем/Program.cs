public class ExamSchedule
{
    public class Exam
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string FIOteacher { get; set; }
        public string Group { get; set; }
        public int AudNumber { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public static void Main(string[] args)
    {
        List<Exam> exams = new List<Exam>()
        {
            new Exam { Date = new DateTime(2024, 12, 17), Subject = "Математика", FIOteacher = "Иванов Иван Иванович", Group = "Группа 1\n", AudNumber = 101, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(11, 0, 0) },
            new Exam { Date = new DateTime(2024, 12, 16), Subject = "Физика", FIOteacher = "Петров Петр Петрович", Group = "Группа 2\n", AudNumber = 102, StartTime = new TimeSpan(11, 0, 0), EndTime = new TimeSpan(13, 0, 0) },
            new Exam { Date = new DateTime(2024, 12, 15), Subject = "Химия", FIOteacher = "Сидоров Сидор Сидорович", Group = "Группа 1\n", AudNumber = 103, StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(16, 0, 0) }
        };


        //вывод всей информации по экзаменам с указанием дня недели
        Console.WriteLine("Все экзамены:");
        PrintExams(exams);

        //вывод информации по экзаменам, которые начинаются до 12:00
        Console.WriteLine("\nЭкзамены, начинающиеся до 12:00:");
        DateTime specifiedDate = new DateTime(2024, 12, 16);
        PrintExamsBefore12(exams, specifiedDate);
    }

    //функция для вывода информации по экзаменам
    static void PrintExams(List<Exam> exams)
    {
        foreach (var exam in exams)
        {
            Console.WriteLine($"Дата: {exam.Date.ToShortDateString()}, День недели: {GetDayOfWeek(exam.Date)}, Предмет: {exam.Subject}, Преподаватель: {exam.FIOteacher}, Группа: {exam.Group}, Аудитория: {exam.AudNumber}, Время начала: {exam.StartTime.ToString(@"hh\:mm")}, Время окончания: {exam.EndTime.ToString(@"hh\:mm")}");
        }
    }

    //функция для вывода информации по экзаменам, которые начинаются до 12:00
    static void PrintExamsBefore12(List<Exam> exams, DateTime date)
    {
        foreach (var exam in exams)
        {
            if (exam.Date == date && exam.StartTime.Hours < 12)
            {
                Console.WriteLine($"Дата: {exam.Date.ToShortDateString()}, День недели: {GetDayOfWeek(exam.Date)}, Предмет: {exam.Subject}, Преподаватель: {exam.FIOteacher}, Группа: {exam.Group}, Аудитория: {exam.AudNumber}, Время начала: {exam.StartTime.ToString(@"hh\:mm")}, Время окончания: {exam.EndTime.ToString(@"hh\:mm")}");
            }
        }
    }

    //функция для получения дня недели
    static string GetDayOfWeek(DateTime date)
    {
        return date.DayOfWeek.ToString();
    }
}