using System;
using UnityEngine;

namespace _Source._Core
{
    public class CardInstance
    {
        public CardAsset CardAsset;
        public int LayoutId;
        public int CardPosition;

        public CardInstance(CardAsset cardAsset)
        {
            CardAsset = cardAsset;
        }

        public void MoveToLayout(int layoutID)
        {
            LayoutId = layoutID;
            throw new NotImplementedException();
        }
    }
}
