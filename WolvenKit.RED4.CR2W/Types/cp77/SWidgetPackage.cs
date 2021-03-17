using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackage : SWidgetPackageBase
	{
		private CString _displayName;
		private gamePersistentID _ownerID;
		private CName _ownerIDClassName;
		private CHandle<WidgetCustomData> _customData;
		private CBool _isWidgetInactive;
		private CEnum<EWidgetState> _widgetState;
		private CName _iconID;
		private TweakDBID _bckgroundTextureID;
		private TweakDBID _iconTextureID;
		private CHandle<textTextParameterSet> _textData;

		[Ordinal(7)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(8)] 
		[RED("ownerID")] 
		public gamePersistentID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(9)] 
		[RED("ownerIDClassName")] 
		public CName OwnerIDClassName
		{
			get => GetProperty(ref _ownerIDClassName);
			set => SetProperty(ref _ownerIDClassName, value);
		}

		[Ordinal(10)] 
		[RED("customData")] 
		public CHandle<WidgetCustomData> CustomData
		{
			get => GetProperty(ref _customData);
			set => SetProperty(ref _customData, value);
		}

		[Ordinal(11)] 
		[RED("isWidgetInactive")] 
		public CBool IsWidgetInactive
		{
			get => GetProperty(ref _isWidgetInactive);
			set => SetProperty(ref _isWidgetInactive, value);
		}

		[Ordinal(12)] 
		[RED("widgetState")] 
		public CEnum<EWidgetState> WidgetState
		{
			get => GetProperty(ref _widgetState);
			set => SetProperty(ref _widgetState, value);
		}

		[Ordinal(13)] 
		[RED("iconID")] 
		public CName IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		[Ordinal(14)] 
		[RED("bckgroundTextureID")] 
		public TweakDBID BckgroundTextureID
		{
			get => GetProperty(ref _bckgroundTextureID);
			set => SetProperty(ref _bckgroundTextureID, value);
		}

		[Ordinal(15)] 
		[RED("iconTextureID")] 
		public TweakDBID IconTextureID
		{
			get => GetProperty(ref _iconTextureID);
			set => SetProperty(ref _iconTextureID, value);
		}

		[Ordinal(16)] 
		[RED("textData")] 
		public CHandle<textTextParameterSet> TextData
		{
			get => GetProperty(ref _textData);
			set => SetProperty(ref _textData, value);
		}

		public SWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
