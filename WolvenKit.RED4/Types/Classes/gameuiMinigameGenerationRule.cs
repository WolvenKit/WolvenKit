using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinigameGenerationRule : IScriptable
	{
		[Ordinal(0)] 
		[RED("minigameController")] 
		public CWeakHandle<gameuiHackingMinigameGameController> MinigameController
		{
			get => GetPropertyValue<CWeakHandle<gameuiHackingMinigameGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHackingMinigameGameController>>(value);
		}

		[Ordinal(1)] 
		[RED("blackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get => GetPropertyValue<CHandle<gameBlackboardSystem>>();
			set => SetPropertyValue<CHandle<gameBlackboardSystem>>(value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(4)] 
		[RED("minigameRecord")] 
		public CWeakHandle<gamedataMinigame_Def_Record> MinigameRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataMinigame_Def_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataMinigame_Def_Record>>(value);
		}

		[Ordinal(5)] 
		[RED("bufferSize")] 
		public CInt32 BufferSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("isItemBreach")] 
		public CBool IsItemBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiMinigameGenerationRule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
