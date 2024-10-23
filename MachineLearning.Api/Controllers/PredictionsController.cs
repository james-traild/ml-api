using Microsoft.AspNetCore.Mvc;

namespace MachineLearning.Api.Controllers
{
    public class VendorScore(string vendorId, decimal score)
    {
        public string VendorId { get; set; } = vendorId;
        public decimal Score { get; set; } = score;
    }

    public class UserScore(string userId, decimal score)
    {
        public string UserId { get; set; } = userId;
        public decimal Score { get; set; } = score;
    }

    [Route("{tenantId}/v1/[controller]")]
    [ApiController]
    public class PredictionsController : ControllerBase
    {
        [HttpGet]
        [Route("pdf-classification")]
        public async Task<ActionResult<List<VendorScore>>> GetPdfClassification(string tenantId, string invoiceId, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet]
        [Route("assignee")]
        public async Task<ActionResult<List<UserScore>>> GetAssignee(string tenantId, string invoiceId, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
