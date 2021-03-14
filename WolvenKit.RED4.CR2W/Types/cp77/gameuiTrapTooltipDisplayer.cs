using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTrapTooltipDisplayer : inkWidgetLogicController
	{
		private wCHandle<gamedataMiniGame_Trap_Record> _trap;
		private CFloat _delayDuration;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(1)] 
		[RED("trap")] 
		public wCHandle<gamedataMiniGame_Trap_Record> Trap
		{
			get
			{
				if (_trap == null)
				{
					_trap = (wCHandle<gamedataMiniGame_Trap_Record>) CR2WTypeManager.Create("whandle:gamedataMiniGame_Trap_Record", "trap", cr2w, this);
				}
				return _trap;
			}
			set
			{
				if (_trap == value)
				{
					return;
				}
				_trap = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get
			{
				if (_delayDuration == null)
				{
					_delayDuration = (CFloat) CR2WTypeManager.Create("Float", "delayDuration", cr2w, this);
				}
				return _delayDuration;
			}
			set
			{
				if (_delayDuration == value)
				{
					return;
				}
				_delayDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public gameuiTrapTooltipDisplayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
