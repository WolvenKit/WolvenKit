using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageToken_Name : toolsIMessageToken
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public toolsMessageToken_Name()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
