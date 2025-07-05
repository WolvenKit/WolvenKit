using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolChangeOverTimePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("statPoolListener")] 
		public CHandle<BaseStatPoolPrereqListener> StatPoolListener
		{
			get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
			set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public gameStatsObjectID OwnerID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(2)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeFrame")] 
		public CFloat TimeFrame
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("checkGain")] 
		public CBool CheckGain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("history")] 
		public CArray<ChangeInfoWithTimeStamp> History
		{
			get => GetPropertyValue<CArray<ChangeInfoWithTimeStamp>>();
			set => SetPropertyValue<CArray<ChangeInfoWithTimeStamp>>(value);
		}

		[Ordinal(7)] 
		[RED("GameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public StatPoolChangeOverTimePrereqState()
		{
			OwnerID = new gameStatsObjectID { IdType = Enums.gameStatIDType.Invalid };
			History = new();
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
