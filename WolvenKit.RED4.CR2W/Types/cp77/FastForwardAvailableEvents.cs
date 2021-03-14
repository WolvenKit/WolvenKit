using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastForwardAvailableEvents : ScenesFastForwardTransition
	{
		private CBool _forceCloseFX;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("forceCloseFX")] 
		public CBool ForceCloseFX
		{
			get
			{
				if (_forceCloseFX == null)
				{
					_forceCloseFX = (CBool) CR2WTypeManager.Create("Bool", "forceCloseFX", cr2w, this);
				}
				return _forceCloseFX;
			}
			set
			{
				if (_forceCloseFX == value)
				{
					return;
				}
				_forceCloseFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		public FastForwardAvailableEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
