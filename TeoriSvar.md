# Svarsförslag teorifrågor

1. Applicera Dependency Injection Pattern och skicka in Engine och Battery via konstruktor eller property set method.
   Gör att vi kan skicka in ett speciellt testobjekt eller mock objekt vid testning.
   För att tillåta olika implementationer av objekten som skickas in byts typen till ett interface som sedan implementeras av de olika implementationerna.


    public class Car
    {
        private IEngine engine;
        private IBattery bt;

        public Car(IEngine e, IBattery b)
        {s
            engine = e;
            bt = b;
        }
    }

2.  * Skriv test för en viss funktionalitet, testet ska misslyckas. (red)
    * Implementera kod så att testet lyckas. (green)
    * Inspektera koden så den är bra (refactor) och testet verifierar nu att allt fungerar fortfarande. (green)
    * Börja om från början

3. Restful = En implementation som uppfyller ett antal krav så som: Client-Server, Stateless, Cachable..
   RestfulApi = Åtkomst via URI, HTTP verb (GET,POST,PUT,DELETE), Json output eller andra mediatyper XML,images.

4. Create, Read, Update, Delete

5. Vi kan som programmerare skapa klasser och relationer mellan dessa i ex C#. Sen skapas databas med tabeller och kolumner från koden automatiskt.

6. Ett simulerat objekt som efterliknar ett annat objekt. Används vid testning.
   Många svarade fejkat objekt vilket är ett samlingsnamn på mock, stub eller proxy objekt.

7. ViewModelen innehåller data som vi vill visa i en speciell vy. Har ingen annan funktion än att tillhandahålla data till vyn medans en modelklass är en representation av datamodellen (databas).
   Data i ViewModelen kan vara förbehandlad så att tex Namn och adress som i Model är separata fält slagits ihop till ett enda fält då det ska visas så i vyn.

8. Authentication är när man säkerställer identiteten på någon. Inloggning verifierar vem användaren är genom att begära tex användarnamn och lösenord.

9. Authorization är när man ger en viss individ eller grupp rättigheter att utföra en uppgift.

10. Man talar om för applikationen vilket språk den ska använda sig av och hur den ska formatera saker som datum, tid och valuta.

11. Genom att skicka med HTTP-headern Accept-Language och där ange önskat språk.

12. Om man har en webbsida öppen i en flik i webbläsaren och sen öppnar en flik till kommer de få samma session.
    Kan ställa till problem i vissa situationer om man tex är inloggad som olika användare som förlitar sig på session för att hålla ordning på vem man är.
    Stora mängder data bör inte sparas då det binder upp minne på servern.
    Frångår designprincipen för internet som stateless. Låt istället klienten tillhandahålla den information som krävs istället för att låta servern spara det.

13. En förkortning av Model-View-Controller som är ett designmönster.
    Model - Domänspecifik beskrivning av data.
    View - Renderar gränssnitt där data (model) presenteras och input hämtas.
    Controller - Hanterar händelser och modifierar model datan. Väljer View och tillhandahåller rätt modell till vyn. 

14. En singlepage applikation laddar inte om sidan för att hämta ny data. Istället använder man javascript för att i bakgrunden göra begärningar mot en server
    via tex ett WebApi. Svaret renderas sen på sidan genom att med javascript uppdatera DOMen.
    Hade begäran istället skickats som en vanlig begäran från webbläsaren hade servern fått generera en ny sida och skickat tillbaka den för visning.

15. Internationalisation är när man anpassar en applikation för att kunna hantera flera språk och lokaler.
    Localisation är när man sen implementerar stöd för ett visst språk. (Översättning)

16. Den enhet vi testar för tillfället. En metod på en klass. Den bör testas så den är isolerad från övriga beroenden.

17. TestMethod()
    {
        //Arrange
        Cat c = new Cat("Sessan");
        //Act
        string name = c.Name();
        //Assert
        Assert.AreEqual("Sessan",name);
    }

18. XML

