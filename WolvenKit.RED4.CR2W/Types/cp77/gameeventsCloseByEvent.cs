using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsCloseByEvent : redEvent
	{
		private Vector4 _position;
		private Vector4 _forward;
		private wCHandle<gameObject> _instigator;
		private CHandle<gamedamageAttackData> _attackData;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
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
		[RED("forward")] 
		public Vector4 Forward
		{
			get
			{
				if (_forward == null)
				{
					_forward = (Vector4) CR2WTypeManager.Create("Vector4", "forward", cr2w, this);
				}
				return _forward;
			}
			set
			{
				if (_forward == value)
				{
					return;
				}
				_forward = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get
			{
				if (_attackData == null)
				{
					_attackData = (CHandle<gamedamageAttackData>) CR2WTypeManager.Create("handle:gamedamageAttackData", "attackData", cr2w, this);
				}
				return _attackData;
			}
			set
			{
				if (_attackData == value)
				{
					return;
				}
				_attackData = value;
				PropertySet(this);
			}
		}

		public gameeventsCloseByEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
