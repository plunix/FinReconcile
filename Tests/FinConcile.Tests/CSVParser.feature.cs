﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FinConcile.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CSVParser")]
    public partial class CSVParserFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CSVParser.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CSVParser", "\tIn order to read transactions from markoff csv file\r\n\tAs a user\r\n\tI want to pars" +
                    "e transactions from each line", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Parse header line before reading transactions")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void ParseHeaderLineBeforeReadingTransactions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse header line before reading transactions", new string[] {
                        "csvparser"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table1.AddRow(new string[] {
                        "ProfileName,TransactionDate,TransactionAmount,TransactionNarrative,TransactionDes" +
                            "cription,TransactionID,TransactionType,WalletReference"});
            table1.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:27:44,-20000,*MOLEPS ATM25             MOLEPOLOLE    " +
                            "BW,DEDUCT,0584011808649511,1,P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5,"});
            table1.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:39:11,-10000,*MOGODITSHANE2            MOGODITHSANE  " +
                            "BW,DEDUCT,0584011815513406,1,P_NzI1MjA1NjZfMTM3ODczODI3Mi4wNzY5,"});
            table1.AddRow(new string[] {
                        "Card Campaign,2014-01-11 23:28:11,-5000,CAPITAL BANK              MOGODITSHANE  B" +
                            "W,DEDUCT,0464011844938429,1,P_NzI0NjE1NzhfMTM4NzE4ODExOC43NTYy,"});
#line 8
 testRunner.Given("a markofffile\twith content", ((string)(null)), table1, "Given ");
#line 14
 testRunner.When("I call GetRecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("the result should be 3 transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse empty file with only header line")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void ParseEmptyFileWithOnlyHeaderLine()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse empty file with only header line", new string[] {
                        "csvparser"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table2.AddRow(new string[] {
                        "ProfileName,TransactionDate,TransactionAmount,TransactionNarrative,TransactionDes" +
                            "cription,TransactionID,TransactionType,WalletReference"});
#line 18
 testRunner.Given("a markofffile\twith content", ((string)(null)), table2, "Given ");
#line 21
 testRunner.When("I call GetRecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the result should be 0 transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ignore invalid lines while reading transactions")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void IgnoreInvalidLinesWhileReadingTransactions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ignore invalid lines while reading transactions", new string[] {
                        "csvparser"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table3.AddRow(new string[] {
                        "ProfileName,TransactionDate,TransactionAmount,TransactionNarrative,TransactionDes" +
                            "cription,TransactionID,TransactionType,WalletReference"});
            table3.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:27:44,-20000,*MOLEPS ATM25             MOLEPOLOLE    " +
                            "BW,DEDUCT,0584011808649511,1,P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5,"});
            table3.AddRow(new string[] {
                        "Card Campaign,-10000,*MOGODITSHANE2            MOGODITHSANE  BW,DEDUCT,0584011815" +
                            "513406,1,P_NzI1MjA1NjZfMTM3ODczODI3Mi4wNzY5,"});
            table3.AddRow(new string[] {
                        "Card Campaign,2014-01-11 23:28:11,-5000,0464011844938429,1,P_NzI0NjE1NzhfMTM4NzE4" +
                            "ODExOC43NTYy,"});
#line 25
 testRunner.Given("a markofffile\twith content", ((string)(null)), table3, "Given ");
#line 31
 testRunner.When("I call GetRecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("the result should be 1 transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.And("2 Invalid Entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("Invalid entries matches line numbers 3 and 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse a large file Client Transactions File")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void ParseALargeFileClientTransactionsFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse a large file Client Transactions File", new string[] {
                        "csvparser"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given("a large client markofffile with content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.When("I call GetRecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the result should be 306 transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("0 Invalid Entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse a large file Tutuka Transactions File")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void ParseALargeFileTutukaTransactionsFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse a large file Tutuka Transactions File", new string[] {
                        "csvparser"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("a large tutuka markofffile with content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.When("I call GetRecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the result should be 305 transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("0 Invalid Entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate file for Headers")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void ValidateFileForHeaders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate file for Headers", new string[] {
                        "csvparser"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table4.AddRow(new string[] {
                        "ProfileName,TransactionDate,TransactionAmount,TransactionNarrative,TransactionDes" +
                            "cription,TransactionID,TransactionType,WalletReference"});
            table4.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:27:44,-20000,*MOLEPS ATM25             MOLEPOLOLE    " +
                            "BW,DEDUCT,0584011808649511,1,P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5,"});
            table4.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:39:11,-10000,*MOGODITSHANE2            MOGODITHSANE  " +
                            "BW,DEDUCT,0584011815513406,1,P_NzI1MjA1NjZfMTM3ODczODI3Mi4wNzY5,"});
            table4.AddRow(new string[] {
                        "Card Campaign,2014-01-11 23:28:11,-5000,CAPITAL BANK              MOGODITSHANE  B" +
                            "W,DEDUCT,0464011844938429,1,P_NzI0NjE1NzhfMTM4NzE4ODExOC43NTYy,"});
#line 49
 testRunner.Given("a markofffile\twith content", ((string)(null)), table4, "Given ");
#line 55
 testRunner.When("I call Validate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("the result should be valid file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate file with wrong Headers")]
        [NUnit.Framework.CategoryAttribute("csvparser")]
        public virtual void ValidateFileWithWrongHeaders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate file with wrong Headers", new string[] {
                        "csvparser"});
