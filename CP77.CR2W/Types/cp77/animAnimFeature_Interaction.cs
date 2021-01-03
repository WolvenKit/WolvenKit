using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Interaction : animAnimFeature
	{
		[Ordinal(0)]  [RED("interactionDuration")] public CFloat InteractionDuration { get; set; }
		[Ordinal(1)]  [RED("interactionStage")] public CInt32 InteractionStage { get; set; }

		public animAnimFeature_Interaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
