using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadInitEffector : gameEffector
	{
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private CHandle<gamedataSpreadInitEffector_Record> _effectorRecord;
		private wCHandle<PlayerPuppet> _player;

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
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadInitEffector_Record> EffectorRecord
		{
			get
			{
				if (_effectorRecord == null)
				{
					_effectorRecord = (CHandle<gamedataSpreadInitEffector_Record>) CR2WTypeManager.Create("handle:gamedataSpreadInitEffector_Record", "effectorRecord", cr2w, this);
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

		[Ordinal(2)] 
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

		public SpreadInitEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
