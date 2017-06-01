using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Topic dummyTopic = new Topic()
            {
                title = "Dummy title",
                description = "Dummy description",
                principles = new List<Principles>()
                {
                    new Principles()
                    {
                        header = "Dummy Header",
                        principleDetails = new List<PrincipleDetails>()
                        {
                            new PrincipleDetails()
                            {
                                description = "Dummy description principle details",
                                image = "Dummy Image.jpg"
                            },
                            new PrincipleDetails()
                            {
                                description = "Dummy description principle details2",
                                image = "Dummy Image2.jpg"
                            }
                        }
                    },
                    new Principles()
                    {
                        header = "Dummy Header2",
                        principleDetails = new List<PrincipleDetails>()
                        {
                            new PrincipleDetails()
                            {
                                description = "Dummy description principle details3",
                                image = "Dummy Image3.jpg"
                            },
                            new PrincipleDetails()
                            {
                                description = "Dummy description principle details4",
                                image = "Dummy Image4.jpg"
                            }
                        }
                    }
                }
            };
            MyStorage.storeXML<Topic>(dummyTopic, "Topic.xml");


        }
    }
}
