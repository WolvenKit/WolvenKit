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
			get
			{
				if (_saveLock == null)
				{
					_saveLock = (CBool) CR2WTypeManager.Create("Bool", "saveLock", cr2w, this);
				}
				return _saveLock;
			}
			set
			{
				if (_saveLock == value)
				{
					return;
				}
				_saveLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ignoreSaveLocks")] 
		public CBool IgnoreSaveLocks
		{
			get
			{
				if (_ignoreSaveLocks == null)
				{
					_ignoreSaveLocks = (CBool) CR2WTypeManager.Create("Bool", "ignoreSaveLocks", cr2w, this);
				}
				return _ignoreSaveLocks;
			}
			set
			{
				if (_ignoreSaveLocks == value)
				{
					return;
				}
				_ignoreSaveLocks = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pointOfNoReturn")] 
		public CBool PointOfNoReturn
		{
			get
			{
				if (_pointOfNoReturn == null)
				{
					_pointOfNoReturn = (CBool) CR2WTypeManager.Create("Bool", "pointOfNoReturn", cr2w, this);
				}
				return _pointOfNoReturn;
			}
			set
			{
				if (_pointOfNoReturn == value)
				{
					return;
				}
				_pointOfNoReturn = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("endGameSave")] 
		public CBool EndGameSave
		{
			get
			{
				if (_endGameSave == null)
				{
					_endGameSave = (CBool) CR2WTypeManager.Create("Bool", "endGameSave", cr2w, this);
				}
				return _endGameSave;
			}
			set
			{
				if (_endGameSave == value)
				{
					return;
				}
				_endGameSave = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("additionalEndGameRewardsTweak")] 
		public CArray<TweakDBID> AdditionalEndGameRewardsTweak
		{
			get
			{
				if (_additionalEndGameRewardsTweak == null)
				{
					_additionalEndGameRewardsTweak = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "additionalEndGameRewardsTweak", cr2w, this);
				}
				return _additionalEndGameRewardsTweak;
			}
			set
			{
				if (_additionalEndGameRewardsTweak == value)
				{
					return;
				}
				_additionalEndGameRewardsTweak = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("debugString")] 
		public CString DebugString
		{
			get
			{
				if (_debugString == null)
				{
					_debugString = (CString) CR2WTypeManager.Create("String", "debugString", cr2w, this);
				}
				return _debugString;
			}
			set
			{
				if (_debugString == value)
				{
					return;
				}
				_debugString = value;
				PropertySet(this);
			}
		}

		public questCheckpointNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
