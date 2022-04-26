using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpMeatBag : gameObject
	{
		[Ordinal(35)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("kinematicBodyBoneName")] 
		public CName KinematicBodyBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("bagBodyBoneName")] 
		public CName BagBodyBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("physicalComponentName")] 
		public CName PhysicalComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(39)] 
		[RED("bagHitComponentName")] 
		public CName BagHitComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("bagDestroyComponentName")] 
		public CName BagDestroyComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("destructionEffectName")] 
		public CName DestructionEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("jiggleEffectName")] 
		public CName JiggleEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public cpMeatBag()
		{
			RotationLerpFactor = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
