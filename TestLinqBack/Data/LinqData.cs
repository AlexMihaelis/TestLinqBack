using TestLinqBack.Models;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Data;

public static class LinqData
{
    public static List<Department> Departments { get; } = new()
    {
        new Department { Id = 1, Name = "IT" },
        new Department { Id = 2, Name = "Finance" },
        new Department { Id = 3, Name = "HR" },
        new Department { Id = 4, Name = "Marketing" }
    };

    public static List<User> Users { get; } = new()
    {
        new User
        {
            Id = 1,
            Username = "alice",
            Email = "alice@company.com",
            DepartmentId = 1,
            Salary = 120000,
            Role = "Developer",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 2,
            Username = "bob",
            Email = "bob@company.com",
            DepartmentId = 1,
            Salary = 150000,
            Role = "TeamLead",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 3,
            Username = "charlie",
            Email = "charlie@company.com",
            DepartmentId = 2,
            Salary = 110000,
            Role = "Accountant",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 4,
            Username = "diana",
            Email = "diana@company.com",
            DepartmentId = 3,
            Salary = 90000,
            Role = "HR",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 5,
            Username = "eric",
            Email = "eric@company.com",
            DepartmentId = 4,
            Salary = 130000,
            Role = "Accountant",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 6,
            Username = "frank",
            Email = "frank@company.com",
            DepartmentId = 1,
            Salary = 160000,
            Role = "Accountant",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 7,
            Username = "gina",
            Email = "gina@company.com",
            DepartmentId = 1,
            Salary = 98000,
            Role = "Accountant",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 8,
            Username = "henry",
            Email = "henry@company.com",
            DepartmentId = 2,
            Salary = 105000,
            Role = "FinancialAnalyst",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 9,
            Username = "irina",
            Email = "irina@company.com",
            DepartmentId = 4,
            Salary = 115000,
            Role = "ProductManager",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 10,
            Username = "jack",
            Email = "jack@company.com",
            DepartmentId = 4,
            Salary = 95000,
            Role = "Designer",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 11,
            Username = "kate",
            Email = "kate@company.com",
            DepartmentId = 3,
            Salary = 85000,
            Role = "Developer",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 12,
            Username = "leo",
            Email = "leo@company.com",
            DepartmentId = 1,
            Salary = 140000,
            Role = "Developer",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 13,
            Username = "maya",
            Email = "maya@company.com",
            DepartmentId = 2,
            Salary = 98000,
            Role = "BillingSupport",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 14,
            Username = "nate",
            Email = "nate@company.com",
            DepartmentId = 1,
            Salary = 125000,
            Role = "DataEngineer",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 15,
            Username = "olga",
            Email = "olga@company.com",
            DepartmentId = 4,
            Salary = 89000,
            Role = "HR",
            Projects = new List<Project>()
        },
        new User
        {
            Id = 16,
            Username = "peter",
            Email = "peter@company.com",
            DepartmentId = 2,
            Salary = 118000,
            Role = "HR",
            Projects = new List<Project>()
        }
    };

