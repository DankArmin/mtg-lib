using mtg_lib.Library.Models;

namespace mtg_lib;
public class MTGService
{
        private PostgresContext db = new PostgresContext();

        public Card GetCardByID(long id) {
                return db.Cards.Where(c => c.Id == id).First();
        }

        public List<Card> GetAllCards() {
                return db.Cards.ToList();
        }

        //get the card by name or part of it
        public List<Card> GetCardByName(string name) {
                return db.Cards.Where(c => c.Name.Contains(name)).ToList();
        }

        public void PurchaseCard(string email, long cardId) {
               Order order = new Order(){
                       Email = email,
                       CardId = cardId,
               };

               db.Orders.Add(order);
               db.SaveChanges();
        }

        public List<Order> GetOrders(string email) {
                return db.Orders.Where(o => o.Email == email).ToList();
        }
}
