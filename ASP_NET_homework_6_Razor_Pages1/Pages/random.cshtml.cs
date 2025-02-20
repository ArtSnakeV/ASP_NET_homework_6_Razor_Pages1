using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_homework_6_Razor_Pages1.Pages
{
    public class randomModel : PageModel
    {
        // Creating own class for Dishes
        public class Dish
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }

        // Creating list of Dishes
        public List<Dish> Dishes { get; set; }

        public void OnGet()
        {
            // Initializing list of dishes
            // Initialize the dishes list and add some sample dishes
            Dishes = new List<Dish>
            {
                new Dish { Name = "Squab", Description = "As the saying goes, the early bird gets the squab. The whole squab, head and feet still attached, gets marinated, smoked, and then deep-fried to order, a multi-day process that results in rosy, succulent meat with a glistening, burnished skin. Chopsticks are ineffective; you will need to use your hands. Get in there and be the bird you know you are.", Price = 15.99m },
                new Dish { Name = "Ham & Cheese", Description = "A toasted sandwich with ham and Gruyère, stacked high in a pool of béchamel that’s served not on a plate but a sizzle platter — a spellbinding excess that just borders on the indecent. But then the classic French omelet with hollandaise comes out, and all bets are off.", Price = 18.00m },
                new Dish { Name = "Tuna Sashimi Tasting", Description = "It might include different cuts from the same fish, and possibly a seared version. Taste the metaphorical rainbow, if it were made of sustainably caught tuna from the northern Atlantic.", Price = 115.00m },
                new Dish { Name = "Roast Duck at Burdell", Description = "The preparation for the aged and roasted Sonoma duck, one of the mainstays of the menu, changes with the seasons, and a recent version involved cherries alongside duck drippings, as well as an impossibly delicious dirty rice studded with braised duck leg meat and duck offal.", Price = 31.00m },
                new Dish { Name = "Boudin Boy", Description = "The Boudin Boy — essentially a sausage and egg roll meets a Cajun Hot Pocket meets French viennoiserie — is a dizzying work of art. You will find soft-boiled eggs, ensconced inside super flaky laminated croissant dough, resulting in that whole crispy exterior and warm, savory interior interplay. Served alongside chili crisp for dipping, it’s a thrilling marriage of a bunch of cultures colliding, which is about as Restaurant as it gets.", Price = 25.00m },
                new Dish { Name = " Smashburger", Description = "Just when you think you’ve seen it all with smashburgers, leave it to our Chef - to come up with a genuine, new take. In this marvel of an umami bomb, Chef makes the caramelized smashed patty out of an aromatic and savory homemade pork sausage, topping it with rice-fermented pickles and a jeow bong-aioli slaw. He winds it all together with bacon and cheese, and it’s absolutely bursting with flavors, all at the same time.", Price = 88.70m },
                new Dish { Name = "Wisco Fried Cheese Curds", Description = "Comfort food classics like fried chicken and root beer floats are a serious affair at our Restaurant. Even the coleslaw here is seriously good. Primed in buttermilk, tossed in the fried chicken dredge, and then deep-fried, the local cheese curds are sheathed in an otherworldly, gnarled outer shell. Essentially chicken-fried cheese curds (just, uh, without the chicken), they gloriously crackle, making all other cheese curds seethe with jealousy.", Price = 199.00m },
                new Dish { Name = "HCaviar", Description = "One of the most joyously brilliant ways to eat caviar is on top of a working class hashbrown. Topped with chives and an umami-heavy anchovy crème fraîche, it’s a spectacular achievement in the genre of the fancy hashbrown, for which there sadly is no award (but there should be).", Price = 85.00m },
                new Dish { Name = "Pizza", Description = "The wood-fired “neo-mochito” pizza - sporting a bulbous, nearly sweet crust with a springy, chewy texture that’s reminiscent of mochi but notably without the traditional sourdough tang — is unlike anything else out there. Surprise, delight, and the potential future of pizza.", Price = 100.00m },
            };
        }
    }
}
