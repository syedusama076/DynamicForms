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


