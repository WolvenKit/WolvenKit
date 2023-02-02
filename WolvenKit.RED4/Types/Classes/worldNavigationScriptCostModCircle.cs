using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationScriptCostModCircle : IScriptable
	{
		[Ordinal(0)] 
		[RED("pos")] 
		public Vector4 Pos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("cost")] 
		public CFloat Cost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldNavigationScriptCostModCircle()
		{
			Pos = new();
			Cost = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
