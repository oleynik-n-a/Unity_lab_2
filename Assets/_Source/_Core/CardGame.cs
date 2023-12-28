using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

namespace _Source._Core
{
    public class CardGame : MonoBehaviour
    {
        private Dictionary<CardInstance, CardView> _dict;
        private static CardGame _instance;
        public GameObject Prefab;
        public List<CardAsset> StartCardAssets;

        CardGame()
        {
            _dict = new Dictionary<CardInstance, CardView>();
        }

        public static CardGame Instance
        {
            get
            {
                if (_instance == null)
                    return new CardGame();

                return _instance;
            }
            private set { _instance = value; }
        }
        
        private void Awake() 
        {
            if (Instance != null && Instance != this) 
            { 
                Destroy(this); 
            } 
            else 
            { 
                Instance = this; 
            } 
        }
        
        public void StartGame()
        {
            foreach (var cardAsset in StartCardAssets)
            {
                CardInstance cardInstance = new CardInstance(cardAsset);
            }
            {
                
            }
        }

        private void CreateCardView(CardInstance instance)
        {
            GameObject obj = Instantiate(Prefab);
            _dict[instance] = obj.GetComponent<CardView>();
            _dict[instance].Init(instance);
        }

        private void CreateCard(CardAsset asset, int layout)
        {
            CardInstance cardInstance = new CardInstance(asset);
            CreateCardView(cardInstance);
            cardInstance.MoveToLayout(layout);
        }
    }
}
