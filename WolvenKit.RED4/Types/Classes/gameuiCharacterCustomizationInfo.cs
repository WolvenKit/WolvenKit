using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiCharacterCustomizationInfo : IScriptable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("uiSlot")] 
		public CName UiSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("defaultIndex")] 
		public CInt32 DefaultIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("link")] 
		public CName Link
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("linkController")] 
		public CBool LinkController
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("editTags")] 
		public CArray<CEnum<gameuiCharacterCustomizationEditTag>> EditTags
		{
			get => GetPropertyValue<CArray<CEnum<gameuiCharacterCustomizationEditTag>>>();
			set => SetPropertyValue<CArray<CEnum<gameuiCharacterCustomizationEditTag>>>(value);
		}

		[Ordinal(10)] 
		[RED("censorFlag")] 
		public CBitField<CensorshipFlags> CensorFlag
		{
			get => GetPropertyValue<CBitField<CensorshipFlags>>();
			set => SetPropertyValue<CBitField<CensorshipFlags>>(value);
		}

		[Ordinal(11)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>(value);
		}

		[Ordinal(12)] 
		[RED("onDeactivateActions")] 
		public CArray<gameuiCharacterCustomizationAction> OnDeactivateActions
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationAction>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationAction>>(value);
		}

		[Ordinal(13)] 
		[RED("randomizeCategory")] 
		public CEnum<gamedataCharacterRandomizationCategory> RandomizeCategory
		{
			get => GetPropertyValue<CEnum<gamedataCharacterRandomizationCategory>>();
			set => SetPropertyValue<CEnum<gamedataCharacterRandomizationCategory>>(value);
		}

		public gameuiCharacterCustomizationInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
