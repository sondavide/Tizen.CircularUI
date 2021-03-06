using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture, Order(1)]
    public class ListView : TestTemplate
    {
        static string NoFishEyeHeaderTestName = "NoFishEyeHeaderList";
        static string CircleListBehaviorTestName = "CircleListBehavior";
        static string GroupListTestName = "GroupList";
        static string CircleListViewTestName = "CircleListView";
        static string ViewCellTestName = "ViewCell";
        static string HeaderWithGroupTestName = "HeaderWithGroup";
        static string HeaderWithoutGroupTestName = "HeaderWithoutGroup";
        static string ChangeBarColorTestName = "ChangeBarColor";

        [Test]
        public void NoFishEyeHeaderTest()
        {
            Driver.FindTC(NoFishEyeHeaderTestName);

#if WATCH_DEVICE
            System.Threading.Thread.Sleep(3000);
            var image = "CircleListView_NoFishEyeHeaderTest.png";
            Driver.CheckScreenshot(image);
#else
            Driver.Flick(0, SpeedY * 2);
            Driver.Flick(0, SpeedY * 2);
#endif
        }

        [Test]
        public void CircleListBehaviorTest()
        {
            Driver.FindTC(CircleListBehaviorTestName);

            Driver.Click(30, 180);
            Driver.Flick(0, SpeedY * 2, 3000);

            var text = Driver.GetText("TestItem4");
            Assert.AreEqual(text, "TestItem4");

            Driver.Click(350, 180);
            Driver.Click(350, 180);

            var text2 = Driver.GetText("TestItem3");
            Assert.AreNotEqual(text2, "TestItem3");
        }

        [Test]
        public void GroupListTest()
        {
            Driver.FindTC(GroupListTestName);

#if WATCH_DEVICE
            System.Threading.Thread.Sleep(3000);
            var image = "CircleListView_GroupListTest.png";
            Driver.CheckScreenshot(image);
#else
            Driver.Flick(0, SpeedY * 2);
            Driver.Flick(0, SpeedY * 2);
#endif
        }

        [Test]
        public void CircleListViewTest()
        {
            Driver.FindTC(CircleListViewTestName);

#if WATCH_DEVICE
            System.Threading.Thread.Sleep(3000);
            var image = "CircleListView.png";
            Driver.CheckScreenshot(image);
#else
            Driver.Flick(0, SpeedY * 2);
            Driver.Flick(0, SpeedY * 2);
#endif
        }


        [Test]
        public void ViewCellTest()
        {
            Driver.FindTC(ViewCellTestName);

#if WATCH_DEVICE
            System.Threading.Thread.Sleep(3000);
            var image = "CircleListView_ViewCell.png";
            Driver.CheckScreenshot(image);
#else
            Driver.Flick(0, SpeedY * 2);
            Driver.Flick(0, SpeedY * 2);
#endif
        }

        [Test]
        public void HeaderWithGroupTest()
        {
            Driver.FindTC(HeaderWithGroupTestName);

#if WATCH_DEVICE
            System.Threading.Thread.Sleep(3000);
            var image = "CircleListView_HeaderWithGroup.png";
            Driver.CheckScreenshot(image);
#else
            Driver.Flick(0, SpeedY * 2);
            Driver.Flick(0, SpeedY * 2);
#endif
        }

        [Test]
        public void HeaderWithoutGroupTest()
        {
            Driver.FindTC(HeaderWithoutGroupTestName);

#if WATCH_DEVICE
            System.Threading.Thread.Sleep(3000);
            var image = "CircleListView_HeaderWithoutGroup.png";
            Driver.CheckScreenshot(image);
#else
            Driver.Flick(0, SpeedY * 2);
            Driver.Flick(0, SpeedY * 2);
#endif
        }

        [Test]
        public void ChangeBarColorTest()
        {
            Driver.FindTC(ChangeBarColorTestName);
            var listId = "list";

            var result = Driver.GetAttribute<string>(listId, "BarColor");
            var expect = "[Color: A=1, R=1, G=0, B=0, Hue=1, Saturation=1, Luminosity=0.5]";
            Assert.AreEqual(expect, result);

        }
    }
}
