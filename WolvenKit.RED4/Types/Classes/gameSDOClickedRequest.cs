using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSDOClickedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("fullPath")] 
		public CName FullPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameSDOClickedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
