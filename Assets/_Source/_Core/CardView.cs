using UnityEngine;

namespace _Source._Core
{
    public class CardView : MonoBehaviour
    {
        private CardInstance _cardInstance;

        public void Init(CardInstance cardInstance)
        {
            _cardInstance = cardInstance;
        }
        
        public void Init(string cname, Color color, Sprite image)
        {
            _cardInstance.CardAsset.CardName = cname;
            _cardInstance.CardAsset.CardColor = color;
            _cardInstance.CardAsset.CardImage.sprite = image;
        }

        public void Rotate(bool faceUp)
        {
            _cardInstance.CardAsset.CardImage.sprite = faceUp ? CardAsset.CardFront : CardAsset.CardBack;
        }
    }
}
