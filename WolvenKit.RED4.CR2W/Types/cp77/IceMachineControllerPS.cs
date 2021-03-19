using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineControllerPS : VendingMachineControllerPS
	{
		private TweakDBID _vendorTweakID;
		private IceMachineSFX _iceMachineSFX;

		[Ordinal(111)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetProperty(ref _vendorTweakID);
			set => SetProperty(ref _vendorTweakID, value);
		}

		[Ordinal(112)] 
		[RED("iceMachineSFX")] 
		public IceMachineSFX IceMachineSFX
		{
			get => GetProperty(ref _iceMachineSFX);
			set => SetProperty(ref _iceMachineSFX, value);
		}

		public IceMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
