using System;
using TMPro;
using UnityEngine;

namespace Game.Item
{
    public class CostValue:MonoBehaviour
    {
        [SerializeField] private Game.Item.Item _item;
        [SerializeField] private TextMeshProUGUI _costLabel;

        private void Start()
        {
            //_costLabel = $"{Convert.ToString(_item.Cost)}";
        }
    }
}