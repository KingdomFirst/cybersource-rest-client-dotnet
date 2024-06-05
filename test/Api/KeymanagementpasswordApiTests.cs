/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing KeyManagementPasswordApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KeyManagementPasswordApiTests
    {
        private KeyManagementPasswordApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KeyManagementPasswordApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KeyManagementPasswordApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KeyManagementPasswordApi
            //Assert.IsInstanceOfType(typeof(KeyManagementPasswordApi), instance, "instance is a KeyManagementPasswordApi");
        }

        
        /// <summary>
        /// Test UpdatePassword
        /// </summary>
        [Test]
        public void UpdatePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyId = null;
            //UpdatePasswordKeysRequest updatePasswordKeysRequest = null;
            //var response = instance.UpdatePassword(keyId, updatePasswordKeysRequest);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
