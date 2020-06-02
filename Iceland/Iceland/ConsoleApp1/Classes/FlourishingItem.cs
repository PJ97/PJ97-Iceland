using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {
    public class FlourishingItem : Item, IAgingItem {
        private bool _christmasitem;
        /// <summary>
        /// The rate in which quality will flourish over a set of conditions.
        /// </summary>
        public int RateOfFlourishment {
            get {
                if (_christmasitem) {
                    if (SellIn > 5 && SellIn <= 10) return 2;
                    else if (SellIn > 0 && SellIn <= 5) return 3;
                    else return _quality * -1;
                } else return 1;
            }
        }

        public FlourishingItem(string name, int sellIn, int quality, bool christmasItem = false) : base(name, sellIn, quality) {
            _christmasitem = christmasItem;
        }

        public void AgeItem() {
            _sellin--;
            _quality += RateOfFlourishment;
        }
    }
}
