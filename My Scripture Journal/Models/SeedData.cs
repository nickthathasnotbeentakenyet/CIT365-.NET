using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Data;

namespace My_Scripture_Journal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new My_Scripture_JournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<My_Scripture_JournalContext>>()))
            {
                if (context == null || context.Scripture == null)
                {
                    throw new ArgumentNullException("Null My_Scripture_JournalContext");
                }

                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1Nephi",
                        Chapter = "3:7",
                        DateAdded = DateTime.Parse("2022-10-23"),
                        ScriptureBody = "And it came to pass that I, Nephi, " +
                        "said unto my father: I will go and do the things which the Lord hath commanded, " +
                        "for I know that the Lord giveth no commandments unto the children of men, " +
                        "save he shall prepare a way for them that they may accomplish the thing " +
                        "which he commandeth them.",
                        Notes = "Go and do what the Lord says!"
                    },

                    new Scripture
                    {
                        Book = "2Nephi",
                        Chapter = "2:25",
                        DateAdded = DateTime.Parse("2022-10-23"),
                        ScriptureBody = "Adam fell that men might be; and men are, that they might have joy.",
                        Notes = "It's all according to the plan. People are to have joy"
                    },

                    new Scripture
                    {
                        Book = "Mosiah",
                        Chapter = "2:17",
                        DateAdded = DateTime.Parse("2022-10-23"),
                        ScriptureBody = "And behold, I tell you these things that ye may learn wisdom; " +
                        "that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
                        Notes = "We serve the Lord by serving people"
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = "7:11-13",
                        DateAdded = DateTime.Parse("2022-10-23"),
                        ScriptureBody = "And he shall go forth, suffering pains and afflictions and temptations of every kind;" +
                        " and this that the word might be fulfilled which saith he will take upon him the pains " +
                        "and the sicknesses of his people.\r\n\r\nAnd he will take upon him death, " +
                        "that he may loose the bands of death which bind his people; " +
                        "and he will take upon him their infirmities, that his bowels may be filled with mercy, " +
                        "according to the flesh, that he may know according to the flesh how to succor his people " +
                        "according to their infirmities.\r\n\r\nNow the Spirit knoweth all things; " +
                        "nevertheless the Son of God suffereth according to the flesh that he might take " +
                        "upon him the sins of his people, that he might blot out their transgressions " +
                        "according to the power of his deliverance; and now behold, this is the testimony which is in me.",
                        Notes = "Jesus suffered for everyone"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
