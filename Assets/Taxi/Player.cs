﻿using System.Data.SqlTypes;
using UnityEngine;

namespace Taxi
{
    public class Player : MonoBehaviour
    {
        public int Money = 100;
        public string Id = "Red";

        public void EarnMoney(int money)
        {
            Money += money;
        }

        public Color GetColor()
        {
            if (Id.Equals("1"))
            {
                return Color.red;
            }

            if (Id.Equals("2"))
            {
                return Color.blue;
            }

            if (Id.Equals("3"))
            {
                return Color.green;
            }

            if (Id.Equals("4"))
            {
                return Color.yellow;
            }

            return Color.black;

        }
    }
}