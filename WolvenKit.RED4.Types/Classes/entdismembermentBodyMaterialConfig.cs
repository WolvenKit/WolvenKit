using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentBodyMaterialConfig : RedBaseClass
	{
		private CEnum<physicsRagdollBodyPartE> _fleshBodyMask;
		private CEnum<physicsRagdollBodyPartE> _cyberBodyMask;

		[Ordinal(0)] 
		[RED("FleshBodyMask")] 
		public CEnum<physicsRagdollBodyPartE> FleshBodyMask
		{
			get => GetProperty(ref _fleshBodyMask);
			set => SetProperty(ref _fleshBodyMask, value);
		}

		[Ordinal(1)] 
		[RED("CyberBodyMask")] 
		public CEnum<physicsRagdollBodyPartE> CyberBodyMask
		{
			get => GetProperty(ref _cyberBodyMask);
			set => SetProperty(ref _cyberBodyMask, value);
		}
	}
}
