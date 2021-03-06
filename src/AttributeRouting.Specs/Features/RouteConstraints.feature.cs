﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18034
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Constraints")]
    public partial class RouteConstraintsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RouteConstraints.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Constraints", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inline constraints")]
        [NUnit.Framework.TestCaseAttribute("Alpha", "AlphaRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Int", "IntRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Long", "LongRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Float", "FloatRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Double", "DoubleRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Decimal", "DecimalRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Bool", "BoolRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Guid", "GuidRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("DateTime", "DateTimeRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Length", "LengthRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("MinLength", "MinLengthRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("MaxLength", "MaxLengthRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("LengthRange", "LengthRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Min", "MinRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Max", "MaxRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Range", "RangeRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Regex", "RegexRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("RegexRange", "RegexRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Compound", "IntRouteConstraint", null)]
        [NUnit.Framework.TestCaseAttribute("Compound", "MaxRouteConstraint", null)]
        public virtual void InlineConstraints(string actionName, string constraintTypeName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inline constraints", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("I fetch the routes for the InlineRouteConstraints controller\'s {0} action", actionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then(string.Format("the route url is \"Inline-Constraints/{0}/{{x}}\"", actionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.And(string.Format("the parameter \"x\" is constrained by an inline AttributeRouting.Web.Constraints.{0" +
                        "}", constraintTypeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Given("I have registered the routes for the HttpInlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When(string.Format("I fetch the routes for the HttpInlineRouteConstraints controller\'s {0} action", actionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("the route url is \"Http-Inline-Constraints/{0}/{{x}}\"", actionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And(string.Format("the parameter \"x\" is constrained by an inline AttributeRouting.Web.Constraints.{0" +
                        "}", constraintTypeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inline constraints in the querystring")]
        public virtual void InlineConstraintsInTheQuerystring()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inline constraints in the querystring", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.When("I fetch the routes for the InlineRouteConstraints controller\'s Querystring action" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the route url is \"Inline-Constraints/Querystring\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.And("the parameter \"x\" is constrained by an inline AttributeRouting.Web.Constraints.In" +
                    "tRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("the parameter \"y\" is constrained by an inline AttributeRouting.Web.Constraints.Qu" +
                    "eryStringRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple inline constraints per url segment")]
        public virtual void MultipleInlineConstraintsPerUrlSegment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple inline constraints per url segment", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 53
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
 testRunner.When("I fetch the routes for the InlineRouteConstraints controller\'s MultipleWithinUrlS" +
                    "egment action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("the route url is \"Inline-Constraints/avatar/{width}x{height}/{image}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.And("the parameter \"width\" is constrained by an inline AttributeRouting.Web.Constraint" +
                    "s.IntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("the parameter \"height\" is constrained by an inline AttributeRouting.Web.Constrain" +
                    "ts.IntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.Given("I have registered the routes for the HttpInlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.When("I fetch the routes for the HttpInlineRouteConstraints controller\'s MultipleWithin" +
                    "UrlSegment action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("the route url is \"Http-Inline-Constraints/avatar/{width}x{height}/{image}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.And("the parameter \"width\" is constrained by an inline AttributeRouting.Web.Constraint" +
                    "s.IntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("the parameter \"height\" is constrained by an inline AttributeRouting.Web.Constrain" +
                    "ts.IntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inline constraints specified in the RoutePrefixAttribute")]
        public virtual void InlineConstraintsSpecifiedInTheRoutePrefixAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inline constraints specified in the RoutePrefixAttribute", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("I have registered the routes for the PrefixedInlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.When("I fetch the routes for the PrefixedInlineRouteConstraints controller\'s Index acti" +
                    "on", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("the route url is \"Prefixed-Inline-Constraints/{id}/Howdy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.And("the parameter \"id\" is constrained by an inline AttributeRouting.Web.Constraints.I" +
                    "ntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Given("I have registered the routes for the HttpPrefixedInlineRouteConstraintsController" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.When("I fetch the routes for the HttpPrefixedInlineRouteConstraints controller\'s Index " +
                    "action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("the route url is \"Http-Prefixed-Inline-Constraints/{id}/Howdy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.And("the parameter \"id\" is constrained by an inline AttributeRouting.Web.Constraints.I" +
                    "ntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inline constraints specified in the RouteAreaAttribute")]
        public virtual void InlineConstraintsSpecifiedInTheRouteAreaAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inline constraints specified in the RouteAreaAttribute", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 79
 testRunner.Given("I have registered the routes for the AreaInlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.When("I fetch the routes for the AreaInlineRouteConstraints controller\'s Index action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("the route url is \"Area-Inline-Constraints/{id}/Howdy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.And("the parameter \"id\" is constrained by an inline AttributeRouting.Web.Constraints.I" +
                    "ntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.Given("I have registered the routes for the HttpAreaInlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
 testRunner.When("I fetch the routes for the HttpAreaInlineRouteConstraints controller\'s Index acti" +
                    "on", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("the route url is \"Http-Area-Inline-Constraints/{id}/Howdy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.And("the parameter \"id\" is constrained by an inline AttributeRouting.Web.Constraints.I" +
                    "ntRouteConstraint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Matching inline route constraints")]
        [NUnit.Framework.TestCaseAttribute("Alpha/abc", "Alpha", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Alpha/123", "Alpha", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Int/53", "Int", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Int/abc", "Int", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("IntOptional", "IntOptional", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Long/79", "Long", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Long/xyz", "Long", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Float/1.334", "Float", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Float/gg2", "Float", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Double/3.14", "Double", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Double/adf78", "Double", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Decimal/99.32123345", "Decimal", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Decimal/d8uasdf", "Decimal", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Bool/true", "Bool", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Bool/false", "Bool", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Bool/truish", "Bool", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Bool/falsish", "Bool", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Guid/6076668C-57AA-47FD-A914-94FD552C8493", "Guid", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Guid/6076668C-57AA-47FD-A914-94FD552C", "Guid", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("DateTime/2012-4-22", "DateTime", "is", null)]
        [NUnit.Framework.TestCaseAttribute("DateTime/Today", "DateTime", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Length/a", "Length", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Length/aa", "Length", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("MinLength/abcdefghi", "MinLength", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("MinLength/abcdefghij", "MinLength", "is", null)]
        [NUnit.Framework.TestCaseAttribute("MaxLength/abcdefghij", "MaxLength", "is", null)]
        [NUnit.Framework.TestCaseAttribute("MaxLength/abcdefghijk", "MaxLength", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("LengthRange/abcdefghijk", "LengthRange", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("LengthRange/a", "LengthRange", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("LengthRange/ab", "LengthRange", "is", null)]
        [NUnit.Framework.TestCaseAttribute("LengthRange/abcdefghij", "LengthRange", "is", null)]
        [NUnit.Framework.TestCaseAttribute("LengthRange/abcdefghijk", "LengthRange", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Min/0", "Min", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Min/1", "Min", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Max/10", "Max", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Max/11", "Max", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Range/0", "Range", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Range/1", "Range", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Range/10", "Range", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Range/11", "Range", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Regex/Howdy", "Regex", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Regex/BoyHowdy", "Regex", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Compound/5", "Compound", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Compound/5.0", "Compound", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Enum/red", "Enum", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Enum/taupe", "Enum", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("EnumValue/1", "EnumValue", "is", null)]
        [NUnit.Framework.TestCaseAttribute("EnumValue/10", "EnumValue", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("WithOptional", "WithOptional", "is", null)]
        [NUnit.Framework.TestCaseAttribute("WithDefault", "WithDefault", "is", null)]
        public virtual void MatchingInlineRouteConstraints(string url, string action, string condition, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Matching inline route constraints", exampleTags);
#line 89
this.ScenarioSetup(scenarioInfo);
#line 91
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
 testRunner.When(string.Format("a request for \"Inline-Constraints/{0}\" is made", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then(string.Format("the {0} action {1} matched", action, condition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Given("I have registered the routes for the HttpInlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
 testRunner.When(string.Format("a request for \"Http-Inline-Constraints/{0}\" is made", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then(string.Format("the {0} action {1} matched", action, condition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Matching inline route constraints in the querystring")]
        [NUnit.Framework.TestCaseAttribute("Querystring?x=123&y=hello", "Querystring", "is", null)]
        [NUnit.Framework.TestCaseAttribute("Querystring?x=abc&y=hello", "Querystring", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Querystring?x=abc", "Querystring", "is not", null)]
        [NUnit.Framework.TestCaseAttribute("Querystring?y=hello", "Querystring", "is not", null)]
        public virtual void MatchingInlineRouteConstraintsInTheQuerystring(string url, string action, string condition, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Matching inline route constraints in the querystring", exampleTags);
#line 151
this.ScenarioSetup(scenarioInfo);
#line 153
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 154
 testRunner.When(string.Format("a request for \"Inline-Constraints/{0}\" is made", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.Then(string.Format("the {0} action {1} matched", action, condition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
