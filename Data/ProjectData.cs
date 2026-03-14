namespace abdulkareem_alabi.Data;

public static class ProjectData
{
    public static List<ProjectItem> Projects { get; } = new()
    {
        new ProjectItem
        {
            Title = "E-Commerce Platform",
            Description = "Built a full-stack e-commerce solution with ASP.NET Core Web API and a React front-end. Features include real-time inventory tracking, Stripe payment integration, and an admin dashboard with analytics.",
            Role = "FullStack Developer",
            Client = "RetailHub",
            Tags = new List<string> { "ASP.NET Core", "React", "SQL Server", "Stripe API" }
        },
        new ProjectItem
        {
            Title = "Task Management SaaS",
            Description = "Developed a collaborative task management platform enabling teams to create, assign, and track projects in real-time. Integrated WebSocket-based notifications and role-based access control.",
            Role = "Backend Engineer",
            Client = "Taskify",
            Tags = new List<string> { "C#", ".NET Web API", "PostgreSQL", "SignalR" }
        },
        new ProjectItem
        {
            Title = "Healthcare Appointment System",
            Description = "Designed and implemented a scheduling system for a healthcare provider, allowing patients to book appointments online. Reduced no-show rates by 30% with automated email and SMS reminders.",
            Role = "FullStack Developer",
            Client = "MedConnect",
            Tags = new List<string> { "ASP.NET Core", "Blazor", "Twilio", "Entity Framework" }
        },
        new ProjectItem
        {
            Title = "Real Estate Listing Portal",
            Description = "Created a property listing platform with advanced search filters, map integration, and a CRM for agents. Optimized API response times by 40% through caching and query improvements.",
            Role = "API Developer",
            Client = "PropertyNest",
            Tags = new List<string> { "C#", "REST API", "Redis", "Google Maps API" }
        },
        new ProjectItem
        {
            Title = "Logistics & Delivery Tracker",
            Description = "Built a real-time delivery tracking system with route optimization and driver management. Integrated third-party logistics APIs for seamless package monitoring across multiple carriers.",
            Role = "FullStack Developer",
            Client = "SwiftDeliver",
            Tags = new List<string> { "ASP.NET Core", "Vue.js", "PostgreSQL", "REST API" }
        },
        new ProjectItem
        {
            Title = "Portfolio & Blog CMS",
            Description = "Developed a custom content management system for creatives to showcase their work and publish articles. Features include markdown editing, image optimization, and SEO tooling.",
            Role = "Solo Developer",
            Client = "Personal Project",
            Tags = new List<string> { "Blazor", "C#", "Tailwind CSS", "SQLite" }
        }
    };
}