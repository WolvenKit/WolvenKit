using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccumulatedDamageDigitsNode : CVariable
	{
		private CBool _used;
		private entEntityID _entityID;
		private wCHandle<AccumulatedDamageDigitLogicController> _controller;
		private CBool _isDamageOverTime;

		[Ordinal(0)] 
		[RED("used")] 
		public CBool Used
		{
			get
			{
				if (_used == null)
				{
					_used = (CBool) CR2WTypeManager.Create("Bool", "used", cr2w, this);
				}
				return _used;
			}
			set
			{
				if (_used == value)
				{
					return;
				}
				_used = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("controller")] 
		public wCHandle<AccumulatedDamageDigitLogicController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<AccumulatedDamageDigitLogicController>) CR2WTypeManager.Create("whandle:AccumulatedDamageDigitLogicController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isDamageOverTime")] 
		public CBool IsDamageOverTime
		{
			get
			{
				if (_isDamageOverTime == null)
				{
					_isDamageOverTime = (CBool) CR2WTypeManager.Create("Bool", "isDamageOverTime", cr2w, this);
				}
				return _isDamageOverTime;
			}
			set
			{
				if (_isDamageOverTime == value)
				{
					return;
				}
				_isDamageOverTime = value;
				PropertySet(this);
			}
		}

		public AccumulatedDamageDigitsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
