using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameData : CVariable
	{
		private CArray<CellData> _gridData;
		private CInt32 _playerBufferSize;
		private ProgramData _basicAccess;
		private CArray<ProgramData> _playerPrograms;
		private CInt32 _enemyBufferSize;
		private ProgramData _enemyLockNetwork;
		private CArray<ProgramData> _enemyPrograms;

		[Ordinal(0)] 
		[RED("gridData")] 
		public CArray<CellData> GridData
		{
			get
			{
				if (_gridData == null)
				{
					_gridData = (CArray<CellData>) CR2WTypeManager.Create("array:CellData", "gridData", cr2w, this);
				}
				return _gridData;
			}
			set
			{
				if (_gridData == value)
				{
					return;
				}
				_gridData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerBufferSize")] 
		public CInt32 PlayerBufferSize
		{
			get
			{
				if (_playerBufferSize == null)
				{
					_playerBufferSize = (CInt32) CR2WTypeManager.Create("Int32", "playerBufferSize", cr2w, this);
				}
				return _playerBufferSize;
			}
			set
			{
				if (_playerBufferSize == value)
				{
					return;
				}
				_playerBufferSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("basicAccess")] 
		public ProgramData BasicAccess
		{
			get
			{
				if (_basicAccess == null)
				{
					_basicAccess = (ProgramData) CR2WTypeManager.Create("ProgramData", "basicAccess", cr2w, this);
				}
				return _basicAccess;
			}
			set
			{
				if (_basicAccess == value)
				{
					return;
				}
				_basicAccess = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerPrograms")] 
		public CArray<ProgramData> PlayerPrograms
		{
			get
			{
				if (_playerPrograms == null)
				{
					_playerPrograms = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "playerPrograms", cr2w, this);
				}
				return _playerPrograms;
			}
			set
			{
				if (_playerPrograms == value)
				{
					return;
				}
				_playerPrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("enemyBufferSize")] 
		public CInt32 EnemyBufferSize
		{
			get
			{
				if (_enemyBufferSize == null)
				{
					_enemyBufferSize = (CInt32) CR2WTypeManager.Create("Int32", "enemyBufferSize", cr2w, this);
				}
				return _enemyBufferSize;
			}
			set
			{
				if (_enemyBufferSize == value)
				{
					return;
				}
				_enemyBufferSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("enemyLockNetwork")] 
		public ProgramData EnemyLockNetwork
		{
			get
			{
				if (_enemyLockNetwork == null)
				{
					_enemyLockNetwork = (ProgramData) CR2WTypeManager.Create("ProgramData", "enemyLockNetwork", cr2w, this);
				}
				return _enemyLockNetwork;
			}
			set
			{
				if (_enemyLockNetwork == value)
				{
					return;
				}
				_enemyLockNetwork = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("enemyPrograms")] 
		public CArray<ProgramData> EnemyPrograms
		{
			get
			{
				if (_enemyPrograms == null)
				{
					_enemyPrograms = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "enemyPrograms", cr2w, this);
				}
				return _enemyPrograms;
			}
			set
			{
				if (_enemyPrograms == value)
				{
					return;
				}
				_enemyPrograms = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
