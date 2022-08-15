// Copyright (c) 2022 Netified <contact@netified.io>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LicenseManager.Api.Abstractions
{
    /// <summary>
    /// License request model.
    /// </summary>
    public class LicenseRequest
    {
        [DefaultValue(null)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DefaultValue("Trial")]
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Duration is required")]
        [Range(1, 1460, ErrorMessage = "Price must be between 1 and 1400")]
        public int Duration { get; set; }

        [DefaultValue(null)]
        public Dictionary<string, string> AdditionalAttributes { get; set; }

        [DefaultValue(null)]
        public Dictionary<string, string> ProductFeatures { get; set; }
    }
}