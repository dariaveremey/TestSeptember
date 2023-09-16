using TMPro;
using UnityEngine;

namespace Game.Item
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private int _cost;

        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
    }
}
