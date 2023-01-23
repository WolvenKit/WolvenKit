using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkIWidgetController : IScriptable
	{
		[Ordinal(0)] 
		[RED("audioMetadataName")] 
		public CName AudioMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkIWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
