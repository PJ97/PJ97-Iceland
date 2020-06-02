using System;

namespace ConsoleApp1.Classes {
    public class Item {
        #region Properties
        protected string _name;
        protected int _sellin;
        protected int _quality;
        protected bool _valid;

        public string Display => $"Name: {_name} SellIn: {_sellin} Quality: {_quality}" + (IsValid ? String.Empty : "[Invalid]");

        public string Name => _name;

        /// <summary>
        /// Denotes the number of days to sell the item.
        /// </summary>
        public int SellIn => _sellin;

        /// <summary>
        /// Denotes how valuable the item is.
        /// </summary>
        public int Quality => _quality;

        /// <summary>
        /// Denotes if the item has passed the number of days set to sell it by.
        /// </summary>
        public bool IsPastSellby => _sellin < 0;

        /// <summary>
        /// Denotes if the item is valid for display.
        /// </summary>
        public bool IsValid => _quality >= 0 && _quality <= 50;
        #endregion

        public Item(string name, int sellIn, int quality) {
            _name = name;
            _sellin = sellIn;
            _quality = quality;
        }
    }
}
