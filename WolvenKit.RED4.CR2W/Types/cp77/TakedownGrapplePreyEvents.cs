using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakedownGrapplePreyEvents : LocomotionTakedownEvents
	{
		private CBool _isGrappleReactionVOPlayed;

		[Ordinal(1)] 
		[RED("isGrappleReactionVOPlayed")] 
		public CBool IsGrappleReactionVOPlayed
		{
			get
			{
				if (_isGrappleReactionVOPlayed == null)
				{
					_isGrappleReactionVOPlayed = (CBool) CR2WTypeManager.Create("Bool", "isGrappleReactionVOPlayed", cr2w, this);
				}
				return _isGrappleReactionVOPlayed;
			}
			set
			{
				if (_isGrappleReactionVOPlayed == value)
				{
					return;
				}
				_isGrappleReactionVOPlayed = value;
				PropertySet(this);
			}
		}

		public TakedownGrapplePreyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
