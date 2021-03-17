using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCheckpointNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CBool _saveLock;
		private CBool _ignoreSaveLocks;
		private CBool _pointOfNoReturn;
		private CBool _endGameSave;
		private CArray<TweakDBID> _additionalEndGameRewardsTweak;
		private CString _debugString;

		[Ordinal(2)] 
		[RED("saveLock")] 
		public CBool SaveLock
		{
			get => GetProperty(ref _saveLock);
			set => SetProperty(ref _saveLock, value);
		}

		[Ordinal(3)] 
		[RED("ignoreSaveLocks")] 
		public CBool IgnoreSaveLocks
		{
			get => GetProperty(ref _ignoreSaveLocks);
			set => SetProperty(ref _ignoreSaveLocks, value);
		}

		[Ordinal(4)] 
		[RED("pointOfNoReturn")] 
		public CBool PointOfNoReturn
		{
			get => GetProperty(ref _pointOfNoReturn);
			set => SetProperty(ref _pointOfNoReturn, value);
		}

		[Ordinal(5)] 
		[RED("endGameSave")] 
		public CBool EndGameSave
		{
			get => GetProperty(ref _endGameSave);
			set => SetProperty(ref _endGameSave, value);
		}

		[Ordinal(6)] 
		[RED("additionalEndGameRewardsTweak")] 
		public CArray<TweakDBID> AdditionalEndGameRewardsTweak
		{
			get => GetProperty(ref _additionalEndGameRewardsTweak);
			set => SetProperty(ref _additionalEndGameRewardsTweak, value);
		}

		[Ordinal(7)] 
		[RED("debugString")] 
		public CString DebugString
		{
			get => GetProperty(ref _debugString);
			set => SetProperty(ref _debugString, value);
		}

		public questCheckpointNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
