namespace Survey.Data
{
    using Microsoft.EntityFrameworkCore;
    using Survey.Models;

    public class ApplicationContext : DbContext
    {
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserResponse> UserResponses { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {


        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Questionnaire>().HasData(
        //         Id = 1, Title = "Sample Questionnaire",
        //         new Question
        //         {
                    
        //             Text = "How often do you exercise?",
        //             Answers = new List<Answer>
        //                {
        //                    new Answer { Text = "Every day", Points = 10 },
        //                    new Answer { Text = "A few times a week", Points = 5 },
        //                    new Answer { Text = "Rarely", Points = 2 }
        //                }
        //         }
        //         ,
        //           new Question
        //           {
        //               Id = 2,
        //               Text = "How often do you exercise?",
        //               Answers = new List<Answer>
        //                {
        //                    new Answer { Text = "Every day", Points = 10 },
        //                    new Answer { Text = "A few times a week", Points = 5 },
        //                    new Answer { Text = "Rarely", Points = 2 }
        //                }
        //           }, new Question
        //           {
        //               Id = 3,
        //               Text = "How often do you exercise?",
        //               Answers = new List<Answer>
        //                {
        //                    new Answer { Text = "Every day", Points = 10 },
        //                    new Answer { Text = "A few times a week", Points = 5 },
        //                    new Answer { Text = "Rarely", Points = 2 }
        //                }
        //           }

        //        );
        //}
    }
}
