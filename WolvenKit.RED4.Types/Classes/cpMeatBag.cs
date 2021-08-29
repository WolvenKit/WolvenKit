using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpMeatBag : gameObject
	{
		private CFloat _rotationLerpFactor;
		private CName _kinematicBodyBoneName;
		private CName _bagBodyBoneName;
		private CName _physicalComponentName;
		private CName _bagHitComponentName;
		private CName _bagDestroyComponentName;
		private CName _destructionEffectName;
		private CName _jiggleEffectName;

		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetProperty(ref _rotationLerpFactor);
			set => SetProperty(ref _rotationLerpFactor, value);
		}

		[Ordinal(41)] 
		[RED("kinematicBodyBoneName")] 
		public CName KinematicBodyBoneName
		{
			get => GetProperty(ref _kinematicBodyBoneName);
			set => SetProperty(ref _kinematicBodyBoneName, value);
		}

		[Ordinal(42)] 
		[RED("bagBodyBoneName")] 
		public CName BagBodyBoneName
		{
			get => GetProperty(ref _bagBodyBoneName);
			set => SetProperty(ref _bagBodyBoneName, value);
		}

		[Ordinal(43)] 
		[RED("physicalComponentName")] 
		public CName PhysicalComponentName
		{
			get => GetProperty(ref _physicalComponentName);
			set => SetProperty(ref _physicalComponentName, value);
		}

		[Ordinal(44)] 
		[RED("bagHitComponentName")] 
		public CName BagHitComponentName
		{
			get => GetProperty(ref _bagHitComponentName);
			set => SetProperty(ref _bagHitComponentName, value);
		}

		[Ordinal(45)] 
		[RED("bagDestroyComponentName")] 
		public CName BagDestroyComponentName
		{
			get => GetProperty(ref _bagDestroyComponentName);
			set => SetProperty(ref _bagDestroyComponentName, value);
		}

		[Ordinal(46)] 
		[RED("destructionEffectName")] 
		public CName DestructionEffectName
		{
			get => GetProperty(ref _destructionEffectName);
			set => SetProperty(ref _destructionEffectName, value);
		}

		[Ordinal(47)] 
		[RED("jiggleEffectName")] 
		public CName JiggleEffectName
		{
			get => GetProperty(ref _jiggleEffectName);
			set => SetProperty(ref _jiggleEffectName, value);
		}
	}
}
