using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterLevelUpGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _proficencyLabel;
		private CUInt32 _stateChangesBlackboardId;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<LevelUpUserData> _data;

		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("proficencyLabel")] 
		public inkTextWidgetReference ProficencyLabel
		{
			get
			{
				if (_proficencyLabel == null)
				{
					_proficencyLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "proficencyLabel", cr2w, this);
				}
				return _proficencyLabel;
			}
			set
			{
				if (_proficencyLabel == value)
				{
					return;
				}
				_proficencyLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get
			{
				if (_stateChangesBlackboardId == null)
				{
					_stateChangesBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "stateChangesBlackboardId", cr2w, this);
				}
				return _stateChangesBlackboardId;
			}
			set
			{
				if (_stateChangesBlackboardId == value)
				{
					return;
				}
				_stateChangesBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<LevelUpUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<LevelUpUserData>) CR2WTypeManager.Create("handle:LevelUpUserData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public CharacterLevelUpGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
