using System.Collections.Generic;
using DynamicFormsBlazor.Components;

namespace DynamicFormsBlazor.Models;

public class FormDefinition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public List<FormFieldDefinition> Fields { get; set; } = new();
}

public class FormFieldDefinition
{
    public int Id { get; set; }

    public int FormDefinitionId { get; set; }
    public FormDefinition FormDefinition { get; set; } = default!;

    public string Key { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public DynamicForm.FormFieldType Type { get; set; }

    public string? Placeholder { get; set; }
    public string? CheckboxLabel { get; set; }
    public string? HelpText { get; set; }
    public string? DefaultValueJson { get; set; }

    /// <summary>
    /// Optional price for this field. Used with {price}, {subtotal}, {total} variables.
    /// </summary>
    public decimal? Price { get; set; }

    /// <summary>
    /// Optional parent field key. If set, this field is only visible when the parent checkbox is checked.
    /// </summary>
    public string? ParentFieldKey { get; set; }

    /// <summary>
    /// Comma-separated list of field keys that are mutually exclusive with this checkbox.
    /// When this checkbox is checked, all fields in this list will be unchecked.
    /// </summary>
    public string? MutuallyExclusiveWith { get; set; }

    public List<FormFieldOptionDefinition> Options { get; set; } = new();
}

public class FormFieldOptionDefinition
{
    public int Id { get; set; }

    public int FormFieldDefinitionId { get; set; }
    public FormFieldDefinition FormField { get; set; } = default!;

    public string Value { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}


