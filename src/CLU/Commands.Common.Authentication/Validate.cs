﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Commands.Common.Authentication.Properties;
using System;
using System.IO;
using System.Linq;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    public static class Validate
    {
        /// <summary>
        /// Validates against given string if null or empty.
        /// </summary>
        /// <param name="data">string variable to validate</param>
        /// <param name="messageData">This parameter is used when the validation fails. It can contain actual message to display
        /// or parameter name to display with default message</param>
        /// <param name="useDefaultMessage">Indicates either to use messageData as actual message or parameter name</param>
        public static void ValidateStringIsNullOrEmpty(string data, string messageData, bool useDefaultMessage = true)
        {
            if (string.IsNullOrEmpty(data))
            {
                // In this case use messageData parameter as name for null/empty string.
                if (useDefaultMessage)
                {
                    throw new ArgumentException(string.Format(Resources.InvalidOrEmptyArgumentMessage, messageData));
                }
                else
                {
                    // Use the message provided by the user
                    throw new ArgumentException(messageData);
                }
            }
        }

        public static void ValidatePathName(string element, string exceptionMessage)
        {
            if (element.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void ValidateFileName(string element, string exceptionMessage = null)
        {
            try
            {
                string fileName = Path.GetFileName(element);

                if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
                {
                    throw new ArgumentException(exceptionMessage ?? string.Empty);
                }
            }
            catch
            {
                throw new ArgumentException(exceptionMessage ?? string.Empty);
            }
        }

        public static void ValidateFileExists(string filePath, string exceptionMessage, IDataStore dataStore)
        {
            if (dataStore.FileExists(filePath))
            {
                throw new FileNotFoundException(exceptionMessage);
            }
        }

        public static void ValidateDirectoryExists(string directory, IDataStore dataStore, string exceptionMessage = null)
        {
            string msg = string.Format(Resources.PathDoesNotExist, directory);

            if (!dataStore.DirectoryExists(directory))
            {
                if (!string.IsNullOrEmpty(exceptionMessage))
                {
                    msg = exceptionMessage;
                }

                throw new FileNotFoundException(msg);
            }
        }

        public static void ValidateNullArgument(object item, string exceptionMessage)
        {
            if (item == null)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void ValidateFileExtention(string filePath, string desiredExtention)
        {
            bool invalidExtension = Convert.ToBoolean(string.Compare(Path.GetExtension(filePath), desiredExtention, true));

            if (invalidExtension)
            {
                throw new ArgumentException(string.Format(Resources.InvalidFileExtension, filePath, desiredExtention));
            }
        }

        public static void ValidateDnsName(string dnsName, string parameterName)
        {
            if (Uri.CheckHostName(dnsName) != UriHostNameType.Dns || dnsName.EndsWith("-"))
            {
                throw new ArgumentException(string.Format(Resources.InvalidDnsName, dnsName, parameterName));
            }
        }

        public static void HasWhiteCharacter(string text, string exceptionMessage = null)
        {
            if (text.Any(char.IsWhiteSpace))
            {
                throw new ArgumentException(exceptionMessage ?? string.Empty);
            }
        }

        /// <summary>
        /// Make validation for given path.
        /// </summary>
        /// <param name="path">Path to validate</param>
        /// <param name="exceptionMessage">message to display if this validation failed</param>
        public static void ValidatePath(string path, string exceptionMessage)
        {
            ValidateStringIsNullOrEmpty(path, exceptionMessage, false);
            ValidatePathName(path, exceptionMessage);
        }

        /// <summary>
        /// Validates against given directory
        /// </summary>
        /// <param name="directoryNameOnDisk">Directory name</param>
        /// <param name="directoryName">Name which you use to identify that directory to user (i.e. AzureSdkDirectory)</param>
        /// <param name="dataStore">The data store to use</param>
        public static void ValidateDirectoryFull(string directoryNameOnDisk, string directoryName, IDataStore dataStore)
        {
            BasicFileAndDirectoryValidation(directoryNameOnDisk, directoryName);
            ValidateDirectoryExists(directoryNameOnDisk, dataStore, string.Format(Resources.PathDoesNotExistForElement, directoryName, directoryNameOnDisk));
        }

        private static void BasicFileAndDirectoryValidation(string fullPath, string name)
        {
            ValidateStringIsNullOrEmpty(fullPath, name);
            ValidateFileName(fullPath, Resources.IllegalPath);
            string directoryPath = Path.GetDirectoryName(fullPath);
            if (!string.IsNullOrEmpty(directoryPath))
            {
                ValidatePath(fullPath, Resources.IllegalPath);
            }
        }

        /// <summary>
        /// Validates against given file
        /// </summary>
        /// <param name="fileNameOnDisk">File name</param>
        /// <param name="fileName">Name which you use to identify that directory to user (i.e. Service Settings)</param>
        public static void ValidateFileFull(string fileNameOnDisk, string fileName, IDataStore dataStore)
        {
            BasicFileAndDirectoryValidation(fileNameOnDisk, fileName);
            ValidateFileExists(fileNameOnDisk, string.Format(Resources.PathDoesNotExistForElement, fileName, fileNameOnDisk), dataStore);
        }
    }
}