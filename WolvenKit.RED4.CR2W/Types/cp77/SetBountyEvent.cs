using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBountyEvent : redEvent
	{
		private TweakDBID _bountyID;

		[Ordinal(0)] 
		[RED("bountyID")] 
		public TweakDBID BountyID
		{
			get
			{
				if (_bountyID == null)
				{
					_bountyID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "bountyID", cr2w, this);
				}
				return _bountyID;
			}
			set
			{
				if (_bountyID == value)
				{
					return;
				}
				_bountyID = value;
				PropertySet(this);
			}
		}

		public SetBountyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
