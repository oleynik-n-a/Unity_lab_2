using UnityEngine;

namespace _Source._Core
{
    public class CardInstance : MonoBehaviour
    {
        private CardAsset _cardAsset;

        public CardInstance(CardAsset cardAsset)
        {
            _cardAsset = cardAsset;
        }
    }
}
