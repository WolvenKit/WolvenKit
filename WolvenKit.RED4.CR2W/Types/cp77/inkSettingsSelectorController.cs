using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorController : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelText;
		private inkTextWidgetReference _modifiedFlag;
		private inkWidgetReference _raycaster;
		private inkWidgetReference _optionSwitchHint;
		private inkWidgetReference _hoverGeneralHighlight;
		private inkWidgetReference _container;
		private wCHandle<userSettingsVar> _settingsEntry;
		private CArray<wCHandle<inkWidget>> _hoveredChildren;
		private CBool _isPreGame;
		private CName _varGroupPath;
		private CName _varName;
		private CName _additionalText;
		private CHandle<inkanimProxy> _hoverInAnim;
		private CHandle<inkanimProxy> _hoverOutAnim;

		[Ordinal(1)] 
		[RED("LabelText")] 
		public inkTextWidgetReference LabelText
		{
			get => GetProperty(ref _labelText);
			set => SetProperty(ref _labelText, value);
		}

		[Ordinal(2)] 
		[RED("ModifiedFlag")] 
		public inkTextWidgetReference ModifiedFlag
		{
			get => GetProperty(ref _modifiedFlag);
			set => SetProperty(ref _modifiedFlag, value);
		}

		[Ordinal(3)] 
		[RED("Raycaster")] 
		public inkWidgetReference Raycaster
		{
			get => GetProperty(ref _raycaster);
			set => SetProperty(ref _raycaster, value);
		}

		[Ordinal(4)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetProperty(ref _optionSwitchHint);
			set => SetProperty(ref _optionSwitchHint, value);
		}

		[Ordinal(5)] 
		[RED("hoverGeneralHighlight")] 
		public inkWidgetReference HoverGeneralHighlight
		{
			get => GetProperty(ref _hoverGeneralHighlight);
			set => SetProperty(ref _hoverGeneralHighlight, value);
		}

		[Ordinal(6)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(7)] 
		[RED("SettingsEntry")] 
		public wCHandle<userSettingsVar> SettingsEntry
		{
			get => GetProperty(ref _settingsEntry);
			set => SetProperty(ref _settingsEntry, value);
		}

		[Ordinal(8)] 
		[RED("hoveredChildren")] 
		public CArray<wCHandle<inkWidget>> HoveredChildren
		{
			get => GetProperty(ref _hoveredChildren);
			set => SetProperty(ref _hoveredChildren, value);
		}

		[Ordinal(9)] 
		[RED("IsPreGame")] 
		public CBool IsPreGame
		{
			get => GetProperty(ref _isPreGame);
			set => SetProperty(ref _isPreGame, value);
		}

		[Ordinal(10)] 
		[RED("varGroupPath")] 
		public CName VarGroupPath
		{
			get => GetProperty(ref _varGroupPath);
			set => SetProperty(ref _varGroupPath, value);
		}

		[Ordinal(11)] 
		[RED("varName")] 
		public CName VarName
		{
			get => GetProperty(ref _varName);
			set => SetProperty(ref _varName, value);
		}

		[Ordinal(12)] 
		[RED("additionalText")] 
		public CName AdditionalText
		{
			get => GetProperty(ref _additionalText);
			set => SetProperty(ref _additionalText, value);
		}

		[Ordinal(13)] 
		[RED("hoverInAnim")] 
		public CHandle<inkanimProxy> HoverInAnim
		{
			get => GetProperty(ref _hoverInAnim);
			set => SetProperty(ref _hoverInAnim, value);
		}

		[Ordinal(14)] 
		[RED("hoverOutAnim")] 
		public CHandle<inkanimProxy> HoverOutAnim
		{
			get => GetProperty(ref _hoverOutAnim);
			set => SetProperty(ref _hoverOutAnim, value);
		}

		public inkSettingsSelectorController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
