using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_State : animAnimNode_Container
	{
		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("outTransitionIndices")] 
		public CArray<CInt16> OutTransitionIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(4)] 
		[RED("preventTransitionsInActivationFrame")] 
		public CBool PreventTransitionsInActivationFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimNode_State()
		{
			Id = uint.MaxValue;
			Nodes = new();
			OutTransitionIndices = new();
			Tags = new();
			RequiredQualityDistanceCategory = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
