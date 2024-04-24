using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

namespace _Source._Core
{
    public class CardGame : MonoBehaviour
    {
        private static CardGame _instance;
        public Dictionary<CardInstance, CardView> Dict;
        public GameObject Prefab;
        public List<CardAsset> StartCardAssets;

        CardGame()
        {
            Dict = new Dictionary<CardInstance, CardView>();
        }

        public static CardGame Instance { get; private set; }
        
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
            foreach (var instance in StartCardAssets)
            {
                CreateCard(instance, 0);
            }
        }

        private void CreateCardView(CardInstance instance)
        {
            GameObject obj = Instantiate(Prefab);
            Dict[instance] = obj.GetComponent<CardView>();
            Dict[instance].Init(instance);
        }

        private void CreateCard(CardAsset asset, int layout)
        {
            CardInstance cardInstance = new CardInstance(asset);
            CreateCardView(cardInstance);
            cardInstance.MoveToLayout(layout);
        }

        public List<CardInstance> GetCardsInLayout(int layoutID)
        {
            List<CardInstance> instances = new List<CardInstance>();
            foreach (var instance in Instance.Dict.Keys) 
            {
                if (instance.LayoutId == layoutID)
                {
                    instances.Add(instance);
                }
            }

            return instances;
        } 
    }
}
