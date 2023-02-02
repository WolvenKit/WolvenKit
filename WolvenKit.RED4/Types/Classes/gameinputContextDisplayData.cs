using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinputContextDisplayData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<gameinputActionDisplayData> Actions
		{
			get => GetPropertyValue<CArray<gameinputActionDisplayData>>();
			set => SetPropertyValue<CArray<gameinputActionDisplayData>>(value);
		}

		public gameinputContextDisplayData()
		{
			Actions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
