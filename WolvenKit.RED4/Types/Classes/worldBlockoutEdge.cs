using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBlockoutEdge : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("points", 2)] 
		public CArrayFixedSize<CUInt32> Points
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("areas", 2)] 
		public CArrayFixedSize<CUInt32> Areas
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldBlockoutEdge()
		{
			Points = new(2);
			Areas = new(2);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
