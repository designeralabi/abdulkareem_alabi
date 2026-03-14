namespace abdulkareem_alabi.Data;

public static class ProcessStepData
{
    public static List<ProcessStep> Steps { get; } = new()
    {
        new ProcessStep
        {
            Title = "Idea",
            Description = "We meet with your team to learn more about your project idea and goals."
        },
        new ProcessStep
        {
            Title = "Design",
            Description = "We will design a mockup or prototype of your website and present."
        },
        new ProcessStep
        {
            Title = "Web dev",
            Description = "When the project is completed, we will schedule a 2hr training."
        },
        new ProcessStep
        {
            Title = "Launch",
            Description = "We develop websites using the best practices and standards."
        }
    };
}