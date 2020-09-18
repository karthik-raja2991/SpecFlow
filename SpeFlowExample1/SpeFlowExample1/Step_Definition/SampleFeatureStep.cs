using SpeFlowExample1.Step_Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpeFlowExample1
{
    [Binding]
    class SampleFeatureStep
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [Given(@"the third number is (.*)")]
        public void GivenTheThirdNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number2)
        {
            Console.WriteLine(number2);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("The Add Button is pressed");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            if (result == 121)
            {
                Console.WriteLine("Test PASSED");
            }
            else 
            {
                Console.WriteLine("Test FAILED");
                throw new Exception("The values are different");
            }
        }
        [When(@"I fill all mandatory detaisl in form")]
        public void WhenIFillAllMandatoryDetaislInForm(Table table)
        {
            var empDetails = table.CreateSet<EmployeeDetails>();

            foreach (EmployeeDetails emp in empDetails) 
            {
                Console.WriteLine("The details of the Employee is :" + emp.name);
                Console.WriteLine("**************************");
                Console.WriteLine(emp.name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.phone);
                Console.WriteLine(emp.Email);
            }
        }
        [When(@"I fill all mandatory detaisl in form (.*), (.*) and (.*)")]
        public void WhenIFillAllMandatoryDetaislInFormKarthikAnd(string name, int age, Int64 Phone)
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("Phone" + Phone);

            ScenarioContext.Current["Step1Result"] = "Step1 Passed";
            Console.WriteLine(ScenarioContext.Current["Step1Result"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    name="karthik",
                    Age=12,
                    phone=7975208680
                },
                new EmployeeDetails()
                {
                    name="Siva",
                    Age=13,
                    phone=7975208681
                },
                new EmployeeDetails()
                {
                    name="shankar",
                    Age=45,
                    phone=568897412
                }
            };
            //save the value in context
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //Get the value from scenario context
            var EMPlist= ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");
            foreach (EmployeeDetails emp in EMPlist) 
            {
                Console.WriteLine("The Employee name is" + emp.name);
                Console.WriteLine("The Employee age is" + emp.Age);
                Console.WriteLine("The Emloyee phone is" + emp.phone);
            }
         
            Console.WriteLine("The sessoin info details are" + ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("The sessoin info details are" + ScenarioContext.Current.Count);
        }



    }
}
