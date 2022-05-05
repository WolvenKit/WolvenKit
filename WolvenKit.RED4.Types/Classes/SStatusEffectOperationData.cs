using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SStatusEffectOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("effect")] 
		public gameStatusEffectTDBPicker Effect
		{
			get => GetPropertyValue<gameStatusEffectTDBPicker>();
			set => SetPropertyValue<gameStatusEffectTDBPicker>(value);
		}

		public SStatusEffectOperationData()
		{
			Range = 1.000000F;
			Offset = new();
			Effect = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
