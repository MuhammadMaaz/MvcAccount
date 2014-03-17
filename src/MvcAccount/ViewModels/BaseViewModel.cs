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
using System.Web.Mvc;
using System.Web;

namespace MvcAccount.ViewModels {
   
   /// <summary>
   /// Holds common view data.
   /// </summary>
   public abstract class BaseViewModel {

      UrlHelper _Url;

      /// <summary>
      /// The view's title, used on h1 and title elements.
      /// </summary>
      public string Title { get; set; }

      /// <summary>
      /// A <see cref="UrlHelper"/> for creating URLs.
      /// </summary>
      protected UrlHelper Url {
         get {
            if (_Url == null)
               _Url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            return _Url;
         }
      }
   }
}
