using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsMappinData : gamemappinsIMappinData
	{
		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetPropertyValue<CEnum<gamedataMappinVariant>>();
			set => SetPropertyValue<CEnum<gamedataMappinVariant>>(value);
		}

		[Ordinal(2)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("debugCaption")] 
		public CString DebugCaption
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("localizedCaption")] 
		public LocalizationString LocalizedCaption
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(5)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("scriptData")] 
		public CHandle<gamemappinsMappinScriptData> ScriptData
		{
			get => GetPropertyValue<CHandle<gamemappinsMappinScriptData>>();
			set => SetPropertyValue<CHandle<gamemappinsMappinScriptData>>(value);
		}

		public gamemappinsMappinData()
		{
			Variant = Enums.gamedataMappinVariant.DefaultQuestVariant;
			Active = true;
			LocalizedCaption = new() { Unk1 = 0, Value = "" };
			VisibleThroughWalls = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
