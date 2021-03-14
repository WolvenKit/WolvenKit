using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrappleForceShovePreyEvents : LocomotionTakedownEvents
	{
		private CBool _unmountCalled;

		[Ordinal(1)] 
		[RED("unmountCalled")] 
		public CBool UnmountCalled
		{
			get
			{
				if (_unmountCalled == null)
				{
					_unmountCalled = (CBool) CR2WTypeManager.Create("Bool", "unmountCalled", cr2w, this);
				}
				return _unmountCalled;
			}
			set
			{
				if (_unmountCalled == value)
				{
					return;
				}
				_unmountCalled = value;
				PropertySet(this);
			}
		}

		public GrappleForceShovePreyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
