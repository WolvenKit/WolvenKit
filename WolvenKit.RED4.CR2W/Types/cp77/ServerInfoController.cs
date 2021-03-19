using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ServerInfoController : inkListItemController
	{
		private wCHandle<inkListController> _settingsListCtrl;
		private wCHandle<inkTextWidget> _number;
		private CName _numberPath;
		private wCHandle<inkTextWidget> _kind;
		private CName _kindPath;
		private wCHandle<inkTextWidget> _hostname;
		private CName _hostnamePath;
		private wCHandle<inkTextWidget> _address;
		private CName _addressPath;
		private wCHandle<inkTextWidget> _worldDescription;
		private CName _worldDescriptionPath;
		private wCHandle<inkImageWidget> _background;
		private CColor _c_selectionColor;
		private HDRColor _c_initialColor;
		private HDRColor _c_markColor;
		private CBool _marked;

		[Ordinal(16)] 
		[RED("settingsListCtrl")] 
		public wCHandle<inkListController> SettingsListCtrl
		{
			get => GetProperty(ref _settingsListCtrl);
			set => SetProperty(ref _settingsListCtrl, value);
		}

		[Ordinal(17)] 
		[RED("number")] 
		public wCHandle<inkTextWidget> Number
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
		public wCHandle<inkTextWidget> Kind
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
		public wCHandle<inkTextWidget> Hostname
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
		public wCHandle<inkTextWidget> Address
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
		public wCHandle<inkTextWidget> WorldDescription
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
		public wCHandle<inkImageWidget> Background
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

		public ServerInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
