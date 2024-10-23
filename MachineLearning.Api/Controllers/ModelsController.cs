using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MachineLearning.Api.Controllers
{
    public static class ModelTypes
    {
        public const string PdfClassifier = "PdfClassifier";
        public const string Assignee = "Assignee";
    }

    public class MlModel
    {
        public Guid Id { get; set; }
        // model type from the ModelTypes list
        public required string ModelType { get; set; }
        // name of file in cloud storage.
        // location of model is "{tenantId}/models/{modelName}"
        // location of labels is "{tenantId}/models/{modelName}-labels.json"
        public required string Name { get; set; }
        // Accuracy at the time of training
        public int Accuracy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class MlModelCollection
    {
        // Name of current model
        public string? ActiveModelFileName { get; set; }
        // All models 
        public List<MlModel> Models { get; set; } = [];
    }

    [Route("{tenantId}/v1/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<MlModel>> GetModel(string tenantId, [Required] string modelType, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{modelId}")]
        public async Task<ActionResult<MlModel>> GetModelById(string tenantId, [Required] Guid modelId, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{modelId}")]
        public async Task<ActionResult> DeleteModel(string tenantId, [Required] Guid modelId, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
