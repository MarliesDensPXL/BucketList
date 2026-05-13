using PE_BucketList.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BucketList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Country> _bucketList = new List<Country>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RateButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void CreateBucketList()
        {
            _bucketList = new List<Country>
            {
                new Country
                {
                    Name = "Japan",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Mount Fuji",
                            City = "Honshu",
                            Description = "Japan's iconic volcanic peak, often snow-capped and surrounded by lakes.",
                            ImageSource = "/images/mount-fuji.png"
                        },
                        new Place
                        {
                            Name = "Fushimi Inari Shrine",
                            City = "Kyoto",
                            Description = "Famous for thousands of vermillion torii gates winding up a mountain.",
                            ImageSource = "/images/fushimi-inari-shrine.png"
                        },
                        new Place
                        {
                            Name = "Arashiyama Bamboo Grove",
                            City = "Kyoto",
                            Description = "A serene and surreal bamboo forest walkway.",
                            ImageSource = "/images/arashiyama-bamboo-grove.png"
                        }
                    }
                },

                new Country
                {
                    Name = "Croatia",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Krka Waterfalls",
                            City = "Šibenik-Knin",
                            Description = "A series of emerald waterfalls flowing through lush forests.",
                            ImageSource = "/images/krka-waterfalls.png"
                        },
                        new Place
                        {
                            Name = "Plitvice Lakes",
                            City = "Lika-Senj",
                            Description = "16 terraced lakes connected by waterfalls, one of Croatia's biggest natural wonders.",
                            ImageSource = "/images/plitvice-lakes.png"
                        },
                        new Place
                        {
                            Name = "Dubrovnik Old Town",
                            City = "Dubrovnik",
                            Description = "A walled medieval city overlooking the Adriatic Sea.",
                            ImageSource = "/images/dubrovnik-old-town.png"
                        }
                    }
                },

                new Country
                {
                    Name = "Italy",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Colosseum",
                            City = "Rome",
                            Description = "Ancient gladiator arena and one of the New Seven Wonders.",
                            ImageSource = "/images/colosseum.png"
                        },
                        new Place
                        {
                            Name = "Cinque Terre",
                            City = "Liguria",
                            Description = "Five colourful villages perched on dramatic seaside cliffs.",
                            ImageSource = "/images/cinque-terre.png"
                        },
                        new Place
                        {
                            Name = "Venice Canals",
                            City = "Venice",
                            Description = "Romantic waterways navigated by gondolas.",
                            ImageSource = "/images/venice-canals.png"
                        }
                    }
                },

                new Country
                {
                    Name = "France",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Eiffel Tower",
                            City = "Paris",
                            Description = "The world-famous symbol of Paris.",
                            ImageSource = "/images/eiffel-tower.png"
                        },
                        new Place
                        {
                            Name = "Mont Saint-Michel",
                            City = "Normandy",
                            Description = "A medieval abbey rising dramatically from tidal waters.",
                            ImageSource = "/images/mont-saint-michel.png"
                        },
                        new Place
                        {
                            Name = "Louvre Museum",
                            City = "Paris",
                            Description = "The world's largest art museum, home to the Mona Lisa.",
                            ImageSource = "/images/louvre-museum.png"
                        }
                    }
                },

                new Country
                {
                    Name = "United States",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Grand Canyon",
                            City = "Arizona",
                            Description = "Vast canyon carved by the Colorado River.",
                            ImageSource = "/images/grand-canyon.png"
                        },
                        new Place
                        {
                            Name = "Times Square",
                            City = "New York City",
                            Description = "Iconic neon-lit intersection in Manhattan.",
                            ImageSource = "/images/time-square.png"
                        },
                        new Place
                        {
                            Name = "Yellowstone National Park",
                            City = "Wyoming",
                            Description = "America's first national park, known for geysers and wildlife.",
                            ImageSource = "/images/yellowstone.png"
                        }
                    }
                },

                new Country
                {
                    Name = "Australia",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Great Barrier Reef",
                            City = "Queensland",
                            Description = "The world's largest coral reef system.",
                            ImageSource = "/images/great-barrier-reef.png"
                        },
                        new Place
                        {
                            Name = "Sydney Opera House",
                            City = "Sydney",
                            Description = "A masterpiece of modern architecture.",
                            ImageSource = "/images/sydney-opera-house.png"
                        },
                        new Place
                        {
                            Name = "Uluru",
                            City = "Northern Territory",
                            Description = "Sacred massive sandstone monolith.",
                            ImageSource = "/images/uluru.png"
                        }
                    }
                },

                new Country
                {
                    Name = "Greece",
                    Places = new List<Place>
                    {
                        new Place
                        {
                            Name = "Santorini",
                            City = "Cyclades",
                            Description = "Whitewashed houses, blue domes, and famous sunsets.",
                            ImageSource = "/images/santorini.png"
                        },
                        new Place
                        {
                            Name = "Acropolis",
                            City = "Athens",
                            Description = "Ancient citadel overlooking Athens.",
                            ImageSource = "/images/acropolis.png"
                        },
                        new Place
                        {
                            Name = "Meteora",
                            City = "Thessaly",
                            Description = "Clifftop monasteries perched on giant rock pillars.",
                            ImageSource = "/images/meteora.png"
                        }
                    }
                }
            };
        }
    }
}