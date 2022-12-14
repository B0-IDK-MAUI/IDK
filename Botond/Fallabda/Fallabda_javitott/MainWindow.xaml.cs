using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
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
using System.Windows.Threading;

namespace Fallabda_javitott
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            konnyu.Visibility = Visibility.Visible;
            kozepes.Visibility = Visibility.Visible;
            nehez.Visibility = Visibility.Visible;
            nehezseg.Visibility = Visibility.Visible;
            exit.Visibility = Visibility.Visible;
            labelPlayer.Visibility = Visibility.Visible;
            TextBoxPlayer.Visibility = Visibility.Visible;
            block.Visibility = Visibility.Hidden;
            block1.Visibility = Visibility.Hidden;
            block2.Visibility = Visibility.Hidden;
            block3.Visibility = Visibility.Hidden;
            block4.Visibility = Visibility.Hidden;
            block5.Visibility = Visibility.Hidden;
            block6.Visibility = Visibility.Hidden;
            block7.Visibility = Visibility.Hidden;
            block8.Visibility = Visibility.Hidden;
            block9.Visibility = Visibility.Hidden;
            block10.Visibility = Visibility.Hidden;
            block11.Visibility = Visibility.Hidden;
            block12.Visibility = Visibility.Hidden;
            block13.Visibility = Visibility.Hidden;
            block14.Visibility = Visibility.Hidden;
            block15.Visibility = Visibility.Hidden;



            DispatcherTimer ido = new DispatcherTimer();
            ido.Interval = TimeSpan.FromMilliseconds(1);
            ido.Tick += new EventHandler(idoLepes);
            ido.Start();
        }

        Random r = new Random();
        int sebessegX = 3, sebessegY = 5, pont = 0, x = 450, y = 450;
        int ido = 0;
        string diff = "";

        private void uj_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        public void GameTimer()
        {
            ido++;
            labelido.Content = (ido / 100).ToString();
        }
        private void idoLepes(object sender, EventArgs e)
        {

            if (konnyu.Visibility == Visibility.Hidden)
                if (vege.Visibility == Visibility.Hidden)
                {

                    //TIMER
                    GameTimer();

                    //Ütő mozgása
                    Point position = Mouse.GetPosition(canvas);
                    int XUto = Convert.ToInt32(position.X);
                    if (XUto < 0) XUto = 0;
                    if (XUto > Application.Current.MainWindow.Width - uto.Width) XUto = 885;
                    Canvas.SetLeft(uto, XUto);


                    //LABDA VISSZAPATTANÁSA ÜTŐRŐL + PONT SZÁMÍTÁS + SEBESSÉG
                    if (Canvas.GetTop(labda) >= 520 && XUto - 15 < Canvas.GetLeft(labda) && XUto + 85 > Canvas.GetLeft(labda))
                    {
                        sebessegY = -sebessegY;
                        if (sebessegX <= 0) sebessegX -= r.Next(2);
                        if (sebessegY <= 0) sebessegY -= r.Next(2);
                        pont += 1;
                        labelpont.Content = pont.ToString();
                    }

                    //LABDA MOZGÁSA
                    x += sebessegX;
                    y += sebessegY;
                    Canvas.SetLeft(labda, x);
                    Canvas.SetTop(labda, y);


                    //BLOCKOK
                    #region
                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block) + block.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block) + block.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block) && block.Visibility == Visibility.Visible)
                    {
                        block.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block1) + block1.Width &&
                    Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block1) &&
                    Canvas.GetTop(labda) < Canvas.GetTop(block1) + block.Height &&
                    Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block1) && block1.Visibility == Visibility.Visible)
                    {
                        block1.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block2) + block2.Width &&
                    Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block2) &&
                    Canvas.GetTop(labda) < Canvas.GetTop(block2) + block2.Height &&
                    Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block2) && block2.Visibility == Visibility.Visible)
                    {
                        block2.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block3) + block3.Width &&
                    Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block3) &&
                    Canvas.GetTop(labda) < Canvas.GetTop(block3) + block3.Height &&
                    Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block3) && block3.Visibility == Visibility.Visible)
                    {
                        block3.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block4) + block4.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block4) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block4) + block4.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block) && block4.Visibility == Visibility.Visible)
                    {
                        block4.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block5) + block5.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block5) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block5) + block5.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block) && block5.Visibility == Visibility.Visible)
                    {
                        block5.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block6) + block6.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block6) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block6) + block4.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block6) && block6.Visibility == Visibility.Visible)
                    {
                        block6.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block7) + block7.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block7) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block7) + block7.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block7) && block7.Visibility == Visibility.Visible)
                    {
                        block7.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block8) + block8.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block8) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block8) + block8.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block8) && block8.Visibility == Visibility.Visible)
                    {
                        block8.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block9) + block9.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block9) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block9) + block9.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block9) && block9.Visibility == Visibility.Visible)
                    {
                        block9.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block10) + block10.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block10) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block10) + block10.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block10) && block10.Visibility == Visibility.Visible)
                    {
                        block10.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block11) + block11.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block11) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block11) + block11.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block11) && block11.Visibility == Visibility.Visible)
                    {
                        block11.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block12) + block12.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block12) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block12) + block12.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block12) && block12.Visibility == Visibility.Visible)
                    {
                        block12.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block13) + block13.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block13) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block13) + block13.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block13) && block13.Visibility == Visibility.Visible)
                    {
                        block13.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block14) + block14.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block14) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block14) + block14.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block14) && block14.Visibility == Visibility.Visible)
                    {
                        block14.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }

                    if (Canvas.GetLeft(labda) < Canvas.GetLeft(block15) + block15.Width &&
                        Canvas.GetLeft(labda) + labda.Width > Canvas.GetLeft(block15) &&
                        Canvas.GetTop(labda) < Canvas.GetTop(block15) + block15.Height &&
                        Canvas.GetTop(labda) + labda.Height > Canvas.GetTop(block15) && block15.Visibility == Visibility.Visible)
                    {
                        block15.Visibility = Visibility.Hidden;
                        sebessegY = -sebessegY;
                        pont++;
                        labelpont.Content = pont.ToString();
                    }
                    #endregion

                    //LABDA OLDALRÓL VISSZAPATTANÁSA
                    if (Canvas.GetLeft(labda) <= 0) sebessegX = -sebessegX;
                    if (Canvas.GetLeft(labda) >= 955) sebessegX = -sebessegX;
                    if (Canvas.GetTop(labda) <= 30) sebessegY = -sebessegY;

                    //JÁTÉK VÉGE
                    if (Canvas.GetTop(labda) > 528)
                    {
                        block.Visibility = Visibility.Hidden;
                        block1.Visibility = Visibility.Hidden;
                        block2.Visibility = Visibility.Hidden;
                        block3.Visibility = Visibility.Hidden;
                        block4.Visibility = Visibility.Hidden;
                        block5.Visibility = Visibility.Hidden;
                        block6.Visibility = Visibility.Hidden;
                        block7.Visibility = Visibility.Hidden;
                        block8.Visibility = Visibility.Hidden;
                        block9.Visibility = Visibility.Hidden;
                        block10.Visibility = Visibility.Hidden;
                        block11.Visibility = Visibility.Hidden;
                        block12.Visibility = Visibility.Hidden;
                        block13.Visibility = Visibility.Hidden;
                        block14.Visibility = Visibility.Hidden;
                        block15.Visibility = Visibility.Hidden;
                        win.Visibility = Visibility.Hidden;
                        Mouse.OverrideCursor = Cursors.Arrow;
                        vege.Visibility = Visibility.Visible;
                        uj.Visibility = Visibility.Visible;
                        exit.Visibility = Visibility.Visible;
                        sebessegX = 0;
                        sebessegY = 0;
                        LeaderBoard();
                    }


                    if (block.Visibility == Visibility.Hidden &&
                            block1.Visibility == Visibility.Hidden &&
                            block2.Visibility == Visibility.Hidden &&
                            block3.Visibility == Visibility.Hidden &&
                            block4.Visibility == Visibility.Hidden &&
                            block5.Visibility == Visibility.Hidden &&
                            block6.Visibility == Visibility.Hidden &&
                            block7.Visibility == Visibility.Hidden &&
                            block8.Visibility == Visibility.Hidden &&
                            block9.Visibility == Visibility.Hidden &&
                            block10.Visibility == Visibility.Hidden &&
                            block11.Visibility == Visibility.Hidden &&
                            block12.Visibility == Visibility.Hidden &&
                            block13.Visibility == Visibility.Hidden &&
                            block14.Visibility == Visibility.Hidden &&
                            block15.Visibility == Visibility.Hidden && Canvas.GetTop(labda) < 528)
                    {
                        Mouse.OverrideCursor = Cursors.Arrow;
                        vege.Visibility = Visibility.Visible;
                        win.Visibility = Visibility.Visible;
                        uj.Visibility = Visibility.Visible;
                        exit.Visibility = Visibility.Visible;
                        uto.Visibility = Visibility.Hidden;
                        labda.Visibility = Visibility.Hidden;
                        sebessegX = 0;
                        sebessegY = 0;
                        LeaderBoard();
                    }

                }
        }

        public void LeaderBoard()
        {
            MessageBox.Show($"Játékos neve: {TextBoxPlayer.Text} - Pont: {labelpont.Content} - Idő: {labelido.Content} - Nehézség: {diff}");
            List<Player> tmp = new List<Player>();
            tmp.Add(new Player(TextBoxPlayer.Text, labelpont.Content.ToString(), labelido.Content.ToString(), diff));
            var kek = File.ReadAllText("leaderboard.json");
            if (kek != "")
            {
                var pl = JsonSerializer.Deserialize<List<Player>>(kek);
                tmp.AddRange(pl);
            }
            var Ordered = tmp.OrderByDescending(x => Convert.ToInt32(x.Point)).ToList();
            if (Ordered.Count >= 3)
            {
                string aktHely = "Név || Pont || Idő || Nehézség \n" + $"1. {Ordered[0].Name} - {Ordered[0].Point} - {Ordered[0].Time} - {Ordered[0].Level} \n" +
                    $"2. {Ordered[1].Name} - {Ordered[1].Point} - {Ordered[1].Time} - {Ordered[1].Level} \n" +
                    $"3. {Ordered[2].Name} - {Ordered[2].Point} - {Ordered[2].Time} - {Ordered[2].Level}\n";
                MessageBox.Show(aktHely);
                File.WriteAllText("Helyezes.txt", aktHely);
            }
            string output = JsonSerializer.Serialize(Ordered);
            File.WriteAllText("leaderboard.json", output);

        }

        private void konnyu_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxPlayer.Text != "")
            {
                diff = "Konnyu";
                nehezseg.Visibility = Visibility.Hidden;
                konnyu.Visibility = Visibility.Hidden;
                kozepes.Visibility = Visibility.Hidden;
                nehez.Visibility = Visibility.Hidden;
                labelPlayer.Visibility = Visibility.Hidden;
                TextBoxPlayer.Visibility = Visibility.Hidden;
                labda.Visibility = Visibility.Visible;
                uto.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Hidden;
                block.Visibility = Visibility.Visible;
                block1.Visibility = Visibility.Visible;
                block2.Visibility = Visibility.Visible;
                block3.Visibility = Visibility.Visible;
                block4.Visibility = Visibility.Visible;
                block5.Visibility = Visibility.Visible;
                block6.Visibility = Visibility.Visible;
                block7.Visibility = Visibility.Visible;
                block8.Visibility = Visibility.Visible;
                block9.Visibility = Visibility.Visible;
                block10.Visibility = Visibility.Visible;
                block11.Visibility = Visibility.Visible;
                block12.Visibility = Visibility.Visible;
                block13.Visibility = Visibility.Visible;
                block14.Visibility = Visibility.Visible;
                block15.Visibility = Visibility.Visible;
                labelido.Visibility = Visibility.Visible;
                labelpont.Visibility = Visibility.Visible;
                stringpont.Visibility = Visibility.Visible;
                stringido.Visibility = Visibility.Visible;
                Mouse.OverrideCursor = Cursors.None;
            }
            else
            {
                MessageBox.Show("A játékos név kitöltése kötelező!");
            }
        }

        private void kozepes_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxPlayer.Text != "")
            {
                pont += 10;
                diff = "Kozepes";
                labda.Width = 15;
                labda.Height = 15;
                uto.Width = 75;
                nehezseg.Visibility = Visibility.Hidden;
                konnyu.Visibility = Visibility.Hidden;
                kozepes.Visibility = Visibility.Hidden;
                nehez.Visibility = Visibility.Hidden;
                labelPlayer.Visibility = Visibility.Hidden;
                TextBoxPlayer.Visibility = Visibility.Hidden;
                labda.Visibility = Visibility.Visible;
                uto.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Hidden;
                block.Visibility = Visibility.Visible;
                block1.Visibility = Visibility.Visible;
                block2.Visibility = Visibility.Visible;
                block3.Visibility = Visibility.Visible;
                block4.Visibility = Visibility.Visible;
                block5.Visibility = Visibility.Visible;
                block6.Visibility = Visibility.Visible;
                block7.Visibility = Visibility.Visible;
                block8.Visibility = Visibility.Visible;
                block9.Visibility = Visibility.Visible;
                block10.Visibility = Visibility.Visible;
                block11.Visibility = Visibility.Visible;
                block12.Visibility = Visibility.Visible;
                block13.Visibility = Visibility.Visible;
                block14.Visibility = Visibility.Visible;
                block15.Visibility = Visibility.Visible;
                labelido.Visibility = Visibility.Visible;
                labelpont.Visibility = Visibility.Visible;
                stringpont.Visibility = Visibility.Visible;
                stringido.Visibility = Visibility.Visible;
                Mouse.OverrideCursor = Cursors.None;
            }
            else
            {
                MessageBox.Show("A játékos név kitöltése kötelező!");
            }
        }

        private void nehez_Click(object sender, RoutedEventArgs e)
        {
            pont += 20;
            if (TextBoxPlayer.Text != "")
            {
                diff = "Nehez";
                labda.Width = 10;
                labda.Height = 10;
                uto.Width = 50;
                nehezseg.Visibility = Visibility.Hidden;
                kozepes.Visibility = Visibility.Hidden;
                konnyu.Visibility = Visibility.Hidden;
                nehez.Visibility = Visibility.Hidden;
                labelPlayer.Visibility = Visibility.Hidden;
                TextBoxPlayer.Visibility = Visibility.Hidden;
                labda.Visibility = Visibility.Visible;
                uto.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Hidden;
                block.Visibility = Visibility.Visible;
                block1.Visibility = Visibility.Visible;
                block2.Visibility = Visibility.Visible;
                block3.Visibility = Visibility.Visible;
                block4.Visibility = Visibility.Visible;
                block5.Visibility = Visibility.Visible;
                block6.Visibility = Visibility.Visible;
                block7.Visibility = Visibility.Visible;
                block8.Visibility = Visibility.Visible;
                block9.Visibility = Visibility.Visible;
                block10.Visibility = Visibility.Visible;
                block11.Visibility = Visibility.Visible;
                block12.Visibility = Visibility.Visible;
                block13.Visibility = Visibility.Visible;
                block14.Visibility = Visibility.Visible;
                block15.Visibility = Visibility.Visible;
                labelido.Visibility = Visibility.Visible;
                labelpont.Visibility = Visibility.Visible;
                stringpont.Visibility = Visibility.Visible;
                stringido.Visibility = Visibility.Visible;
                Mouse.OverrideCursor = Cursors.None;
            }
            else
            {
                MessageBox.Show("A játékos név kitöltése kötelező!");
            }
        }
    }
}
