using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsSetAnimFeatureEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(1)]  [RED("animFeature")] public CHandle<animAnimFeature> AnimFeature { get; set; }
		[Ordinal(2)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }

		public scneventsSetAnimFeatureEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
