using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IceMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(0)]  [RED("iceMachineSFX")] public IceMachineSFX IceMachineSFX { get; set; }
		[Ordinal(1)]  [RED("vendorTweakID")] public TweakDBID VendorTweakID { get; set; }

		public IceMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
