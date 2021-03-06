// Copyright (c) Russlan Akiev. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityBase.Actions.Register
{
    using System.ComponentModel.DataAnnotations;

    public class ConfirmInputModel
    {
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage =
            "The password and confirmation password do not match.")]
        [StringLength(100)]
        public string PasswordConfirm { get; set; }
    }
}