    public static List<Project> Projects { get; } = new()
    {
        new Project
        {
            Id = 1,
            Name = "Internal CRM",
            Description = "CRM for internal sales processes",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-6),
            Deadline = DateTime.Now.AddMonths(2),
            ManagerId = 2,
            Documents = new List<Document>
            {
                new() { Id = 1, Name = "CRM Spec", Expenses = 2000, Profit = 5000 },
                new() { Id = 2, Name = "CRM Report Q1", Expenses = 1500, Profit = 500 }
            }
        },
        new Project
        {
            Id = 2,
            Name = "Mobile App",
            Description = "Customer mobile application",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddMonths(-14),
            Deadline = DateTime.Now.AddMonths(-6),
            ManagerId = 6,
            Documents = new List<Document>
            {
                new() { Id = 1, Name = "CRM Spec", Expenses = 2000, Profit = 5000 },
                new() { Id = 3, Name = "Mobile UI Draft", Expenses = 1000, Profit = 2000 },
                new() { Id = 4, Name = "Mobile Backend Plan", Expenses = 3000, Profit = 9000 },
                new() { Id = 5, Name = "App Final Report", Expenses = 5000, Profit = 18000 }
            }
        },
        new Project
        {
            Id = 3,
            Name = "Salary Automation",
            Description = "Automation of payroll processes",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-3),
            Deadline = DateTime.Now.AddMonths(1),
            ManagerId = 3,
            Documents = new List<Document>
            {
                new() { Id = 6, Name = "Initial Spec", Expenses = 800, Profit = 0 },
                new() { Id = 7, Name = "Finance Review", Expenses = 500, Profit = 1500 }
            }
        },
        new Project
        {
            Id = 4,
            Name = "HR Training Program",
            Description = "Training materials for HR department",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-20),
            Deadline = null,
            ManagerId = 4,
            Documents = new List<Document>
            {
                new() { Id = 8, Name = "Training Outline", Expenses = 300, Profit = 0 }
            }
        },
        new Project
        {
            Id = 5,
            Name = "Ad Campaign 2025",
            Description = "Marketing campaign for Q1 2025",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-1),
            Deadline = DateTime.Now.AddMonths(3),
            ManagerId = 5,
            Documents = new List<Document>
            {
                new() { Id = 9, Name = "Strategy Draft", Expenses = 2500, Profit = 0 },
                new() { Id = 10, Name = "Designs", Expenses = 5000, Profit = 400 }
            }
        },
        new Project
        {
            Id = 6,
            Name = "Legacy System Migration",
            Description = "Migration of old systems to .NET 8",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-8),
            Deadline = DateTime.Now.AddMonths(4),
            ManagerId = 6,
            Documents = new List<Document>
            {
                new() { Id = 11, Name = "Migration Plan", Expenses = 4000, Profit = 2000 },
                new() { Id = 12, Name = "Old System Analysis", Expenses = 2000, Profit = 4000 }
            }
        },
        new Project
        {
            Id = 7,
            Name = "Partner Portal",
            Description = "External partner integration portal",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-10),
            Deadline = null,
            ManagerId = 2,
            Documents = new List<Document>
            {
                new() { Id = 13, Name = "Portal Scope", Expenses = 1500, Profit = 0 }
            }
        },
        new Project
        {
            Id = 8,
            Name = "Analytics Dashboard",
            Description = "Real-time analytics dashboard",
            Status = ProjectStatus.Archived,
            CreatedAt = DateTime.Now.AddYears(-2),
            Deadline = DateTime.Now.AddYears(-1),
            ManagerId = 1,
            Documents = new List<Document>
            {
                new() { Id = 14, Name = "Dashboard UI", Expenses = 3000, Profit = 6000 },
                new() { Id = 15, Name = "Dashboard Backend", Expenses = 7000, Profit = 1000 }
            }
        },
        new Project
        {
            Id = 9,
            Name = "Customer Loyalty Program",
            Description = "Loyalty points and rewards system",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-4),
            Deadline = DateTime.Now.AddMonths(5),
            ManagerId = 9,
            Documents = new List<Document>
            {
                new() { Id = 16, Name = "Program Spec", Expenses = 1800, Profit = 4000 },
                new() { Id = 17, Name = "Integration Plan", Expenses = 2200, Profit = 0 },
                new() { Id = 18, Name = "Pilot Results", Expenses = 900, Profit = 1200 }
            }
        },
        new Project
        {
            Id = 10,
            Name = "Website Redesign",
            Description = "Full redesign of corporate website",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddMonths(-10),
            Deadline = DateTime.Now.AddMonths(-5),
            ManagerId = 10,
            Documents = new List<Document>
            {
                new() { Id = 19, Name = "Wireframes", Expenses = 1200, Profit = 0 },
                new() { Id = 20, Name = "Final Assets", Expenses = 3500, Profit = 7000 }
            }
        },
        new Project
        {
            Id = 11,
            Name = "Billing Revamp",
            Description = "Improve billing accuracy and speed",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-2),
            Deadline = DateTime.Now.AddMonths(2),
            ManagerId = 8,
            Documents = new List<Document>
            {
                new() { Id = 21, Name = "Billing Spec", Expenses = 600, Profit = 0 },
                new() { Id = 22, Name = "Test Cases", Expenses = 400, Profit = 0 }
            }
        },
        new Project
        {
            Id = 12,
            Name = "Security Audit",
            Description = "Third-party security audit and fixes",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddMonths(-7),
            Deadline = DateTime.Now.AddMonths(-3),
            ManagerId = 12,
            Documents = new List<Document>
            {
                new() { Id = 23, Name = "Audit Report", Expenses = 8000, Profit = 0 },
                new() { Id = 24, Name = "Mitigation Plan", Expenses = 2000, Profit = 0 }
            }
        },
        new Project
        {
            Id = 13,
            Name = "Data Warehouse",
            Description = "Consolidate analytics data into DW",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-11),
            Deadline = DateTime.Now.AddMonths(6),
            ManagerId = 14,
            Documents = new List<Document>
            {
                new() { Id = 25, Name = "Schema Design", Expenses = 3000, Profit = 0 },
                new() { Id = 26, Name = "ETL Pipelines", Expenses = 6000, Profit = 15000 },
                new() { Id = 27, Name = "Query Catalog", Expenses = 700, Profit = 0 }
            }
        },
        new Project
        {
            Id = 14,
            Name = "Social Media Drive",
            Description = "Boost presence on socials for brand awareness",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-1),
            Deadline = DateTime.Now.AddMonths(2),
            ManagerId = 15,
            Documents = new List<Document>
            {
                new() { Id = 28, Name = "Content Plan", Expenses = 800, Profit = 0 },
                new() { Id = 29, Name = "Ads Performance", Expenses = 4000, Profit = 2500 }
            }
        },
        new Project
        {
            Id = 15,
            Name = "Procurement Optimization",
            Description = "Reduce costs in procurement workflow",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-5),
            Deadline = null,
            ManagerId = 13,
            Documents = new List<Document>
            {
                new() { Id = 30, Name = "RFP Template", Expenses = 200, Profit = 0 }
            }
        },
        new Project
        {
            Id = 16,
            Name = "CX Improvements",
            Description = "Customer experience improvements based on NPS",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddYears(-1).AddMonths(-2),
            Deadline = DateTime.Now.AddYears(-1),
            ManagerId = 9,
            Documents = new List<Document>
            {
                new() { Id = 31, Name = "NPS Analysis", Expenses = 1200, Profit = 3000 },
                new() { Id = 32, Name = "Action Plan", Expenses = 600, Profit = 0 }
            }
        },
        new Project
        {
            Id = 17,
            Name = "AI Proof of Concept",
            Description = "Small POC for AI-based recommendations",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-30),
            Deadline = DateTime.Now.AddMonths(1),
            ManagerId = 14,
            Documents = new List<Document>
            {
                new() { Id = 33, Name = "POC Spec", Expenses = 2500, Profit = 0 },
                new() { Id = 34, Name = "Model Results", Expenses = 1500, Profit = 500 }
            }
        },
        new Project
        {
            Id = 18,
            Name = "Compliance Reporting",
            Description = "Regulatory compliance automation",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-9),
            Deadline = DateTime.Now.AddMonths(1),
            ManagerId = 16,
            Documents = new List<Document>
            {
                new() { Id = 35, Name = "Regulatory Spec", Expenses = 900, Profit = 0 },
                new() { Id = 36, Name = "Report Templates", Expenses = 400, Profit = 0 }
            }
        },
        new Project
        {
            Id = 19,
            Name = "Onboarding Portal",
            Description = "New employee onboarding portal & flow",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddMonths(-18),
            Deadline = DateTime.Now.AddMonths(-12),
            ManagerId = 11,
            Documents = new List<Document>
            {
                new() { Id = 37, Name = "Onboarding Flow", Expenses = 700, Profit = 0 },
                new() { Id = 38, Name = "Welcome Materials", Expenses = 300, Profit = 0 },
                new() { Id = 39, Name = "Usage Metrics", Expenses = 200, Profit = 1000 }
            }
        },
        new Project
        {
            Id = 20,
            Name = "Sustainability Initiative",
            Description = "Reduce energy consumption across offices",
            Status = ProjectStatus.Archived,
            CreatedAt = DateTime.Now.AddYears(-3),
            Deadline = DateTime.Now.AddYears(-2),
            ManagerId = 5,
            Documents = new List<Document>
            {
                new() { Id = 40, Name = "Energy Audit", Expenses = 5000, Profit = 0 },
                new() { Id = 41, Name = "Savings Report", Expenses = 1200, Profit = 7000 }
            }
        },
        new Project
        {
            Id = 21,
            Name = "Cloud Storage Migration",
            Description = "Move on-prem file storage to cloud",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-5),
            Deadline = DateTime.Now.AddMonths(1),
            ManagerId = 6,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 22,
            Name = "Customer Feedback Analyzer",
            Description = "ML system to classify customer feedback",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-30),
            Deadline = null,
            ManagerId = 1,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 23,
            Name = "Office WiFi Upgrade",
            Description = "Upgrade networking hardware",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddMonths(-9),
            Deadline = DateTime.Now.AddMonths(-3),
            ManagerId = 13,
            Documents = new List<Document>
            {
                new() { Id = 28, Name = "Hardware List", Expenses = 2500, Profit = 0 }
            }
        },
        new Project
        {
            Id = 24,
            Name = "New Landing Page",
            Description = "Marketing landing redesign",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-2),
            Deadline = DateTime.Now.AddMonths(2),
            ManagerId = 5,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 25,
            Name = "Internal Wiki",
            Description = "Knowledge base for employees",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-5),
            Deadline = null,
            ManagerId = 4,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 26,
            Name = "SaaS Billing Integration",
            Description = "Integrate new billing provider",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-4),
            Deadline = DateTime.Now.AddMonths(1),
            ManagerId = 3,
            Documents = new List<Document>
            {
                new() { Id = 29, Name = "Billing Provider Comparison", Expenses = 1200, Profit = 0 },
                new() { Id = 30, Name = "Integration Plan", Expenses = 2000, Profit = 4000 }
            }
        },
        new Project
        {
            Id = 27,
            Name = "Event Management App",
            Description = "Application for managing corporate events",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddMonths(-1),
            Deadline = null,
            ManagerId = 7,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 28,
            Name = "Vendor Portal Update",
            Description = "Update vendor portal UI components",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-3),
            Deadline = DateTime.Now.AddMonths(3),
            ManagerId = 2,
            Documents = new List<Document>
            {
                new() { Id = 31, Name = "UI Modernization Draft", Expenses = 800, Profit = 0 }
            }
        },
        new Project
        {
            Id = 29,
            Name = "Corporate Newsletter System",
            Description = "Tool for sending internal newsletters",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-2),
            Deadline = DateTime.Now.AddMonths(1),
            ManagerId = 8,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 30,
            Name = "Automated Onboarding",
            Description = "Automation of HR onboarding steps",
            Status = ProjectStatus.Completed,
            CreatedAt = DateTime.Now.AddMonths(-6),
            Deadline = DateTime.Now.AddMonths(-2),
            ManagerId = 4,
            Documents = new List<Document>
            {
                new() { Id = 32, Name = "Onboarding Workflow", Expenses = 1400, Profit = 3000 }
            }
        },
        new Project
        {
            Id = 31,
            Name = "Team Performance Analytics",
            Description = "Analytics for team efficiency",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-12),
            Deadline = null,
            ManagerId = 10,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 32,
            Name = "New Office Setup",
            Description = "Equipment and setup for new office",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-1),
            Deadline = DateTime.Now.AddMonths(5),
            ManagerId = 9,
            Documents = new List<Document>
            {
                new() { Id = 33, Name = "Office Plan", Expenses = 5000, Profit = 0 },
                new() { Id = 34, Name = "Equipment Budget", Expenses = 12000, Profit = 0 }
            }
        },
        new Project
        {
            Id = 33,
            Name = "Email Security Upgrade",
            Description = "Upgrade email security policies",
            Status = ProjectStatus.Draft,
            CreatedAt = DateTime.Now.AddDays(-7),
            Deadline = null,
            ManagerId = 11,
            Documents = new List<Document>() // ❗ без документов
        },
        new Project
        {
            Id = 34,
            Name = "Gamification Module",
            Description = "Gamification features for the employee portal",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-3),
            Deadline = DateTime.Now.AddMonths(4),
            ManagerId = 1,
            Documents = new List<Document>()
        },
        new Project
        {
            Id = 35,
            Name = "Client API v2",
            Description = "Rewrite external API v2",
            Status = ProjectStatus.InProgress,
            CreatedAt = DateTime.Now.AddMonths(-2),
            Deadline = DateTime.Now.AddMonths(6),
            ManagerId = 6,
            Documents = new List<Document>() // ❗ без документов
        }
    };

    static LinqData()
    {
        // Привязываем проекты к пользователям на основе логики ролей

        Users.First(u => u.Id == 1).Projects.AddRange(new[]
        {
            Projects[1], // Mobile App
            Projects[7], // Analytics Dashboard
            Projects[10] // UX/UI Revamp
        });

        Users.First(u => u.Id == 2).Projects.AddRange(new[]
        {
            Projects[0], // Internal CRM
            Projects[6], // Partner Portal
            Projects[11], // Security Audit
            Projects[14] // Performance Optimization
        });

        Users.First(u => u.Id == 3).Projects.AddRange(new[]
        {
            Projects[2], // Salary Automation
            Projects[10], // UX/UI Revamp (финансовые расчёты)
            Projects[15] // Internal Billing
        });

        Users.First(u => u.Id == 4).Projects.AddRange(new[]
        {
            Projects[3], // HR Training Program
            Projects[9] // Internal Survey System
        });

        Users.First(u => u.Id == 5).Projects.AddRange(new[]
        {
            Projects[4], // Ad Campaign 2025
            Projects[12], // Marketing Automation
            Projects[13] // Social Media Tracker
        });

        Users.First(u => u.Id == 6).Projects.AddRange(new[]
        {
            Projects[1], // Mobile App
            Projects[5], // Legacy Migration
            Projects[7], // Analytics Dashboard
            Projects[14] // Performance Optimization
        });

        Users.First(u => u.Id == 7).Projects.AddRange(new[]
        {
            Projects[0], // CRM
            Projects[5], // Migration
            Projects[14] // Performance Optimization
        });

        Users.First(u => u.Id == 8).Projects.AddRange(new[]
        {
            Projects[2], // Salary Automation
            Projects[15], // Billing
            Projects[9] // Survey (как заказчик)
        });

        Users.First(u => u.Id == 9).Projects.AddRange(new[]
        {
            Projects[6], // Partner Portal
            Projects[8], // Email Notifications
            Projects[11] // Security Audit
        });

        Users.First(u => u.Id == 10).Projects.AddRange(new[]
        {
            Projects[4], // Ad Campaign
            Projects[10], // UX/UI Revamp
            Projects[12], // Marketing Automation
            Projects[13] // Social Tracker
        });

        Users.First(u => u.Id == 11).Projects.AddRange(new[]
        {
            Projects[0], // CRM
            Projects[1], // Mobile App
            Projects[14], // Performance Optimization
            Projects[11] // Security Audit
        });

        Users.First(u => u.Id == 12).Projects.AddRange(new[]
        {
            Projects[10], // UX/UI Revamp
            Projects[7], // Dashboard
            Projects[8] // Email Notifications
        });

        Users.First(u => u.Id == 13).Projects.AddRange(new[]
        {
            Projects[5], // Migration
            Projects[11], // Security Audit
            Projects[8] // Email Service
        });

        Users.First(u => u.Id == 14).Projects.AddRange(new[]
        {
            Projects[3], // HR Program
            Projects[6], // Partner Portal
            Projects[13] // Social Media Tracker
        });

        Users.First(u => u.Id == 15).Projects.AddRange(new[]
        {
            Projects[0], // CRM
            Projects[8] // Email Service
        });
    }
}