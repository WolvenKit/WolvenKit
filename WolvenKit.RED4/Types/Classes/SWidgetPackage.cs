using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWidgetPackage : SWidgetPackageBase
	{
		[Ordinal(8)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("ownerID")] 
		public gamePersistentID OwnerID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(10)] 
		[RED("ownerIDClassName")] 
		public CName OwnerIDClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("customData")] 
		public CHandle<WidgetCustomData> CustomData
		{
			get => GetPropertyValue<CHandle<WidgetCustomData>>();
			set => SetPropertyValue<CHandle<WidgetCustomData>>(value);
		}

		[Ordinal(12)] 
		[RED("isWidgetInactive")] 
		public CBool IsWidgetInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("widgetState")] 
		public CEnum<EWidgetState> WidgetState
		{
			get => GetPropertyValue<CEnum<EWidgetState>>();
			set => SetPropertyValue<CEnum<EWidgetState>>(value);
		}

		[Ordinal(14)] 
		[RED("iconID")] 
		public CName IconID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("bckgroundTextureID")] 
		public TweakDBID BckgroundTextureID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("iconTextureID")] 
		public TweakDBID IconTextureID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(17)] 
		[RED("textData")] 
		public CHandle<textTextParameterSet> TextData
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		public SWidgetPackage()
		{
			OwnerID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
