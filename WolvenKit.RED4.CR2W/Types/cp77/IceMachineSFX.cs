using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineSFX : VendingMachineSFX
	{
		[Ordinal(2)] [RED("iceFalls")] public CName IceFalls { get; set; }
		[Ordinal(3)] [RED("processing")] public CName Processing { get; set; }

		public IceMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
