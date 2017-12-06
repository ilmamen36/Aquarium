using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aquarium 
    {
        public ListOfAquaPeople AllFish { get; private set; } = new ListOfAquaPeople();
        public Objects something = new Objects();
        bool light = true;
        private List<LiveInAqua> subscribers = new List<LiveInAqua>();
        //private List<LiveInAqua> sexSub = new List<LiveInAqua>();
        List<sexSub> sexSubscribers = new List<sexSub>();
        public float Temperature { get; set; } = 20;
        private Random rnd = new Random();

        public Aquarium()
        {
            something.Trees.Add(new Objects.WaterWood(1332, 680));
            something.Trees.Add(new Objects.WaterWood(352, 683));
        }

        public void SetLight(bool lght)
        {
            light = lght;
        }

        public void Add(LiveInAqua obj)
        {
            AllFish.Add(obj);
        }

        public void CreateFood(int x, int y)
        {
            for (int i = 0; i < rnd.Next(1, 5); i++)
                something.Korm.Add(new Objects.Food(x, y));             
        }

        public void FallFood()
        {
            foreach (Objects.Food foo in something.Korm)
                foo.Sink();
        }

        public void RemoveFood()
        {
            for (int i = 0; i < something.Korm.Count(); i++)
            {
                if (something.Korm[i].Y >= 650)
                {
                    something.Korm.RemoveAt(i);
                }
            }
        }

        public void GrowWaterWood()
        {
            if (Temperature >= 21 && light)
            {
                int[] rn1 = new int[2] { 1332, 680 };
                int[] rn2 = new int[2] { 352, 683 };

                if (something.Trees.Count == 0)
                {
                    int ran = rnd.Next(0, 2);
                    if (ran == 1)
                        something.Trees.Add(new Objects.WaterWood(rn1[0], rn1[1]));
                    else
                        something.Trees.Add(new Objects.WaterWood(rn2[0], rn2[1]));
                }
                else
                {
                    if (something.Trees.Count == 1)
                    {
                        if (something.Trees[0].X == rn1[0])
                            something.Trees.Add(new Objects.WaterWood(rn2[0], rn2[1]));
                        else
                            something.Trees.Add(new Objects.WaterWood(rn1[0], rn1[1]));
                    }
                }
            }
        }
        //public void GrowWaterWood()
        //{
        //    if (Temperature >= 21 && AllFish.draw.Light)
        //    {
        //        int ran = rnd.Next(0, 2);
        //        if (something.Trees[ran].height.Count <= 10)
        //            something.Trees[ran].Grow();
        //    }
        //}

        public void RemoveWaterWood()
        {

        }

        public void NormConditions()
        {
            switch (sexSubscribers.Count)
            {
                case 0:
                    for (int i = 0; i < AllFish.residents.Count(); i++)
                    {
                        if (sexSubscribers.Count() < 3)
                        {
                            if (AllFish.residents[i].health > 65 && AllFish.residents[i] is FishAdult)
                            {
                                sexSubscribers.Add((AllFish.residents[i] as FishAdult));
                            }
                        }
                    }
                    break;
                case 1:
                    RemoveObservers();
                    break;
                case 2:
                    // sexSub[0].GoSex();
                    // sexSub[0].GoSex();
                    break;
            }
        }

        public void FoodExist()
        {
                IsHungry();
                NotifyObserversFood();
        }

        //public List<LiveInAqua> GetSubscribers()
        //{
        //    return subscribers;
        //}

        public void IsHungry()
        {
            foreach (LiveInAqua fish in AllFish.residents)
            {
                if (fish.health < 51)
                    subscribers.Add(fish);
            }
        }

        public void RemoveObservers()
        {
            subscribers = new List<LiveInAqua>(); 
        }

        public void NotifyObserversFood()
        {
            for (int i = 0; i < subscribers.Count(); i++)
            {
                if (something.Korm.Count == 0 && (subscribers.ElementAt(i) is FishAdult || subscribers.ElementAt(i) is FishChild))
                    continue;
                subscribers.ElementAt(i).GoEat(something);                
            }
            RemoveObservers();
        }
    }
}
