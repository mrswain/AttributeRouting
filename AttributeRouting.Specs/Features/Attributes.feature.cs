// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Using Atributes to Define Routes")]
    public partial class UsingAtributesToDefineRoutesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Attributes.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Using Atributes to Define Routes", "", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I generate the routes defined in the subject controllers");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes for an action method")]
        public virtual void GeneratingRoutesForAnActionMethod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes for an action method", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When("I fetch the routes for the RestfulTest controller\'s Index action");
#line 8
 testRunner.Then("the route url is \"Resources\"");
#line 9
  testRunner.And("the default for \"controller\" is \"RestfulTest\"");
#line 10
  testRunner.And("the default for \"action\" is \"Index\"");
#line 11
  testRunner.And("the namespace is \"AttributeRouting.Specs.Subjects\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes with the restful http method attribute")]
        public virtual void GeneratingRoutesWithTheRestfulHttpMethodAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes with the restful http method attribute", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.When("I fetch the routes for the RestfulTest controller");
#line 15
 testRunner.Then("the route for Index is constrained to GET requests");
#line 16
  testRunner.And("the route for Create is constrained to POST requests");
#line 17
  testRunner.And("the route for Update is constrained to PUT requests");
#line 18
  testRunner.And("the route for Destroy is constrained to DELETE requests");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple routes for a single action")]
        public virtual void MultipleRoutesForASingleAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple routes for a single action", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.When("I fetch the routes for the Test controller\'s MultipleRoutes action");
#line 22
 testRunner.Then("3 routes should be found");
#line 23
  testRunner.And("the 1st route url is \"Test/Multiple\"");
#line 24
  testRunner.And("the 2nd route url is \"Test/Multiple/Routes\"");
#line 25
  testRunner.And("the 3rd route url is \"Test/Multiple/Routes/Again\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route defaults")]
        public virtual void RouteDefaults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route defaults", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.When("I fetch the routes for the Test controller\'s Default action");
#line 29
 testRunner.Then("the default for \"param1\" is \"mapleleaf\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Optional parameters specified with a url parameter token")]
        public virtual void OptionalParametersSpecifiedWithAUrlParameterToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Optional parameters specified with a url parameter token", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.When("I fetch the routes for the Test controller\'s OptionalParametersWithAToken action");
#line 33
 testRunner.Then("the route url is \"Test/Optionals/{p1}/{p2}/{p3}\"");
#line 34
  testRunner.And("the parameter p1 is optional");
#line 35
  testRunner.And("the parameter p2 is optional");
#line 36
  testRunner.And("the parameter p3 is optional");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Regex route constraints specified with an attribute")]
        public virtual void RegexRouteConstraintsSpecifiedWithAnAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Regex route constraints specified with an attribute", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.When("I fetch the routes for the Test controller\'s Constraint action");
#line 40
 testRunner.Then("the parameter \"cat\" is constrained by the pattern \"^(kitty|meow-meow|purrbot)$\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple routes with different defaults and constraints for a single action")]
        public virtual void MultipleRoutesWithDifferentDefaultsAndConstraintsForASingleAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple routes with different defaults and constraints for a single action", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.When("I fetch the routes for the Test controller\'s MultipleRoutesWithDefaultsAndConstra" +
                    "ints action");
#line 44
 testRunner.Then("the route named \"FirstDitty\" has a default for \"number\" of 666");
#line 45
  testRunner.And("the route named \"FirstDitty\" has a constraint on \"number\" of \"^\\d{4}$\"");
#line 46
  testRunner.And("the route named \"SecondDitty\" has a default for \"number\" of 777");
#line 47
  testRunner.And("the route named \"SecondDitty\" has a constraint on \"number\" of \"^\\d{1}$\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes with the RouteArea attribute")]
        public virtual void GeneratingRoutesWithTheRouteAreaAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes with the RouteArea attribute", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.When("I fetch the routes for the AreaTest controller\'s Index action");
#line 51
 testRunner.Then("the route url is \"Area/Test\"");
#line 52
  testRunner.And("the data token for \"area\" is \"Area\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes with the RouteArea attribute on actions that specify a duplicat" +
            "e area prefix")]
        public virtual void GeneratingRoutesWithTheRouteAreaAttributeOnActionsThatSpecifyADuplicateAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes with the RouteArea attribute on actions that specify a duplicat" +
                    "e area prefix", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.When("I fetch the routes for the AreaTest controller\'s DuplicateArea action");
#line 56
 testRunner.Then("the route url is \"Area/DuplicateArea\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating nested routes with the RoutePrefix attribute")]
        public virtual void GeneratingNestedRoutesWithTheRoutePrefixAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating nested routes with the RoutePrefix attribute", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
 testRunner.When("I fetch the routes for the NestedTest controller\'s Index action");
#line 60
 testRunner.Then("the route url is \"Parent/{parentId}/Child\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating nested routes with the RoutePrefix attribute on actions that specify a" +
            " duplicate prefix")]
        public virtual void GeneratingNestedRoutesWithTheRoutePrefixAttributeOnActionsThatSpecifyADuplicatePrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating nested routes with the RoutePrefix attribute on actions that specify a" +
                    " duplicate prefix", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.When("I fetch the routes for the NestedTest controller\'s DuplicateNest action");
#line 64
 testRunner.Then("the route url is \"Parent/{parentId}/DuplicateNest\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes with both the RouteArea and RoutePrefix attribute")]
        public virtual void GeneratingRoutesWithBothTheRouteAreaAndRoutePrefixAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes with both the RouteArea and RoutePrefix attribute", ((string[])(null)));
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.When("I fetch the routes for the NestedAreaTest controller\'s Index action");
#line 68
 testRunner.Then("the route url is \"Area/Parent/{parentId}/Child\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the IsAbsoluteUrl property of the RouteAttributes")]
        public virtual void GeneratingRoutesUsingTheIsAbsoluteUrlPropertyOfTheRouteAttributes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the IsAbsoluteUrl property of the RouteAttributes", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 71
 testRunner.When("I fetch the routes for the AbsoluteUrlTest controller\'s Index action");
#line 72
 testRunner.Then("the route url is \"Something/Else\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Specifying route precedence within a controller using the RouteAttribute Preceden" +
            "ce property")]
        public virtual void SpecifyingRoutePrecedenceWithinAControllerUsingTheRouteAttributePrecedenceProperty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Specifying route precedence within a controller using the RouteAttribute Preceden" +
                    "ce property", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
 testRunner.When("I fetch the routes for the ActionOrderTest controller");
#line 76
 testRunner.Then("the 1st route url is \"Route1\"");
#line 77
  testRunner.And("the 2nd route url is \"Route2\"");
#line 78
  testRunner.And("the 3rd route url is \"Route3\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
