using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwimmingSurfaceEvents : LocomotionSwimmingEvents
	{
		private CFloat _lapsedTime;

		[Ordinal(0)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get
			{
				if (_lapsedTime == null)
				{
					_lapsedTime = (CFloat) CR2WTypeManager.Create("Float", "lapsedTime", cr2w, this);
				}
				return _lapsedTime;
			}
			set
			{
				if (_lapsedTime == value)
				{
					return;
				}
				_lapsedTime = value;
				PropertySet(this);
			}
		}

		public SwimmingSurfaceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
