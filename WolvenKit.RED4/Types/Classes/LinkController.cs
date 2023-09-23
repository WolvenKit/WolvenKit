using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LinkController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(15)] 
		[RED("hoverColor")] 
		public HDRColor HoverColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(16)] 
		[RED("IGNORED_COLOR")] 
		public HDRColor IGNORED_COLOR
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public LinkController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
