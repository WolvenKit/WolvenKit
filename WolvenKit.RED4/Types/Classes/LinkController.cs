using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LinkController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(12)] 
		[RED("hoverColor")] 
		public HDRColor HoverColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(13)] 
		[RED("IGNORED_COLOR")] 
		public HDRColor IGNORED_COLOR
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public LinkController()
		{
			DefaultColor = new HDRColor();
			HoverColor = new HDRColor();
			IGNORED_COLOR = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
