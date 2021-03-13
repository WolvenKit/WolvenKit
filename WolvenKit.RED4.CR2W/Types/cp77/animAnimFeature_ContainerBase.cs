using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ContainerBase : animAnimFeature
	{
		[Ordinal(0)] [RED("opened")] public CBool Opened { get; set; }
		[Ordinal(1)] [RED("transitionDuration")] public CFloat TransitionDuration { get; set; }

		public animAnimFeature_ContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
