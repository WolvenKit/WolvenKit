using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSOwnerData : CVariable
	{
		[Ordinal(0)] [RED("id")] public gamePersistentID Id { get; set; }
		[Ordinal(1)] [RED("className")] public CName ClassName { get; set; }

		public PSOwnerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
