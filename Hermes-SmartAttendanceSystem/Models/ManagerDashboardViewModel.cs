using System;
using System.Collections.Generic;

namespace Hermes_SmartAttendanceSystem.Models
{
    public class ManagerDashboardViewModel
    {
        public int TotalEmployees { get; set; }
        public int ShiftsToday { get; set; }
        public int LateEmployees { get; set; }
        public int PendingRequests { get; set; }
        public string ManagerName { get; set; }
        public List<RecentActivity> RecentActivities { get; set; } = new List<RecentActivity>(); // ✅ Add this
        public List<ShiftEvent> ShiftCalendarEvents { get; set; } = new List<ShiftEvent>();
    }

    public class ActivityItem
    {
        public string Message { get; set; }
        public string Type { get; set; } // e.g., "checkin", "late", "request"
        public DateTime Time { get; set; }
    }

    public class ShiftEvent
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string BackgroundColor { get; set; }
    }

    public class RecentActivity
    {

        public string Type { get; set; }     // e.g., "checkin", "late", or "info"
        public string Message { get; set; }  // Message to display
    
    }


    
}
