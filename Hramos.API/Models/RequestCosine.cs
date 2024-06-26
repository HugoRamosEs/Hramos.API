﻿using System.ComponentModel.DataAnnotations;

using Encamina.Enmarcha.Core.DataAnnotations;

namespace Hramos.API.Models;

/// <summary>
/// A request for compare two strings using cosine similarity.
/// </summary>
public class RequestCosine
{
    /// <summary>
    /// String 1 to compare.
    /// </summary>
    [Required]
    [NotEmptyOrWhitespace]
    public string Str1 { get; set; }

    /// <summary>
    /// String 2 to compare.
    /// </summary>
    [Required]
    [NotEmptyOrWhitespace]
    public string Str2 { get; set; }
}
