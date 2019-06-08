using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BootStrap.Pages
{
    public class IndexModel : PageModel
    {
        public string title_slide_1 {get;set;}
        public string title_slide_2 {get;set;}
        public string title_slide_3 {get;set;}
        public string title_slide_4 {get;set;}
        public string title_slide_5 {get;set;}
        public string title_slide_6 {get;set;}
        
        public List<string> photo_content = new List<string>(){
            "Bootstrap is the most popular HTML, CSS, and JS framework for developing responsive, mobile-first projects on the web"
        };
        public List<string> content_slide_1 = new List<string>() {
           "Zmeura, rujul natural dat de natura femeilor este si astazi considerat un produs ce aduce un impuls de pasiune in viata noastra. Coloritul fructului de un rosu intens pe langa ca ne poate aduce un deliciu conversational alaturi de cei apropiati noua, ne aduce si un aport ridicat de sustante antioxidante si nutrienti ce ne vor ajuta organismul sa fie puternic.",
           "Fie ca incercam sa avem un stil de viata sanatos sau pur si simplu dorim sa ne bucuram de gustul dulce si aroma puternica a unui desert,zemura este alegera ideala. Zemurul fiind o planta adaptata la conditiile variate si dificile date de mediul salbatic, reuseste sa absoarba din solul cele mai importante substante nutritive necesare noua.Si in cele din urma,sa ne aducem aminte ca ursul, cel mai temut si respectat animal din Tara noastra iubeste acest desert dat de natura."
        };

        public List<string> content_slide_2 = new List<string>(){
            "In timpul anilor de studentie petrecuti in viata de oras mare, ne-au facut sa apreicem dinamismul si calitatea oameniilor noi cunoscuti dar, ne-a invatat ca avem o responsabilitate fata de oamenii din jurul nostru sa ii ajutam sa isi indeplineasca visul asa cum si noi suntem in desfasurarea lui. Chiar daca posibilitatea de a oferi lumii servicii este nemarginita, noi am vazut ca de cele mai multe ori lucrurile simple sunt cele care trezesc cu adevart zambete si bucurii in jurul nostru...asa ca am pornit in cautarea acelui lucru.",
            "Ori de cate ori ne reintorceam acasa la parintii si bunicii nostri, bunica ne intampina cu o multime de bunataturi proaspete facute sau culese de dansa. Zmeura proaspat culeasa din gradina isi avea locul de cinste pe masa intinsa de bunica. Cu timpul am observat ca in discutiile cu prietenii nostri despre mancare si deserturi, ne imaginam gustul si aroma zemurei din gradina bunicii. Ajusesem s-o indragim foarte mult si sa dorim sa oferim tuturor oamenilor accesul la acest produs minunat. Odata ce terminasem studiile la facultate, am decis sa ne intoarcem acasa si sa punem in aplicare cunostiintele dobandite in dezvoltarea acestui produs cu atatea beneficii. Gradina bunicii trebuia sa se mareasca!!!"
        };
     
         public List<string> content_slide_3 = new List<string>(){
            "Bootstrap is the most popular HTML, CSS, and JS framework for developing responsive, mobile-first projects on the web",
             "Bootstrap is the most popular HTML, CSS, and JS framework for developing responsive, mobile-first projects on the web"   
        
        };

        public List<string> content_slide_4 = new List<string>(){
            "Bootstrap is the most popular HTML, CSS, and JS framework for developing responsive, mobile-first projects on the web"
        };
        public List<string> content_slide_5 = new List<string>(){};

       

        public void OnGet()
        {
            
            title_slide_1 = "Zmeura - Fructul ce trezeste creativitatea";
            title_slide_2 = "Zmeura din gradina bunicilor nostri se intoarce acasa";
            title_slide_3 = "DESPRE CUM ESTE CULTIVATA";
            title_slide_4 = "DESPRE AVANTAJELE ZMEUREI DIN DEVA";
            title_slide_5 = "Locatie";
          

            ViewData["title_slide_1"] = title_slide_1;
            ViewData["content_slide_1"] = content_slide_1;
            
            ViewData["title_slide_2"] = title_slide_2;
            ViewData["content_slide_2"] = content_slide_2;

            ViewData["title_slide_3"] = title_slide_3;
            ViewData["content_slide_3"] = content_slide_3;

            ViewData["title_slide_4"] = title_slide_4;
            ViewData["content_slide_4"] = content_slide_4;

            ViewData["title_slide_5"] = title_slide_5;
            ViewData["content_slide_5"] = content_slide_5;

        
        }
    }
}
