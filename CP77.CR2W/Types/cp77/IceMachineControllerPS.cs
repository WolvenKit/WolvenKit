using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IceMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(111)]  [RED("vendorTweakID")] public TweakDBID VendorTweakID { get; set; }
		[Ordinal(112)]  [RED("iceMachineSFX")] public IceMachineSFX IceMachineSFX { get; set; }

		public IceMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
