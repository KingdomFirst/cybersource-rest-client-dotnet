/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CyberSource.Api;
using CyberSource.Model;
using CyberSource.Client;
using System.Reflection;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing Ptsv2paymentsOrderInformationAmountDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Ptsv2paymentsOrderInformationAmountDetailsTests
    {
        // TODO uncomment below to declare an instance variable for Ptsv2paymentsOrderInformationAmountDetails
        //private Ptsv2paymentsOrderInformationAmountDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Ptsv2paymentsOrderInformationAmountDetails
            //instance = new Ptsv2paymentsOrderInformationAmountDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Ptsv2paymentsOrderInformationAmountDetails
        /// </summary>
        [Test]
        public void Ptsv2paymentsOrderInformationAmountDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Ptsv2paymentsOrderInformationAmountDetails
            //Assert.IsInstanceOfType<Ptsv2paymentsOrderInformationAmountDetails> (instance, "variable 'instance' is a Ptsv2paymentsOrderInformationAmountDetails");
        }

        /// <summary>
        /// Test the property 'GiftWrapAmount'
        /// </summary>
        [Test]
        public void GiftWrapAmountTest()
        {
            // TODO unit test for the property 'GiftWrapAmount'
        }
        /// <summary>
        /// Test the property 'TotalAmount'
        /// </summary>
        [Test]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
        }
        /// <summary>
        /// Test the property 'SubTotalAmount'
        /// </summary>
        [Test]
        public void SubTotalAmountTest()
        {
            // TODO unit test for the property 'SubTotalAmount'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'DiscountAmount'
        /// </summary>
        [Test]
        public void DiscountAmountTest()
        {
            // TODO unit test for the property 'DiscountAmount'
        }
        /// <summary>
        /// Test the property 'DutyAmount'
        /// </summary>
        [Test]
        public void DutyAmountTest()
        {
            // TODO unit test for the property 'DutyAmount'
        }
        /// <summary>
        /// Test the property 'GratuityAmount'
        /// </summary>
        [Test]
        public void GratuityAmountTest()
        {
            // TODO unit test for the property 'GratuityAmount'
        }
        /// <summary>
        /// Test the property 'TaxAmount'
        /// </summary>
        [Test]
        public void TaxAmountTest()
        {
            // TODO unit test for the property 'TaxAmount'
        }
        /// <summary>
        /// Test the property 'NationalTaxIncluded'
        /// </summary>
        [Test]
        public void NationalTaxIncludedTest()
        {
            // TODO unit test for the property 'NationalTaxIncluded'
        }
        /// <summary>
        /// Test the property 'TaxAppliedAfterDiscount'
        /// </summary>
        [Test]
        public void TaxAppliedAfterDiscountTest()
        {
            // TODO unit test for the property 'TaxAppliedAfterDiscount'
        }
        /// <summary>
        /// Test the property 'TaxAppliedLevel'
        /// </summary>
        [Test]
        public void TaxAppliedLevelTest()
        {
            // TODO unit test for the property 'TaxAppliedLevel'
        }
        /// <summary>
        /// Test the property 'TaxTypeCode'
        /// </summary>
        [Test]
        public void TaxTypeCodeTest()
        {
            // TODO unit test for the property 'TaxTypeCode'
        }
        /// <summary>
        /// Test the property 'FreightAmount'
        /// </summary>
        [Test]
        public void FreightAmountTest()
        {
            // TODO unit test for the property 'FreightAmount'
        }
        /// <summary>
        /// Test the property 'ForeignAmount'
        /// </summary>
        [Test]
        public void ForeignAmountTest()
        {
            // TODO unit test for the property 'ForeignAmount'
        }
        /// <summary>
        /// Test the property 'ForeignCurrency'
        /// </summary>
        [Test]
        public void ForeignCurrencyTest()
        {
            // TODO unit test for the property 'ForeignCurrency'
        }
        /// <summary>
        /// Test the property 'ExchangeRate'
        /// </summary>
        [Test]
        public void ExchangeRateTest()
        {
            // TODO unit test for the property 'ExchangeRate'
        }
        /// <summary>
        /// Test the property 'ExchangeRateTimeStamp'
        /// </summary>
        [Test]
        public void ExchangeRateTimeStampTest()
        {
            // TODO unit test for the property 'ExchangeRateTimeStamp'
        }
        /// <summary>
        /// Test the property 'Surcharge'
        /// </summary>
        [Test]
        public void SurchargeTest()
        {
            // TODO unit test for the property 'Surcharge'
        }
        /// <summary>
        /// Test the property 'SettlementAmount'
        /// </summary>
        [Test]
        public void SettlementAmountTest()
        {
            // TODO unit test for the property 'SettlementAmount'
        }
        /// <summary>
        /// Test the property 'SettlementCurrency'
        /// </summary>
        [Test]
        public void SettlementCurrencyTest()
        {
            // TODO unit test for the property 'SettlementCurrency'
        }
        /// <summary>
        /// Test the property 'AmexAdditionalAmounts'
        /// </summary>
        [Test]
        public void AmexAdditionalAmountsTest()
        {
            // TODO unit test for the property 'AmexAdditionalAmounts'
        }
        /// <summary>
        /// Test the property 'TaxDetails'
        /// </summary>
        [Test]
        public void TaxDetailsTest()
        {
            // TODO unit test for the property 'TaxDetails'
        }
        /// <summary>
        /// Test the property 'ServiceFeeAmount'
        /// </summary>
        [Test]
        public void ServiceFeeAmountTest()
        {
            // TODO unit test for the property 'ServiceFeeAmount'
        }
        /// <summary>
        /// Test the property 'OriginalAmount'
        /// </summary>
        [Test]
        public void OriginalAmountTest()
        {
            // TODO unit test for the property 'OriginalAmount'
        }
        /// <summary>
        /// Test the property 'OriginalCurrency'
        /// </summary>
        [Test]
        public void OriginalCurrencyTest()
        {
            // TODO unit test for the property 'OriginalCurrency'
        }
        /// <summary>
        /// Test the property 'CashbackAmount'
        /// </summary>
        [Test]
        public void CashbackAmountTest()
        {
            // TODO unit test for the property 'CashbackAmount'
        }
        /// <summary>
        /// Test the property 'CurrencyConversion'
        /// </summary>
        [Test]
        public void CurrencyConversionTest()
        {
            // TODO unit test for the property 'CurrencyConversion'
        }
        /// <summary>
        /// Test the property 'Order'
        /// </summary>
        [Test]
        public void OrderTest()
        {
            // TODO unit test for the property 'Order'
        }

    }

}
