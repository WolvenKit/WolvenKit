using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtRef : CVariable
	{
		[Ordinal(0)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)] [RED("part")] public CName Part { get; set; }

		public animLookAtRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
