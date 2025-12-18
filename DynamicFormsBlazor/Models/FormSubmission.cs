using System;
using System.Collections.Generic;

namespace DynamicFormsBlazor.Models;

public class FormSubmission
{
    public int Id { get; set; }

    public int FormDefinitionId { get; set; }
    public FormDefinition FormDefinition { get; set; } = default!;

    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Raw submitted values stored as JSON (key/value pairs).
    /// </summary>
    public string DataJson { get; set; } = string.Empty;

    /// <summary>
    /// Calculated total amount from all priced fields.
    /// </summary>
    public decimal TotalAmount { get; set; }
}


