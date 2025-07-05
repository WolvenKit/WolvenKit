using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBlockoutAreaOutline : ISerializable
	{
		[Ordinal(0)] 
		[RED("points")] 
		public CArray<CUInt32> Points
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<CUInt32> Edges
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public worldBlockoutAreaOutline()
		{
			Points = new();
			Edges = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
