﻿using System.ComponentModel.DataAnnotations;

using Encamina.Enmarcha.Core.DataAnnotations;

namespace Hramos.API.Models;

/// <summary>
/// A request to translate text.
/// </summary>
public sealed class RequestTranslate
{
    /// <summary>
    /// Sets the language to translate the text to.
    /// </summary>
    [Required]
    [NotEmptyOrWhitespace]
    public string Lang { get; set; }

    /// <summary>
    /// Sets the text to translate.
    /// </summary>
    [Required]
    [NotEmptyOrWhitespace]
    public string Input { get; set; }
}
