using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_Setup : CResource
	{
		[Ordinal(1)] 
		[RED("layers")] 
		public CArray<Multilayer_Layer> Layers
		{
			get => GetPropertyValue<CArray<Multilayer_Layer>>();
			set => SetPropertyValue<CArray<Multilayer_Layer>>(value);
		}

		[Ordinal(2)] 
		[RED("ratio")] 
		public CFloat Ratio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("useNormal")] 
		public CBool UseNormal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Multilayer_Setup()
		{
			Layers = new();
			Ratio = 1.000000F;
			UseNormal = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
