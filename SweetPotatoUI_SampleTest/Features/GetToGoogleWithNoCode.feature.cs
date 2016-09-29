﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SweetPotatoUI_SampleTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetToGoogleWithNoCode")]
    public partial class GetToGoogleWithNoCodeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetToGoogleWithNoCode.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetToGoogleWithNoCode", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Get to Google")]
        public virtual void GetToGoogle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get to Google", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have started the browser \'InternetExplorer\' using the driver \'Selenium\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Given("\'GooglePageElements\' Page Elements have been loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I Navigate to \'http://www.google.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("I see Page with Title \'Google\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElementAlias"});
            table1.AddRow(new string[] {
                        "SearchBox"});
#line 13
 testRunner.Then("\'GooglePage\' has Displayed Elements", ((string)(null)), table1, "Then ");
#line 17
 testRunner.When("I enter \'Des Moines\' into the \'SearchBox\' element of the \'GooglePage\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.When("I tab away from Element \'SearchBox\' of the \'GooglePage\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElementAlias",
                        "Data"});
            table2.AddRow(new string[] {
                        "SearchBox",
                        "Denver"});
            table2.AddRow(new string[] {
                        "SearchBox",
                        "Omaha"});
#line 21
 testRunner.When("I fill Element of the \'GooglePage\' page", ((string)(null)), table2, "When ");
#line 26
 testRunner.When("I scroll to the \'SearchButton\' element of the \'GooglePage\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.When("I click the \'SearchButton\' element of the \'GooglePage\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("I see Page with Title \'Omaha - Google Search\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElementAlias",
                        "Value"});
            table3.AddRow(new string[] {
                        "SearchBox",
                        "Omaha"});
#line 32
 testRunner.Then("\'GooglePage\' has elements that contain Value", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElementAlias"});
            table4.AddRow(new string[] {
                        "SearchBox"});
#line 36
 testRunner.Then("\'GooglePage\' has Enabled Elements", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElementAlias",
                        "Text"});
            table5.AddRow(new string[] {
                        "ResultStats",
                        "About"});
#line 40
 testRunner.Then("\'GoogleResultsPage\' has elements that contain Text", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElementAlias",
                        "Value"});
            table6.AddRow(new string[] {
                        "SearchBox",
                        "Omaha"});
#line 44
 testRunner.Then("\'GooglePage\' has elements with Exact Value", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion