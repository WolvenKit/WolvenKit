using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDamageOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SDamageOperationData()
		{
			Range = -1.000000F;
			Offset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
