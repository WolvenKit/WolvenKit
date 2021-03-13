using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Interaction : animAnimFeature
	{
		[Ordinal(0)] [RED("interactionDuration")] public CFloat InteractionDuration { get; set; }
		[Ordinal(1)] [RED("interactionStage")] public CInt32 InteractionStage { get; set; }

		public animAnimFeature_Interaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
