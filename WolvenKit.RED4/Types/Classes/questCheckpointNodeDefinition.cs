using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCheckpointNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("saveLock")] 
		public CBool SaveLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ignoreSaveLocks")] 
		public CBool IgnoreSaveLocks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("pointOfNoReturn")] 
		public CBool PointOfNoReturn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("endGameSave")] 
		public CBool EndGameSave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("additionalEndGameRewardsTweak")] 
		public CArray<TweakDBID> AdditionalEndGameRewardsTweak
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(7)] 
		[RED("debugString")] 
		public CString DebugString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public questCheckpointNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			AdditionalEndGameRewardsTweak = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
