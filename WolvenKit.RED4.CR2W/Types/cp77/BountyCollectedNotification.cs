using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BountyCollectedNotification : GenericNotificationController
	{
		private CName _bountyCollectedUpdateAnimation;

		[Ordinal(12)] 
		[RED("bountyCollectedUpdateAnimation")] 
		public CName BountyCollectedUpdateAnimation
		{
			get
			{
				if (_bountyCollectedUpdateAnimation == null)
				{
					_bountyCollectedUpdateAnimation = (CName) CR2WTypeManager.Create("CName", "bountyCollectedUpdateAnimation", cr2w, this);
				}
				return _bountyCollectedUpdateAnimation;
			}
			set
			{
				if (_bountyCollectedUpdateAnimation == value)
				{
					return;
				}
				_bountyCollectedUpdateAnimation = value;
				PropertySet(this);
			}
		}

		public BountyCollectedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
