using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetArgumentName : SetArguments
	{
		[Ordinal(1)] [RED("customVar")] public CName CustomVar { get; set; }

		public SetArgumentName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
