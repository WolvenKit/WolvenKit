using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEnemyStateCountASTCD : audioAudioStateTransitionConditionData
	{
		private CEnum<audioEnemyState> _enemiesState;
		private CEnum<audioNumberComparer> _countComparer;
		private CUInt32 _enemiesCount;

		[Ordinal(1)] 
		[RED("enemiesState")] 
		public CEnum<audioEnemyState> EnemiesState
		{
			get
			{
				if (_enemiesState == null)
				{
					_enemiesState = (CEnum<audioEnemyState>) CR2WTypeManager.Create("audioEnemyState", "enemiesState", cr2w, this);
				}
				return _enemiesState;
			}
			set
			{
				if (_enemiesState == value)
				{
					return;
				}
				_enemiesState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("countComparer")] 
		public CEnum<audioNumberComparer> CountComparer
		{
			get
			{
				if (_countComparer == null)
				{
					_countComparer = (CEnum<audioNumberComparer>) CR2WTypeManager.Create("audioNumberComparer", "countComparer", cr2w, this);
				}
				return _countComparer;
			}
			set
			{
				if (_countComparer == value)
				{
					return;
				}
				_countComparer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enemiesCount")] 
		public CUInt32 EnemiesCount
		{
			get
			{
				if (_enemiesCount == null)
				{
					_enemiesCount = (CUInt32) CR2WTypeManager.Create("Uint32", "enemiesCount", cr2w, this);
				}
				return _enemiesCount;
			}
			set
			{
				if (_enemiesCount == value)
				{
					return;
				}
				_enemiesCount = value;
				PropertySet(this);
			}
		}

		public audioEnemyStateCountASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
