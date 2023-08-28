using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>
                    {
                        new Cinema
                        {
                            Name = "AutoCinema",
                            Logo = "https://i.simpalsmedia.com/afisha.md/places/750x350/b70f61ce15732ecb11c39eab2400dc25.jpg",
                            Description = "Cel mai romantic loc din Chișinău. Fiecare dintre noi, urmărind vechiul cinema american, visa să pătrundă în acest loc magic. Un loc pentru pasionații de mașini, cinefili și doar iubitori."
                        },
                        new Cinema
                        {
                            Name = "Cineplex-Loteanu",
                            Logo = "https://i.simpalsmedia.com/afisha.md/places/750x350/5cca7208c5ce9594203c5c9cb49d4a71.jpg",
                            Description = "Cinematograful central al municipiului Chișinău, numit după remarcabilul regizor moldovean Emil Loteanu. Numărul total de locuri este de 436."
                        },
                        new Cinema
                        {
                            Name = "Cineplex Mall",
                            Logo = "https://i.simpalsmedia.com/afisha.md/places/750x350/60fa3eff9699e0d972613bccc5c13fa6.jpg",
                            Description = "Multiplexul “CINEPLEX” este cel mai mare cinematograf al Republicii Moldova şi este amplasat la etaju 4 al centrului commercial \"Shopping Malldova\". Capacitatea cinematografului – 908 locuri."
                        },
                        new Cinema
                        {
                            Name = "Cinema Rex Padova",
                            Logo = "https://i.simpalsmedia.com/afisha.md/places/750x350/07730f3cafb3ce176478e8459f9ca31a.jpg",
                            Description = " Cinema Rex Padova"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>
                    {
                        new Actor
                        {
                          FullName = "Tom Hanks",
                          ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Tom_Hanks_TIFF_2019.jpg/220px-Tom_Hanks_TIFF_2019.jpg",
                          Bio = "Tom Hanks is an acclaimed actor known for his roles in movies like Forrest Gump, Cast Away, and Saving Private Ryan."
                        },
                        new Actor
                        {
                          FullName = "Meryl Streep",
                          ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Meryl_Streep_December_2018.jpg/220px-Meryl_Streep_December_2018.jpg",
                          Bio = "Meryl Streep is a versatile actress renowned for her performances in films such as The Devil Wears Prada, Mamma Mia!, and Sophie's Choice."
                        },
                        new Actor
                        {
                          FullName = "Leonardo DiCaprio",
                          ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Leonardo_Dicaprio_Cannes_2019.jpg/220px-Leonardo_Dicaprio_Cannes_2019.jpg",
                          Bio = "Leonardo DiCaprio is a celebrated actor famous for his roles in Titanic, Inception, and The Revenant."
                        },
                        new Actor
                        {
                          FullName = "Scarlett Johansson",
                          ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Scarlett_Johansson_by_Gage_Skidmore_2_%28cropped%2C_2%29.jpg/220px-Scarlett_Johansson_by_Gage_Skidmore_2_%28cropped%2C_2%29.jpg",
                          Bio = "Scarlett Johansson is a talented actress known for her performances in The Avengers series, Lost in Translation, and Marriage Story."
                        },
                        new Actor
                        {
                          FullName = "Denzel Washington",
                          ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Denzel_Washington_2018.jpg/220px-Denzel_Washington_2018.jpg",
                          Bio = "Denzel Washington is an accomplished actor recognized for his roles in Training Day, Glory, and The Equalizer."
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>
                    {
                        new Producer
                        {
                          ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-52.jpg",
                          FullName = "Michael Mann",
                          Bio = "Mann was a student at London’s International Film School and began his career in the late 70s. Writing for TV shows such as Starsky and Hutch."
                        },
                        new Producer
                        {
                          ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-1-4.jpg",
                          FullName = "Steven Spielberg",
                          Bio = "Spielberg is simply one of the most influential and famous movie producer in the history of cinema."
                        },
                        new Producer
                        {
                          ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-2-4.jpg  ",
                          FullName = "Spike Lee",
                          Bio = "Spike Lee is one of the most famous black movie producers, he was born Shelton Jackson Lee on March 20, 1957, in Atlanta, Georgia but moved to New York at a young age."
                        },
                        new Producer
                        {
                          ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-3-4.jpg",
                          FullName = "Quentin Tarantino",
                          Bio = "Quentin Tarantino was born in Knoxville, Tennessee. To Tony Tarantino – an Italian-American actor and musician from New York, and Connie (McHugh), a nurse. "
                        },
                    });
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>
                    {
                        new Movie
                        {
                            Name = "Collateral",
                            Description = "Collateral is a 2004 thriller film starring Tom Cruise and Jamie Foxx.",
                            Price = 25.34,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjE3NjM5OTMxMV5BMl5BanBnXkFtZTcwOTIzMTQyMw@@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now.AddDays(-12),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie
                        {
                            Name = "Jurassic Park",
                            Description = "Jurassic Park is an American science fiction/thriller film directed by Steven Spielberg and based on the novel of the same name , written by Michael Crichton.",
                            Price = 34.21,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjM2MDgxMDg0Nl5BMl5BanBnXkFtZTgwNTM2OTM5NDE@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.ScienceFiction
                        },
                        new Movie
                        {
                            Name = "The man inside",
                            Description = "Inside Man is a 2006 American thriller film directed by Spike Lee and written by Russell Gewirtz. It focuses on an elaborate bank heist turned hostage on Wall Street over a 24-hour period.",
                            Price = 18.34,
                            ImageURL = "https://static.cinemagia.ro/img/db/movie/01/33/61/inside-man-809629l.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie
                        {
                            Name = "Once upon a time in...Hollywood",
                            Description = "lm written and directed by Quentin Tarantino. Produced by Columbia Pictures, Bona Film Group, Heyday Films and Visiona Romantica and distributed by Sony Pictures Release",
                            Price = 25.34,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/ro/3/32/A_fost_odat%C4%83_la..._Hollywood.jpg",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(12),
                            CinemaId = 4,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>
                    {
                       new Actor_Movie
                       {
                         ActorId = 3,
                         MovieId = 2
                       },
                       new Actor_Movie
                       {
                         ActorId = 4,
                         MovieId = 2
                       },
                       new Actor_Movie
                       {
                         ActorId = 1,
                         MovieId = 4
                       },
                       new Actor_Movie
                       {
                         ActorId = 2,
                         MovieId = 3
                       },
                       new Actor_Movie
                       {
                         ActorId = 4,
                         MovieId = 3
                       },
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
