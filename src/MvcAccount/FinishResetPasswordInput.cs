﻿// Copyright 2012 Max Toro Q.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcAccount {
   
   /// <summary>
   /// Holds data required by the <see cref="AccountController.RP(string, FinishResetPasswordInput)"/> action.
   /// </summary>
   public class FinishResetPasswordInput {

      /// <summary>
      /// The new password.
      /// </summary>
      [Required(ErrorMessageResourceName = AccountResources.Keys.Validation_Required, ErrorMessageResourceType = typeof(AccountResources))]
      [PasswordLength]
      [DataType(DataType.Password)]
      [Display(Order = 1, Name = AccountResources.Keys.Model_NewPassword, ResourceType = typeof(AccountResources))]
      public string NewPassword { get; set; }

      /// <summary>
      /// The new password.
      /// </summary>
      [Required(ErrorMessageResourceName = AccountResources.Keys.Validation_Required, ErrorMessageResourceType = typeof(AccountResources))]
      [Compare("NewPassword", ErrorMessageResourceName = AccountResources.Keys.Validation_PasswordsNotMatch, ErrorMessageResourceType = typeof(AccountResources))]
      [DataType(DataType.Password)]
      [Display(Order = 2, Name = AccountResources.Keys.Model_ConfirmNewPassword, ResourceType = typeof(AccountResources))]
      public string ConfirmNewPassword { get; set; }
   }
}