#line 58
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table5.AddRow(new string[] {
                        "ProfileName,TransactioDate,TransactionAmoun,TransactionNarrative,TransactionDescr" +
                            "iption,TransactionID,TransactionType,WalletReference"});
            table5.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:27:44,-20000,*MOLEPS ATM25             MOLEPOLOLE    " +
                            "BW,DEDUCT,0584011808649511,1,P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5,"});
            table5.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:39:11,-10000,*MOGODITSHANE2            MOGODITHSANE  " +
                            "BW,DEDUCT,0584011815513406,1,P_NzI1MjA1NjZfMTM3ODczODI3Mi4wNzY5,"});
            table5.AddRow(new string[] {
                        "Card Campaign,2014-01-11 23:28:11,-5000,CAPITAL BANK              MOGODITSHANE  B" +
                            "W,DEDUCT,0464011844938429,1,P_NzI0NjE1NzhfMTM4NzE4ODExOC43NTYy,"});
#line 59
 testRunner.Given("a markofffile\twith content", ((string)(null)), table5, "Given ");
#line 65
 testRunner.When("I call Validate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("the result should be invalid file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.And("Error Message should contain headername \'TransactionDate\' with LineNo 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate file with multiple wrong Headers")]
        public virtual void ValidateFileWithMultipleWrongHeaders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate file with multiple wrong Headers", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table6.AddRow(new string[] {
                        "ProfileName,TransactioDate,TransactionAmoun,TransactionNarrative,TransactionDescr" +
                            "iption,TransactionID,TransactionType,WalletReference"});
            table6.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:27:44,-20000,*MOLEPS ATM25             MOLEPOLOLE    " +
                            "BW,DEDUCT,0584011808649511,1,P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5,"});
            table6.AddRow(new string[] {
                        "Card Campaign,2014-01-11 22:39:11,-10000,*MOGODITSHANE2            MOGODITHSANE  " +
                            "BW,DEDUCT,0584011815513406,1,P_NzI1MjA1NjZfMTM3ODczODI3Mi4wNzY5,"});
            table6.AddRow(new string[] {
                        "Card Campaign,2014-01-11 23:28:11,-5000,CAPITAL BANK              MOGODITSHANE  B" +
                            "W,DEDUCT,0464011844938429,1,P_NzI0NjE1NzhfMTM4NzE4ODExOC43NTYy,"});
#line 70
 testRunner.Given("a markofffile\twith content", ((string)(null)), table6, "Given ");
#line 76
 testRunner.When("I call Validate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("the result should be invalid file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.And("Error Messages should contain headername \'TransactionDate\' and \'TransactionAmount" +
                    "\' with LineNo 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate file for different headers order")]
        public virtual void ValidateFileForDifferentHeadersOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate file for different headers order", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Lines"});
            table7.AddRow(new string[] {
                        "WalletReference,ProfileName,TransactionDate,TransactionAmount,TransactionNarrativ" +
                            "e,TransactionDescription,TransactionID,TransactionType"});
            table7.AddRow(new string[] {
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5, Card Campaign,2014-01-11 22:27:44,-20000,*MOL" +
                            "EPS ATM25             MOLEPOLOLE    BW,DEDUCT,0584011808649511,1"});
            table7.AddRow(new string[] {
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5, Card Campaign,2014-01-11 22:27:44,-20000,*MOL" +
                            "EPS ATM25             MOLEPOLOLE    BW,DEDUCT,0584011808649511,1"});
            table7.AddRow(new string[] {
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5, Card Campaign,2014-01-11 22:27:44,-20000,*MOL" +
                            "EPS ATM25             MOLEPOLOLE    BW,DEDUCT,0584011808649511,1"});
#line 80
 testRunner.Given("a markofffile\twith content", ((string)(null)), table7, "Given ");
#line 86
 testRunner.When("I call Validate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("the result should be valid file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("with 3 Transactions and No Errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
