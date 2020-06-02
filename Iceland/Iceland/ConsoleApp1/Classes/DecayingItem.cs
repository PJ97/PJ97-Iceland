using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {
    public class DecayingItem : Item, IAgingItem {
        #region Properties
        private int _rateofdecay;
        private bool _frozen;

        /// <summary>
        /// The rate in which quality will decay over a set of conditions.
        /// </summary>
        public int RateOfDecay => IsPastSellby ? _rateofdecay * 2 : _rateofdecay;
        #endregion

        public DecayingItem(string name, int sellIn, int quality, bool isFrozen) : base(name, sellIn, quality) {
            _frozen = isFrozen;
            _rateofdecay = _frozen ? 1 : 2;
        }

        public void AgeItem() {
            _sellin--;
            _quality -= RateOfDecay;
        }
    }
}
