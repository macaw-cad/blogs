//Author: Barend Emmerzaal
//b.emmerzaal@gmail.com
//linkedin.com/in/barendemmerzaal
//twitter.com/barendemmerzaal
//This is just an example project to get you started. You can use it anyway you like but any damage caused by using this is your own.
//The author of this solution is not responsible for anything in any way.

using Macaw.Foundation.Variants.NVelocityExtensions;
using Sitecore.XA.Foundation.Variants.Abstractions.Pipelines.GetVelocityTemplateRenderers;

namespace Macaw.Foundation.Variants.Pipelines.GetVelocityTemplateRenderers
{
    public class ReturnDates : IGetTemplateRenderersPipelineProcessor
    {
        public void Process(GetTemplateRenderersPipelineArgs args)
        {
            args.Context.Put("setdate", new SetDates());
        }
    }
}
