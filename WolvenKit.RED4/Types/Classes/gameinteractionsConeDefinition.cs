using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsConeDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)] 
		[RED("pos1")] 
		public Vector4 Pos1
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("pos2")] 
		public Vector4 Pos2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("radius1")] 
		public CFloat Radius1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("radius2")] 
		public CFloat Radius2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinteractionsConeDefinition()
		{
			Pos1 = new Vector4 { W = 1.000000F };
			Pos2 = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
