using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetHUDEntryForcedVisibility_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CArray<CName> HudEntryName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("usePreset")] 
		public CBool UsePreset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hudVisibilityPreset")] 
		public TweakDBID HudVisibilityPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("visibility")] 
		public CEnum<worlduiEntryVisibility> Visibility
		{
			get => GetPropertyValue<CEnum<worlduiEntryVisibility>>();
			set => SetPropertyValue<CEnum<worlduiEntryVisibility>>(value);
		}

		public questSetHUDEntryForcedVisibility_NodeType()
		{
			HudEntryName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
