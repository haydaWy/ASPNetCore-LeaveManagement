using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Persistence.Contracts
{
   public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
        Task<LeaveRequest> GetLeaveRequestsWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
    }
}
