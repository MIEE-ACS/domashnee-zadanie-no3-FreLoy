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

namespace WpfDZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TB1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB2 != null)
            {
                string result = "";
                foreach (var c in TB1.Text)
                {
                    if (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                    {
                        Dictionary<char, string> translitTable =
                            new Dictionary<char, string>

                            {
                                {'А',"Ю" },
                                {'В',"Я" },
                                {'Б',"Э" },
                                {'Г',"Ь" },
                                {'Д',"Ы" },
                                {'Е',"Ъ" },
                                {'Ё',"Щ" },
                                {'Ж',"Ш" },
                                {'З',"Ч" },
                                {'И',"Ц" },
                                {'Й',"Х" },
                                {'К',"Ф" },
                                {'Л',"У" },
                                {'М',"Т" },
                                {'Н',"С" },
                                {'О',"Р" },
                                {'П',"П" },
                                {'Р',"О" },
                                {'С',"Н" },
                                {'Т',"М" },
                                {'У',"Л" },
                                {'Ф',"К" },
                                {'Х',"Й" },
                                {'Ц',"И" },
                                {'Ч',"З" },
                                {'Ш',"Ж" },
                                {'Щ',"Ё" },
                                {'Ъ',"Е" },
                                {'Ы',"Д" },
                                {'Ь',"Г" },
                                {'Э',"В" },
                                {'Ю',"Б" },
                                {'Я',"А" },
                                {'а',"я" },
                                {'б',"ю" },
                                {'в',"э" },
                                {'г',"ь" },
                                {'д',"ы" },
                                {'е',"ъ" },
                                {'ё',"щ" },
                                {'ж',"ш" },
                                {'з',"ч" },
                                {'и',"ц" },
                                {'й',"х" },
                                {'к',"ф" },
                                {'л',"у" },
                                {'м',"т" },
                                {'н',"с" },
                                {'о',"р" },
                                {'п',"п" },
                                {'р',"о" },
                                {'с',"н" },
                                {'т',"м" },
                                {'у',"л" },
                                {'ф',"к" },
                                {'х',"й" },
                                {'ц',"и" },
                                {'ч',"з" },
                                {'ш',"ж" },
                                {'щ',"ё" },
                                {'ъ',"е" },
                                {'ы',"д" },
                                {'ь',"г" },
                                {'э',"в" },
                                {'ю',"б" },
                                {'я',"а" },

                                {'A',"Z" },
                                {'B',"Y" },
                                {'C',"X" },
                                {'D',"W" },
                                {'E',"V" },
                                {'F',"U" },
                                {'G',"T" },
                                {'H',"S" },
                                {'I',"R" },
                                {'J',"Q" },
                                {'K',"P" },
                                {'L',"O" },
                                {'M',"N" },
                                {'N',"M" },
                                {'O',"L" },
                                {'P',"K" },
                                {'Q',"J" },
                                {'R',"I" },
                                {'S',"H" },
                                {'T',"G" },
                                {'U',"F" },
                                {'V',"E" },
                                {'W',"D" },
                                {'X',"C" },
                                {'Y',"B" },
                                {'Z',"A" },
                                {'a',"z" },
                                {'b',"y" },
                                {'c',"x" },
                                {'d',"w" },
                                {'e',"v" },
                                {'f',"u" },
                                {'g',"t" },
                                {'h',"s" },
                                {'i',"r" },
                                {'j',"q" },
                                {'k',"p" },
                                {'l',"o" },
                                {'m',"n" },
                                {'n',"m" },
                                {'o',"l" },
                                {'p',"k" },
                                {'q',"j" },
                                {'r',"i" },
                                {'s',"h" },
                                {'t',"g" },
                                {'u',"f" },
                                {'v',"e" },
                                {'w',"d" },
                                {'x',"c" },
                                {'y',"b" },
                                {'z',"a" },

                            };
                        result += translitTable[c];
                    }
                    else

                    {
                        result += c;
                    }
                    TB2.Text = result;
                }

            }
        }


        private void TB3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB4 != null)
            {
                string result = "";
                foreach (var c in TB3.Text)
                {
                    if (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                    {
                        Dictionary<char, string> translitTable =
                            new Dictionary<char, string>

                            {
                                {'Я',"А" },
                                {'Ю',"В" },
                                {'Э',"Б" },
                                {'Ь',"Г" },
                                {'Ы',"Д" },
                                {'Ъ',"Е" },
                                {'Щ',"Ё" },
                                {'Ш',"Ж" },
                                {'Ч',"З" },
                                {'Ц',"И" },
                                {'Х',"Й" },
                                {'Ф',"К" },
                                {'У',"Л" },
                                {'Т',"М" },
                                {'С',"Н" },
                                {'Р',"О" },
                                {'П',"П" },
                                {'О',"Р" },
                                {'Н',"С" },
                                {'М',"Т" },
                                {'Л',"У" },
                                {'К',"Ф" },
                                {'Й',"Х" },
                                {'И',"Ц" },
                                {'З',"Ч" },
                                {'Ж',"Ш" },
                                {'Ё',"Щ" },
                                {'Е',"Ъ" },
                                {'Д',"Ы" },
                                {'Г',"Ь" },
                                {'В',"Э" },
                                {'Б',"Ю" },
                                {'А',"Я" },
                                {'я',"а" },
                                {'ю',"в" },
                                {'э',"б" },
                                {'ь',"г" },
                                {'ы',"д" },
                                {'ъ',"е" },
                                {'щ',"ё" },
                                {'ш',"ж" },
                                {'ч',"з" },
                                {'ц',"и" },
                                {'х',"й" },
                                {'ф',"к" },
                                {'у',"л" },
                                {'т',"м" },
                                {'с',"н" },
                                {'р',"о" },
                                {'п',"п" },
                                {'о',"р" },
                                {'н',"с" },
                                {'м',"т" },
                                {'л',"у" },
                                {'к',"ф" },
                                {'й',"х" },
                                {'и',"ц" },
                                {'з',"ч" },
                                {'ж',"ш" },
                                {'ё',"щ" },
                                {'е',"ъ" },
                                {'д',"ы" },
                                {'г',"ь" },
                                {'в',"э" },
                                {'б',"ю" },
                                {'а',"я" },

                                {'Z',"A" },
                                {'Y',"B" },
                                {'X',"C" },
                                {'W',"D" },
                                {'V',"E" },
                                {'U',"F" },
                                {'T',"G" },
                                {'S',"H" },
                                {'R',"I" },
                                {'Q',"J" },
                                {'P',"K" },
                                {'O',"L" },
                                {'N',"M" },
                                {'M',"N" },
                                {'L',"O" },
                                {'K',"P" },
                                {'J',"Q" },
                                {'I',"R" },
                                {'H',"S" },
                                {'G',"T" },
                                {'F',"U" },
                                {'E',"V" },
                                {'D',"W" },
                                {'C',"X" },
                                {'B',"Y" },
                                {'A',"Z" },
                                {'z',"a" },
                                {'y',"b" },
                                {'x',"c" },
                                {'w',"d" },
                                {'v',"e" },
                                {'u',"f" },
                                {'t',"g" },
                                {'s',"h" },
                                {'r',"i" },
                                {'q',"j" },
                                {'p',"k" },
                                {'o',"l" },
                                {'n',"m" },
                                {'m',"n" },
                                {'l',"o" },
                                {'k',"p" },
                                {'j',"q" },
                                {'i',"r" },
                                {'h',"s" },
                                {'g',"t" },
                                {'f',"u" },
                                {'e',"v" },
                                {'d',"w" },
                                {'c',"x" },
                                {'b',"y" },
                                {'a',"z" },






                            };
                        result += translitTable[c];
                    }
                    else

                    {
                        result += c;
                    }
                    TB4.Text = result;
                }
            }
        }
    }
}