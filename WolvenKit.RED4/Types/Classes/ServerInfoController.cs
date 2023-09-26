using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ServerInfoController : inkListItemController
	{
		[Ordinal(19)] 
		[RED("settingsListCtrl")] 
		public CWeakHandle<inkListController> SettingsListCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(20)] 
		[RED("number")] 
		public CWeakHandle<inkTextWidget> Number
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("numberPath")] 
		public CName NumberPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("kind")] 
		public CWeakHandle<inkTextWidget> Kind
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("kindPath")] 
		public CName KindPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("hostname")] 
		public CWeakHandle<inkTextWidget> Hostname
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("hostnamePath")] 
		public CName HostnamePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("address")] 
		public CWeakHandle<inkTextWidget> Address
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("addressPath")] 
		public CName AddressPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("worldDescription")] 
		public CWeakHandle<inkTextWidget> WorldDescription
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("worldDescriptionPath")] 
		public CName WorldDescriptionPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("background")] 
		public CWeakHandle<inkImageWidget> Background
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(31)] 
		[RED("c_selectionColor")] 
		public CColor C_selectionColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(32)] 
		[RED("c_initialColor")] 
		public HDRColor C_initialColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(33)] 
		[RED("c_markColor")] 
		public HDRColor C_markColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(34)] 
		[RED("marked")] 
		public CBool Marked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ServerInfoController()
		{
			C_selectionColor = new CColor();
			C_initialColor = new HDRColor();
			C_markColor = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
