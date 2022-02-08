using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpMeatBag : gameObject
	{
		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("kinematicBodyBoneName")] 
		public CName KinematicBodyBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("bagBodyBoneName")] 
		public CName BagBodyBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(43)] 
		[RED("physicalComponentName")] 
		public CName PhysicalComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("bagHitComponentName")] 
		public CName BagHitComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(45)] 
		[RED("bagDestroyComponentName")] 
		public CName BagDestroyComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("destructionEffectName")] 
		public CName DestructionEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(47)] 
		[RED("jiggleEffectName")] 
		public CName JiggleEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public cpMeatBag()
		{
			RotationLerpFactor = 0.100000F;
		}
	}
}
