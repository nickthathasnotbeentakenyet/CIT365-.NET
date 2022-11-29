using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeeting.Data;
using System;
using System.Linq;

namespace SacramentMeeting.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingContext>>()))
            {
                // Look for any movies.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("2022-2-25"),
                        President = "",
                        Conductor = "",
                        OpeningHymn = "",
                        OpeningPrayer = "",
                        IntermediateHymn = "",
                        Speakers = 0,
                        SpeakerSubject = "",
                        ClosingHymn = "",
                        ClosingPrayer = "",
    }  
                );
                context.SaveChanges();
            }
        }
    }
}