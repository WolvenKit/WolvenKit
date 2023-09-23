using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleCanUseCover : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("ability")] 
		public CWeakHandle<gamedataGameplayAbility_Record> Ability
		{
			get => GetPropertyValue<CWeakHandle<gamedataGameplayAbility_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataGameplayAbility_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<CHandle<gameIPrereq>> Prereqs
		{
			get => GetPropertyValue<CArray<CHandle<gameIPrereq>>>();
			set => SetPropertyValue<CArray<CHandle<gameIPrereq>>>(value);
		}

		[Ordinal(2)] 
		[RED("prereqCount")] 
		public CInt32 PrereqCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public SimpleCanUseCover()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
