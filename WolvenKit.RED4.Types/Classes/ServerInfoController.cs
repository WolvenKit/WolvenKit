using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ServerInfoController : inkListItemController
	{
		private CWeakHandle<inkListController> _settingsListCtrl;
		private CWeakHandle<inkTextWidget> _number;
		private CName _numberPath;
		private CWeakHandle<inkTextWidget> _kind;
		private CName _kindPath;
		private CWeakHandle<inkTextWidget> _hostname;
		private CName _hostnamePath;
		private CWeakHandle<inkTextWidget> _address;
		private CName _addressPath;
		private CWeakHandle<inkTextWidget> _worldDescription;
		private CName _worldDescriptionPath;
		private CWeakHandle<inkImageWidget> _background;
		private CColor _c_selectionColor;
		private HDRColor _c_initialColor;
		private HDRColor _c_markColor;
		private CBool _marked;

		[Ordinal(16)] 
		[RED("settingsListCtrl")] 
		public CWeakHandle<inkListController> SettingsListCtrl
		{
			get => GetProperty(ref _settingsListCtrl);
			set => SetProperty(ref _settingsListCtrl, value);
		}

		[Ordinal(17)] 
		[RED("number")] 
		public CWeakHandle<inkTextWidget> Number
		{
			get => GetProperty(ref _number);
			set => SetProperty(ref _number, value);
		}

		[Ordinal(18)] 
		[RED("numberPath")] 
		public CName NumberPath
		{
			get => GetProperty(ref _numberPath);
			set => SetProperty(ref _numberPath, value);
		}

		[Ordinal(19)] 
		[RED("kind")] 
		public CWeakHandle<inkTextWidget> Kind
		{
			get => GetProperty(ref _kind);
			set => SetProperty(ref _kind, value);
		}

		[Ordinal(20)] 
		[RED("kindPath")] 
		public CName KindPath
		{
			get => GetProperty(ref _kindPath);
			set => SetProperty(ref _kindPath, value);
		}

		[Ordinal(21)] 
		[RED("hostname")] 
		public CWeakHandle<inkTextWidget> Hostname
		{
			get => GetProperty(ref _hostname);
			set => SetProperty(ref _hostname, value);
		}

		[Ordinal(22)] 
		[RED("hostnamePath")] 
		public CName HostnamePath
		{
			get => GetProperty(ref _hostnamePath);
			set => SetProperty(ref _hostnamePath, value);
		}

		[Ordinal(23)] 
		[RED("address")] 
		public CWeakHandle<inkTextWidget> Address
		{
			get => GetProperty(ref _address);
			set => SetProperty(ref _address, value);
		}

		[Ordinal(24)] 
		[RED("addressPath")] 
		public CName AddressPath
		{
			get => GetProperty(ref _addressPath);
			set => SetProperty(ref _addressPath, value);
		}

		[Ordinal(25)] 
		[RED("worldDescription")] 
		public CWeakHandle<inkTextWidget> WorldDescription
		{
			get => GetProperty(ref _worldDescription);
			set => SetProperty(ref _worldDescription, value);
		}

		[Ordinal(26)] 
		[RED("worldDescriptionPath")] 
		public CName WorldDescriptionPath
		{
			get => GetProperty(ref _worldDescriptionPath);
			set => SetProperty(ref _worldDescriptionPath, value);
		}

		[Ordinal(27)] 
		[RED("background")] 
		public CWeakHandle<inkImageWidget> Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(28)] 
		[RED("c_selectionColor")] 
		public CColor C_selectionColor
		{
			get => GetProperty(ref _c_selectionColor);
			set => SetProperty(ref _c_selectionColor, value);
		}

		[Ordinal(29)] 
		[RED("c_initialColor")] 
		public HDRColor C_initialColor
		{
			get => GetProperty(ref _c_initialColor);
			set => SetProperty(ref _c_initialColor, value);
		}

		[Ordinal(30)] 
		[RED("c_markColor")] 
		public HDRColor C_markColor
		{
			get => GetProperty(ref _c_markColor);
			set => SetProperty(ref _c_markColor, value);
		}

		[Ordinal(31)] 
		[RED("marked")] 
		public CBool Marked
		{
			get => GetProperty(ref _marked);
			set => SetProperty(ref _marked, value);
		}
	}
}
