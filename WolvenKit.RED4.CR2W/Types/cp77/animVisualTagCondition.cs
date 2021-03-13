using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animVisualTagCondition : animIStaticCondition
	{
		[Ordinal(0)] [RED("visualTag")] public CName VisualTag { get; set; }

		public animVisualTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
