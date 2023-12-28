using System;
using UnityEngine;

namespace _Source._Core
{
    public class CardInstance
    {
        private CardAsset _cardAsset;

        public int LayoutId;
        public int CardPosition;

        public CardInstance(CardAsset cardAsset)
        {
            _cardAsset = cardAsset;
        }

        public void MoveToLayout(int layoutID)
        {
            LayoutId = layoutID;
            throw new NotImplementedException();
        }
    }
}
