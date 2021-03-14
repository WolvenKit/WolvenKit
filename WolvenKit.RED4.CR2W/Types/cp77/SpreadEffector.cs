using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadEffector : gameEffector
	{
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gamedataSpreadEffector_Record> _effectorRecord;
		private CBool _spreadToAllTargetsInTheArea;

		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get
			{
				if (_objectActionRecord == null)
				{
					_objectActionRecord = (wCHandle<gamedataObjectAction_Record>) CR2WTypeManager.Create("whandle:gamedataObjectAction_Record", "objectActionRecord", cr2w, this);
				}
				return _objectActionRecord;
			}
			set
			{
				if (_objectActionRecord == value)
				{
					return;
				}
				_objectActionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadEffector_Record> EffectorRecord
		{
			get
			{
				if (_effectorRecord == null)
				{
					_effectorRecord = (CHandle<gamedataSpreadEffector_Record>) CR2WTypeManager.Create("handle:gamedataSpreadEffector_Record", "effectorRecord", cr2w, this);
				}
				return _effectorRecord;
			}
			set
			{
				if (_effectorRecord == value)
				{
					return;
				}
				_effectorRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get
			{
				if (_spreadToAllTargetsInTheArea == null)
				{
					_spreadToAllTargetsInTheArea = (CBool) CR2WTypeManager.Create("Bool", "spreadToAllTargetsInTheArea", cr2w, this);
				}
				return _spreadToAllTargetsInTheArea;
			}
			set
			{
				if (_spreadToAllTargetsInTheArea == value)
				{
					return;
				}
				_spreadToAllTargetsInTheArea = value;
				PropertySet(this);
			}
		}

		public SpreadEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
