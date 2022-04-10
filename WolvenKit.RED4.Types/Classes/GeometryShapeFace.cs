using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GeometryShapeFace : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("indices")] 
		public CArray<CUInt32> Indices
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public GeometryShapeFace()
		{
			Indices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
