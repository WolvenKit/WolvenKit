using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animConditionalSegmentCondition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lod")] 
		public CInt32 Lod
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("group")] 
		public CName Group
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("animFeatureValue")] 
		public CBool AnimFeatureValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animConditionalSegmentCondition()
		{
			Lod = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
