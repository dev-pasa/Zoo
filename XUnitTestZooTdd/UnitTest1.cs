using System;
using Xunit;
using Zoo.Classes;
using Zoo;


namespace XUnitTestZooTdd
{
    public class UnitTest1
    {

        //Prove that the classes that implement the interface actually implement it
        //Prove inheritance
        //Prove Polymorphism
        //Prove methods have been overridden
        //Prove that one of your concrete animals is an Animal

        /// <summary>
        /// Polymorphism
        /// </summary>
        [Fact]
        public void TigerPolymorphism()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.Hunts() == "I hunt big animals by myself.");
        }

        /// <summary>
        /// Polymorphism
        /// </summary>
        [Fact]
        public void PythonPolymorphism()
        {
            Python python = new Python();
            Assert.True(python.Name == "The deadly python");
        }

        /// <summary>
        /// Polymorphism
        /// </summary>
        [Fact]
        public void LeopardPolymorphism()
        {
            Leopard leopard = new Leopard();
            Assert.True(leopard.Name == "The fast Leopard");
        }
  
        /// <summary>
        /// Proves inheritance
        /// </summary>
        [Fact]
        public void CatMammal()
        {
            Cats cat = new Tiger();
            Assert.True(cat is Mammal);
        }

        /// <summary>
        /// Proves inheritance
        /// </summary>
        [Fact]
        public void CrocMammal()
        {
            Crocodile croc = new Gharial();
            Assert.True(croc is Mammal);
        }

        /// <summary>
        /// Proves inheritance
        /// </summary>
        [Fact]
        public void TortoiseMammal()
        {
            Tortoise turtle = new Tortoise();
            Assert.True(turtle is Mammal);
        }

        /// <summary>
        /// Interface
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void TigerWaterHunt()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.HuntInWater() == "I am ok at hungting in water");
        }

        /// <summary>
        /// Interface
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void TigerEatInLand()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.haveToEatInLand == false);
        }

        /// <summary>
        /// Interface
        /// </summary>
        [Fact]
        public void CrocInterface()
        {
           Gharial gharial = new Gharial();
            Assert.True(gharial.HuntInWater()  == " I am great at hungting in water");
        }

        /// <summary>
        /// override cat sound
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void TigerSound()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.Sound() == "Roar!!!");
        }

        /// <summary>
        /// override cat sound
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void LionSound()
        {
            Lion lion = new Lion();
            Assert.True(lion.Sound() == "Big Roar!!");
        }

        /// <summary>
        /// Overridden method
        /// </summary>
        [Fact]
        public void PythonSound()
        {
            Assert.Equal("Hisss!!", Program.PythonSound());
        }

        /// <summary>
        /// Overridde virtual Sleep method
        /// </summary>
        [Fact]
        public void PythonSleep()
        {
            Python python = new Python();
            Assert.True(python.Sleep() =="sleep 5 hours");
        }
    }
}
