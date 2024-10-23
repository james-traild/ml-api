using Microsoft.AspNetCore.Mvc;

namespace MachineLearning.Api.Controllers
{
    public class TrainingRequest
    {
        public Guid Id { get; set; }
        public required string ModelType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Status
        {
            get
            {
                if (CompletedDate is not null)
                {
                    return "Completed";
                }
                if (StartedDate is not null && CompletedDate is null)
                {
                    return "Training";
                }
                return "Requested";
            }
        }
        /// <summary>
        /// Created model id 
        /// </summary>
        public Guid? ModelId { get; set; }
    }

    [Route("{tenantId}/v1/[controller]")]
    [ApiController]
    public class TrainingRequestsController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<TrainingRequest>> CreateTrainingRequest([FromBody] TrainingRequest trainingRequest, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<TrainingRequest>>> GetTrainingRequests(string tenantId, string modelType, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TrainingRequest>> GetTrainingRequestById(string tenantId, Guid requestId, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<TrainingRequest>> UpdateTrainingRequest([FromBody] TrainingRequest trainingRequest, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<TrainingRequest>> CancelTrainingRequest(string tenantId, Guid requestId, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }

}
