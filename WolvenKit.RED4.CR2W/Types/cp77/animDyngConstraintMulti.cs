using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintMulti : animIDyngConstraint
	{
		[Ordinal(1)] [RED("innerConstraints")] public CArray<CHandle<animIDyngConstraint>> InnerConstraints { get; set; }

		public animDyngConstraintMulti(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
