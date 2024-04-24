using System.Net.Mime;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

namespace _Source._Core
{
    public class CardAsset
    {
        public static readonly Sprite CardFront =
            Resources.Load<Sprite>("from-the-game-textures-and-a-bit-of-my-bad-photoshop-skills-v0-5qgloz1kxz2a1");
        public static readonly Sprite CardBack = Resources.Load<Sprite>("43a56ed9097f3f42bf5c691ba20b0d2d");
        
        public string CardName;
        public Color CardColor;
        public Image CardImage;
    }
}
