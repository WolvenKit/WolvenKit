using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetStatusEffect : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayerStatusEffectSource")] 
		public CBool IsPlayerStatusEffectSource
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("statusEffectSourceObject")] 
		public gameEntityReference StatusEffectSourceObject
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(5)] 
		[RED("recordSelector")] 
		public CHandle<questRecordSelector> RecordSelector
		{
			get => GetPropertyValue<CHandle<questRecordSelector>>();
			set => SetPropertyValue<CHandle<questRecordSelector>>(value);
		}

		[Ordinal(6)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterManagerParameters_SetStatusEffect()
		{
			PuppetRef = new() { Names = new() };
			StatusEffectSourceObject = new() { Names = new() };
			Set = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
