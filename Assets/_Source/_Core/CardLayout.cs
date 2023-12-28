using UnityEngine;

namespace _Source._Core
{
    public class CardLayout : MonoBehaviour
    {
        public bool FaceUp;
        public int LayoutID;
        public Vector2 Offset;
    
        void Update()
        {
            foreach (CardInstance key in CardGame.Instance.GetCardsInLayout(LayoutID))
            {
                CardGame.Instance.Dict[key].transform.parent = transform;
                CardGame.Instance.Dict[key].transform.position = Offset + key.CardPosition * (new Vector2(1, 0));
                CardGame.Instance.Dict[key].transform.SetSiblingIndex(key.CardPosition);
            }
        }
    }
}
