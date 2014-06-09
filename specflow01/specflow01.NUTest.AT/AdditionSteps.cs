using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using specflow01;
using NUnit.Framework;

namespace specflow01.NUTest.AT
{
    [Binding]
    public class AdditionSteps
    {
        Calculator Calc { get; set; }
        int Result { get; set; }

        public AdditionSteps() 
        {
            Calc = new Calculator();
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            Calc.Push(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            Result = Calc.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //ScenarioContext.Current.Pending();
            Assert.AreEqual(result, Result);
        }

        [Given(@"I enter first number (.*)")]
        public void GivenIEnterFirstNumber(int p0)
        {
            Calc.Push(p0);
        }

        [Given(@"I enter second number (.*)")]
        public void GivenIEnterSecondNumber(int p0)
        {
            Calc.Push(p0);
        }

        [Given(@"I enter third number (.*)")]
        public void GivenIEnterThirdNumber(int p0)
        {
            Calc.Push(p0);
        }

    }
}
