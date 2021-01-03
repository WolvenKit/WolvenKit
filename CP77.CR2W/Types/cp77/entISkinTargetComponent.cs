using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entISkinTargetComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("skinning")] public CHandle<entSkinningBinding> Skinning { get; set; }
		[Ordinal(1)]  [RED("useSkinningLOD")] public CBool UseSkinningLOD { get; set; }

		public entISkinTargetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
