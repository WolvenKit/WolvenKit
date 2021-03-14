using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFlybySettings : CVariable
	{
		private CFloat _movementSpeed;
		private CName _flybyEvent;

		[Ordinal(0)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get
			{
				if (_movementSpeed == null)
				{
					_movementSpeed = (CFloat) CR2WTypeManager.Create("Float", "movementSpeed", cr2w, this);
				}
				return _movementSpeed;
			}
			set
			{
				if (_movementSpeed == value)
				{
					return;
				}
				_movementSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("flybyEvent")] 
		public CName FlybyEvent
		{
			get
			{
				if (_flybyEvent == null)
				{
					_flybyEvent = (CName) CR2WTypeManager.Create("CName", "flybyEvent", cr2w, this);
				}
				return _flybyEvent;
			}
			set
			{
				if (_flybyEvent == value)
				{
					return;
				}
				_flybyEvent = value;
				PropertySet(this);
			}
		}

		public audioFlybySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
