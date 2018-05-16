using System.Collections.Generic;
using Newtonsoft.Json;

namespace Callway.ConsoleApplication.Entities {
    public class ProjectDto {
        [JsonProperty(PropertyName = "projectViewDto")]
        public IList<ProjectViewDto> ProjectViews { get; set; }




        public ProjectDto() {
            ProjectViews = new List<ProjectViewDto>();
        }
    }
}
