using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewTurnMinigameData : CVariable
	{
		private Vector2 _position;
		private CBool _doConsume;
		private CEnum<HighlightMode> _nextHighlightMode;
		private CArray<ElementData> _newPlayerBufferContent;
		private CArray<ElementData> _newEnemyBufferContent;
		private CBool _doRegenerateGrid;
		private CArray<CellData> _regeneratedGridData;
		private ProgramProgressData _basicAccessCompletionState;
		private CArray<ProgramProgressData> _playerProgramsCompletionState;
		private CArray<ProgramProgressData> _enemyProgramsCompletionState;
		private CBool _playerProgramsChange;
		private CArray<ProgramData> _playerProgramsAdded;
		private CArray<ProgramData> _playerProgramsRemoved;
		private CBool _enemyProgramsChange;
		private CArray<ProgramData> _enemyprogramsAdded;
		private CArray<ProgramData> _enemyprogramsRemoved;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector2) CR2WTypeManager.Create("Vector2", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("doConsume")] 
		public CBool DoConsume
		{
			get
			{
				if (_doConsume == null)
				{
					_doConsume = (CBool) CR2WTypeManager.Create("Bool", "doConsume", cr2w, this);
				}
				return _doConsume;
			}
			set
			{
				if (_doConsume == value)
				{
					return;
				}
				_doConsume = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nextHighlightMode")] 
		public CEnum<HighlightMode> NextHighlightMode
		{
			get
			{
				if (_nextHighlightMode == null)
				{
					_nextHighlightMode = (CEnum<HighlightMode>) CR2WTypeManager.Create("HighlightMode", "nextHighlightMode", cr2w, this);
				}
				return _nextHighlightMode;
			}
			set
			{
				if (_nextHighlightMode == value)
				{
					return;
				}
				_nextHighlightMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("newPlayerBufferContent")] 
		public CArray<ElementData> NewPlayerBufferContent
		{
			get
			{
				if (_newPlayerBufferContent == null)
				{
					_newPlayerBufferContent = (CArray<ElementData>) CR2WTypeManager.Create("array:ElementData", "newPlayerBufferContent", cr2w, this);
				}
				return _newPlayerBufferContent;
			}
			set
			{
				if (_newPlayerBufferContent == value)
				{
					return;
				}
				_newPlayerBufferContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("newEnemyBufferContent")] 
		public CArray<ElementData> NewEnemyBufferContent
		{
			get
			{
				if (_newEnemyBufferContent == null)
				{
					_newEnemyBufferContent = (CArray<ElementData>) CR2WTypeManager.Create("array:ElementData", "newEnemyBufferContent", cr2w, this);
				}
				return _newEnemyBufferContent;
			}
			set
			{
				if (_newEnemyBufferContent == value)
				{
					return;
				}
				_newEnemyBufferContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("doRegenerateGrid")] 
		public CBool DoRegenerateGrid
		{
			get
			{
				if (_doRegenerateGrid == null)
				{
					_doRegenerateGrid = (CBool) CR2WTypeManager.Create("Bool", "doRegenerateGrid", cr2w, this);
				}
				return _doRegenerateGrid;
			}
			set
			{
				if (_doRegenerateGrid == value)
				{
					return;
				}
				_doRegenerateGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("regeneratedGridData")] 
		public CArray<CellData> RegeneratedGridData
		{
			get
			{
				if (_regeneratedGridData == null)
				{
					_regeneratedGridData = (CArray<CellData>) CR2WTypeManager.Create("array:CellData", "regeneratedGridData", cr2w, this);
				}
				return _regeneratedGridData;
			}
			set
			{
				if (_regeneratedGridData == value)
				{
					return;
				}
				_regeneratedGridData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("basicAccessCompletionState")] 
		public ProgramProgressData BasicAccessCompletionState
		{
			get
			{
				if (_basicAccessCompletionState == null)
				{
					_basicAccessCompletionState = (ProgramProgressData) CR2WTypeManager.Create("ProgramProgressData", "basicAccessCompletionState", cr2w, this);
				}
				return _basicAccessCompletionState;
			}
			set
			{
				if (_basicAccessCompletionState == value)
				{
					return;
				}
				_basicAccessCompletionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playerProgramsCompletionState")] 
		public CArray<ProgramProgressData> PlayerProgramsCompletionState
		{
			get
			{
				if (_playerProgramsCompletionState == null)
				{
					_playerProgramsCompletionState = (CArray<ProgramProgressData>) CR2WTypeManager.Create("array:ProgramProgressData", "playerProgramsCompletionState", cr2w, this);
				}
				return _playerProgramsCompletionState;
			}
			set
			{
				if (_playerProgramsCompletionState == value)
				{
					return;
				}
				_playerProgramsCompletionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enemyProgramsCompletionState")] 
		public CArray<ProgramProgressData> EnemyProgramsCompletionState
		{
			get
			{
				if (_enemyProgramsCompletionState == null)
				{
					_enemyProgramsCompletionState = (CArray<ProgramProgressData>) CR2WTypeManager.Create("array:ProgramProgressData", "enemyProgramsCompletionState", cr2w, this);
				}
				return _enemyProgramsCompletionState;
			}
			set
			{
				if (_enemyProgramsCompletionState == value)
				{
					return;
				}
				_enemyProgramsCompletionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("playerProgramsChange")] 
		public CBool PlayerProgramsChange
		{
			get
			{
				if (_playerProgramsChange == null)
				{
					_playerProgramsChange = (CBool) CR2WTypeManager.Create("Bool", "playerProgramsChange", cr2w, this);
				}
				return _playerProgramsChange;
			}
			set
			{
				if (_playerProgramsChange == value)
				{
					return;
				}
				_playerProgramsChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("playerProgramsAdded")] 
		public CArray<ProgramData> PlayerProgramsAdded
		{
			get
			{
				if (_playerProgramsAdded == null)
				{
					_playerProgramsAdded = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "playerProgramsAdded", cr2w, this);
				}
				return _playerProgramsAdded;
			}
			set
			{
				if (_playerProgramsAdded == value)
				{
					return;
				}
				_playerProgramsAdded = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerProgramsRemoved")] 
		public CArray<ProgramData> PlayerProgramsRemoved
		{
			get
			{
				if (_playerProgramsRemoved == null)
				{
					_playerProgramsRemoved = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "playerProgramsRemoved", cr2w, this);
				}
				return _playerProgramsRemoved;
			}
			set
			{
				if (_playerProgramsRemoved == value)
				{
					return;
				}
				_playerProgramsRemoved = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("enemyProgramsChange")] 
		public CBool EnemyProgramsChange
		{
			get
			{
				if (_enemyProgramsChange == null)
				{
					_enemyProgramsChange = (CBool) CR2WTypeManager.Create("Bool", "enemyProgramsChange", cr2w, this);
				}
				return _enemyProgramsChange;
			}
			set
			{
				if (_enemyProgramsChange == value)
				{
					return;
				}
				_enemyProgramsChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("enemyprogramsAdded")] 
		public CArray<ProgramData> EnemyprogramsAdded
		{
			get
			{
				if (_enemyprogramsAdded == null)
				{
					_enemyprogramsAdded = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "enemyprogramsAdded", cr2w, this);
				}
				return _enemyprogramsAdded;
			}
			set
			{
				if (_enemyprogramsAdded == value)
				{
					return;
				}
				_enemyprogramsAdded = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("enemyprogramsRemoved")] 
		public CArray<ProgramData> EnemyprogramsRemoved
		{
			get
			{
				if (_enemyprogramsRemoved == null)
				{
					_enemyprogramsRemoved = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "enemyprogramsRemoved", cr2w, this);
				}
				return _enemyprogramsRemoved;
			}
			set
			{
				if (_enemyprogramsRemoved == value)
				{
					return;
				}
				_enemyprogramsRemoved = value;
				PropertySet(this);
			}
		}

		public NewTurnMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
