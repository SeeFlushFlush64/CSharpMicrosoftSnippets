using System;
using Items;
namespace Sections
{
    public abstract class SectionBase
    {
        public abstract void OpeningPrompt();
        public abstract void ListOfMenu(IEnumerable<Item> itemList, int orderNumber);
        public abstract void ItemDescription(IEnumerable<Item> itemList, int orderNumber);
    }
}