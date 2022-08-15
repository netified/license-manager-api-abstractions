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

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LicenseManager.Api.Abstractions
{
    /// <summary>
    /// Product backup model.
    /// </summary>
    public class ProductBackupDto
    {
        [DefaultValue(null)]
        [Required(ErrorMessage = "Product identifier is required")]
        public Guid Id { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DefaultValue(null)]
        public string Description { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Company is required")]
        public string Company { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Pass phrase is required")]
        public string PassPhrase { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Private key is required")]
        public string PrivateKey { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Public key is required")]
        public string PublicKey { get; set; }

        [DefaultValue(null)]
        [Required(ErrorMessage = "Checksum is required")]
        public string Checksum { get; set; }
    }
}