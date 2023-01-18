using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_State : animAnimNode_Container
	{
		[Ordinal(12)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("outTransitionIndices")] 
		public CArray<CInt16> OutTransitionIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(14)] 
		[RED("preventTransitionsInActivationFrame")] 
		public CBool PreventTransitionsInActivationFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(16)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimNode_State()
		{
			Id = 4294967295;
			Nodes = new();
			OutTransitionIndices = new();
			Tags = new();
			RequiredQualityDistanceCategory = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
