using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTest
{
    public class QuestionsList : List<Question>
    {
        public QuestionsList()
        {
            this.Add(new Question( 4, 0, 0, 0, 0, "Jest Ci trudno nawiązywać nowe znajomości."));
            this.Add(new Question(0, -4, 0, 0, 0, "Często się zamyślasz, odcinając się od otaczającego Cię świata."));
            this.Add(new Question(0, 0, 0, -6, 0, "Starasz się odpowiadać na emaile tak szybko jak to możliwe i nie znosisz bałaganu w skrzynce odbiorczej."));
            this.Add(new Question(0, 0, 0, 0, -6, "Niewielki stres nie zakłóca Twojej umiejętności relaksowania się i koncentracji."));
            this.Add(new Question(4, 0, 0, 0, 0, "Zazwyczaj nie zaczynasz rozmowy"));

            this.Add(new Question(0, 5, 0, 0, 0, "Rzadko robisz coś wyłącznie z ciekawości"));
            this.Add(new Question(0, 0, -6, 0, 0, "Czujesz się lepszy(a) od innych ludzi"));
            this.Add(new Question(0, 0, 0, -6, 0, "Bycie zorganizowanym(ą) jest dla Ciebie ważniejsze od bycia elastycznym(ą)"));
            this.Add(new Question(-6, 0, 0, 0, 0, "Zazwyczaj jesteś zmotywowany(a) i energiczny(a)"));
            this.Add(new Question(0, 0, 4, 0, 0, "Wygranie dyskusji ma dla Ciebie mniejsze znaczenie niż dobre samopoczucie"));

            this.Add(new Question(0, 0, 0, 0, 4, "Często czujesz przymus usprawiedliwiania się innym ludziom"));
            this.Add(new Question(0, 0, 0, -6, 0, "Twój dom i Twoje miejsce pracy są uporządkowane"));
            this.Add(new Question(-6, 0, 0, 0, 0, "Nie masz nic przeciwko byciu w centrum uwagi"));
            this.Add(new Question(0, 5, 0, 0, 0, "Uważasz, że jesteś bardziej praktyczny(a) niż kreatywny(a)"));
            this.Add(new Question(0, 0, 0, 0, -6, "Ludzie rzadko wyprowadzają Cię z równowagi"));

            this.Add(new Question(0, 0, 0, -6, 0, "Twoje plany podróży są zazwyczaj dobrze przemyślane"));
            this.Add(new Question(0, 0, -6, 0, 0, "Często masz problem ze zrozumieniem, co czują inni"));
            this.Add(new Question(0, 0, 0, 0, 4, "Twój nastrój zmienia się bardzo szybko"));
            this.Add(new Question(0, 0, -6, 0, 0, "W czasie dyskusji dotarcie do prawdy powinno być ważniejsze od ludzkich uczuć"));
            this.Add(new Question(0, 0, -6, 0, 0, "Rzadko martwisz się skutkami, jakie Twoje działania mają dla innych ludzi"));

            this.Add(new Question(0, 0, 0, 4, 0, "Twój styl pracy bardziej przypomina wybuchy energii niż metodyczny i zorganizowany proces"));
            this.Add(new Question(0, 0, 0, 0, 4, "Często zazdrościsz innym ludziom"));
            this.Add(new Question(4, 0, 0, 0, 0, "Ciekawa książka lub dobra gra są często lepsze niż spotkanie towarzyskie"));
            this.Add(new Question(0, 0, 0, -6, 0, "Najważniejszą częścią każdego projektu jest opracowanie planu i trzymanie się go"));
            this.Add(new Question(0, 5, 0, 0, 0, "Rzadko dajesz się ponieść fantazjom i ideom"));

            this.Add(new Question(0, -4, 0, 0, 0, "W czasie spacerów w przyrodzie często się zamyślasz"));
            this.Add(new Question(0, 0, 0, 0, 4, "Jeżeli ktoś nie odpowiada szybko na Twój mail, zaczynasz się martwić że powiedziałeś(aś) coś nie tak"));
            this.Add(new Question(0, 0, 4, 0, 0, "Jako rodzic wolał(a)byś, żeby Twoje dziecko było mądre niż miłe"));
            this.Add(new Question(0, 0, 0, 0, -6, "Nie pozwalasz innym ludziom wpływać na Twoje działania"));
            this.Add(new Question(0, 5, 0, 0, 0, "Twoje marzenia koncentrują się na realnym świecie i wydarzeniach"));

            this.Add(new Question(-6, 0, 0, 0, 0, "Po przejściu do nowej pracy szybko angażujesz się w życie nowej społeczności"));
            this.Add(new Question(0, 0, 0, 4, 0, "Twoje działania to częściej natchniona improwizacja niż staranne planowanie"));
            this.Add(new Question(0, 0, 0, 0, 4, "Twoje emocje kontrolują Ciebie bardziej niż Ty je"));
            this.Add(new Question(-6, 0, 0, 0, 0, "Lubisz spotkania towarzyskie wymagające przebierania się lub odgrywania ról"));
            this.Add(new Question(0, -4, 0, 0, 0, "Spędzasz dużo czasu roztrząsając idee nierealistyczne i niepraktyczne, ale za to intrygujące"));

            this.Add(new Question(0, 0, 0, 4, 0, "Wolisz improwizować niż poświecić dużo czasu na szczegółowe planowanie"));
            this.Add(new Question(4, 0, 0, 0, 0, "Jesteś osobą raczej wycofaną i spokojną"));
            this.Add(new Question(0, 0, 4, 0, 0, "Gdybyś miał(a) własny biznes, nie czuł(a)byś lojalności wobec mało wydajnych pracowników"));
            this.Add(new Question(0, -4, 0, 0, 0, "Często zastanawiasz się nad sensem istnienia"));
            this.Add(new Question(0, 0, -6, 0, 0, "Podczas podejmowania ważnych decyzji logika jest dla Ciebie ważniejsza niż uczucia"));

            this.Add(new Question(0, 0, 0, 4, 0, "Możliwość swobodnego wyboru jest dla Ciebie ważniejsza niż lista zadań"));
            this.Add(new Question(0, 0, 4, 0, 0, "Jeżeli Twój przyjaciel lub przyjaciółka jest smutny(a), zaoferujesz mu/jej raczej wsparcie emocjonalne niż sugestie sposobów rozwiązania problemu"));
            this.Add(new Question(0, 0, 0, 0, -6, "Rzadko czujesz się niepewnie"));
            //this.Add(new Question( 0, 0, 0, -6, 0,"Nie masz problemu z przygotowaniem i przestrzeganiem własnego harmonogramu"));
            //this.Add(new Question( 0, 0, -6, 0, 0,"W przypadku pracy zespołowej wolisz mieć rację niż współpracować"));

            this.Add(new Question(0, 0, 4, 0, 0, "Myślisz, że należy szanować poglądy wszystkich osób, niezależnie czy opierają się na faktach czy nie"));
            this.Add(new Question(-6, 0, 0, 0, 0, "Masz więcej energii po spotkaniu w grupie ludzi"));
            this.Add(new Question(0, 0, 0, 4, 0, "Często gubisz różne rzeczy"));
            this.Add(new Question(0, 0, 0, 0, -6, "Uważasz się za osobę stabilną emocjonalnie"));
            this.Add(new Question(0, -4, 0, 0, 0, "Twój umysł jest pełen nowych pomysłów i planów"));

            this.Add(new Question(0, 5, 0, 0, 0, "Nie uważasz się za marzyciela(kę)"));
            this.Add(new Question(4, 0, 0, 0, 0, "Zazwyczaj stresuje Cię przemawianie przed tłumem ludzi"));
            this.Add(new Question(0, 5, 0, 0, 0, "Najczęściej polegasz na swoim doświadczeniu, nie na wyobraźni"));
            //this.Add(new Question( 0, 0, 0, 0, 4,"Za bardzo martwisz się tym, co myślą inni ludzie"));
            //this.Add(new Question( 4, 0, 0, 0, 0,"Jeżeli pokój jest wypełniony ludźmi, stoisz bliżej ściany, unikając jego środka"));

            //this.Add(new Question( 0, 0, 0, 4, 0,"Masz tendencję do zwlekania tak długo, aż zostanie za mało czasu"));
            //this.Add(new Question( 0, 0, 0, 0, 4,"W sytuacji stresującej czujesz niepokój."));
            //this.Add(new Question( 0, 0, 4, 0, 0,"Uważasz, że bardziej się opłaca być lubianym(ą) niż mieć władzę."));
            //this.Add(new Question( 0, -4, 0, 0, 0,"Zawsze interesowały CIę rzeczy niekonwencjonalne i niejednoznaczne, np. w książkach, w sztuce lub w filmach"));
            //this.Add(new Question( -6, 0, 0, 0, 0,"W sytuacjach towarzyskich często przejmujesz inicjatywę"));

        }
    }


    public class Question
    {

        public Question(double w1,double w2,double w3,double w4,double w5, string text)
        {
            var odp1 = "Zdecydowanie nie";
            var odp2 = "Raczej nie";
            var odp3 = "Nie wiem";
            var odp4 = "Raczej tak";
            var odp5 = "Zdecydowanie tak";
            Text = text;
            Answers = new List<Answer>()
                {
                    new Answer(odp1, w1*-1,w2*-1,w3*-1,w4*-1,w5*-1),
                    new Answer(odp2, w1*-1/2,w2*-1/2,w3*-1/2,w4*-1/2,w5*-1/2),
                    new Answer(odp3, 0,0,0,0,0),
                    new Answer(odp4, w1/2,w2/2,w3/2,w4/2,w5/2),
                    new Answer(odp5, w1,w2,w3,w4,w5),
                }; 
        }
        public int selected = -1;
        public string Text;
        public List<Answer> Answers;
    }

    public class Answer
    {
        public string Text;
        public double MindWeight,EnergyWeight,NatureWeight,TacticsWeight,IdentityWeight;
        public Answer(string text, double w1, double w2, double w3, double w4, double w5)
        {
            Text = text;
            MindWeight = w1;
            EnergyWeight = w2;
            NatureWeight = w3;
            TacticsWeight = w4;
            IdentityWeight = w5;
        }
    }
}


