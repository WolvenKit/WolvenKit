using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private ActivatedDeviceAnimSetup _animationSetup;
		private ActivatedDeviceSetup _activatedDeviceSetup;
		private NodeRef _spiderbotInteractionLocationOverride;
		private CInt32 _industrialArmAnimationOverride;

		[Ordinal(104)] 
		[RED("animationSetup")] 
		public ActivatedDeviceAnimSetup AnimationSetup
		{
			get => GetProperty(ref _animationSetup);
			set => SetProperty(ref _animationSetup, value);
		}

		[Ordinal(105)] 
		[RED("activatedDeviceSetup")] 
		public ActivatedDeviceSetup ActivatedDeviceSetup
		{
			get => GetProperty(ref _activatedDeviceSetup);
			set => SetProperty(ref _activatedDeviceSetup, value);
		}

		[Ordinal(106)] 
		[RED("spiderbotInteractionLocationOverride")] 
		public NodeRef SpiderbotInteractionLocationOverride
		{
			get => GetProperty(ref _spiderbotInteractionLocationOverride);
			set => SetProperty(ref _spiderbotInteractionLocationOverride, value);
		}

		[Ordinal(107)] 
		[RED("industrialArmAnimationOverride")] 
		public CInt32 IndustrialArmAnimationOverride
		{
			get => GetProperty(ref _industrialArmAnimationOverride);
			set => SetProperty(ref _industrialArmAnimationOverride, value);
		}

		public ActivatedDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
