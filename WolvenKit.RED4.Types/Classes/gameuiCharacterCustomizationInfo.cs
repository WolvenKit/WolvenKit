using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationInfo : IScriptable
	{
		private CName _name;
		private CName _uiSlot;
		private CString _localizedName;
		private CInt32 _defaultIndex;
		private CInt32 _index;
		private CBool _hidden;
		private CBool _enabled;
		private CName _link;
		private CBool _linkController;
		private CEnum<CensorshipFlags> _censorFlag;
		private CEnum<gameuiCharacterCustomizationActionType> _censorFlagAction;
		private CArray<gameuiCharacterCustomizationAction> _onDeactivateActions;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("uiSlot")] 
		public CName UiSlot
		{
			get => GetProperty(ref _uiSlot);
			set => SetProperty(ref _uiSlot, value);
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(3)] 
		[RED("defaultIndex")] 
		public CInt32 DefaultIndex
		{
			get => GetProperty(ref _defaultIndex);
			set => SetProperty(ref _defaultIndex, value);
		}

		[Ordinal(4)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(5)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetProperty(ref _hidden);
			set => SetProperty(ref _hidden, value);
		}

		[Ordinal(6)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(7)] 
		[RED("link")] 
		public CName Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(8)] 
		[RED("linkController")] 
		public CBool LinkController
		{
			get => GetProperty(ref _linkController);
			set => SetProperty(ref _linkController, value);
		}

		[Ordinal(9)] 
		[RED("censorFlag")] 
		public CEnum<CensorshipFlags> CensorFlag
		{
			get => GetProperty(ref _censorFlag);
			set => SetProperty(ref _censorFlag, value);
		}

		[Ordinal(10)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get => GetProperty(ref _censorFlagAction);
			set => SetProperty(ref _censorFlagAction, value);
		}

		[Ordinal(11)] 
		[RED("onDeactivateActions")] 
		public CArray<gameuiCharacterCustomizationAction> OnDeactivateActions
		{
			get => GetProperty(ref _onDeactivateActions);
			set => SetProperty(ref _onDeactivateActions, value);
		}
	}
}
