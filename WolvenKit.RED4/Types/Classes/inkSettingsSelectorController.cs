using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkSettingsSelectorController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("LabelText")] 
		public inkTextWidgetReference LabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ModifiedFlag")] 
		public inkTextWidgetReference ModifiedFlag
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("Raycaster")] 
		public inkWidgetReference Raycaster
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("hoverGeneralHighlight")] 
		public inkWidgetReference HoverGeneralHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("indentMarker")] 
		public inkWidgetReference IndentMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("SettingsEntry")] 
		public CWeakHandle<userSettingsVar> SettingsEntry
		{
			get => GetPropertyValue<CWeakHandle<userSettingsVar>>();
			set => SetPropertyValue<CWeakHandle<userSettingsVar>>(value);
		}

		[Ordinal(9)] 
		[RED("hoveredChildren")] 
		public CArray<CWeakHandle<inkWidget>> HoveredChildren
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(10)] 
		[RED("IsPreGame")] 
		public CBool IsPreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("varGroupPath")] 
		public CName VarGroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("varName")] 
		public CName VarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("additionalText")] 
		public CName AdditionalText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("hoverInAnim")] 
		public CHandle<inkanimProxy> HoverInAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("hoverOutAnim")] 
		public CHandle<inkanimProxy> HoverOutAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public inkSettingsSelectorController()
		{
			LabelText = new inkTextWidgetReference();
			ModifiedFlag = new inkTextWidgetReference();
			Raycaster = new inkWidgetReference();
			OptionSwitchHint = new inkWidgetReference();
			HoverGeneralHighlight = new inkWidgetReference();
			Container = new inkWidgetReference();
			IndentMarker = new inkWidgetReference();
			HoveredChildren = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
