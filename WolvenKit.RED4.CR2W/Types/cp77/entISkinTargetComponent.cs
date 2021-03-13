using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entISkinTargetComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("skinning")] public CHandle<entSkinningBinding> Skinning { get; set; }
		[Ordinal(9)] [RED("useSkinningLOD")] public CBool UseSkinningLOD { get; set; }

		public entISkinTargetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
