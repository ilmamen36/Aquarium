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
        private List<LiveInAqua> subscribers = new List<LiveInAqua>();
        private Random rnd = new Random();

        public void Add(LiveInAqua obj)
        {
            AllFish.Add(obj);
        }

        public void CreateFood(int x, int y)// е*учий корм создаётся по одной штучке. Исправить!
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

        public void FoodExist()
        {
                IsHungry();
                NotifyObserversFood();
        }

        public List<LiveInAqua> GetSubscribers()
        {
            return subscribers;
        }

        public void IsHungry()
        {
            foreach (LiveInAqua fish in AllFish.residents)
            {
                if ((fish is FishAdult || fish is FishChild) && fish.health < 51)
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
                subscribers.ElementAt(i).GoEat(something);                
            }
            RemoveObservers();
        }
    }
}
