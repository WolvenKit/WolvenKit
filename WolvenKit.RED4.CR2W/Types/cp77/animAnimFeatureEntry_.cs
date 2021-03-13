using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureEntry_ : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("className")] public CName ClassName { get; set; }
		[Ordinal(2)] [RED("forceAllocate")] public CBool ForceAllocate { get; set; }

		public animAnimFeatureEntry_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
