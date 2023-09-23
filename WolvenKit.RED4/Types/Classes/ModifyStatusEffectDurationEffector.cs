using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyStatusEffectDurationEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("statusEffectListener")] 
		public CHandle<OnStatusEffectAppliedListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<OnStatusEffectAppliedListener>>();
			set => SetPropertyValue<CHandle<OnStatusEffectAppliedListener>>(value);
		}

		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("change")] 
		public CFloat Change
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isPercentage")] 
		public CBool IsPercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public ModifyStatusEffectDurationEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
