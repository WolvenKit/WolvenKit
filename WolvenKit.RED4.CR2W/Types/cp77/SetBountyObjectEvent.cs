using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBountyObjectEvent : redEvent
	{
		private Bounty _bounty;

		[Ordinal(0)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get
			{
				if (_bounty == null)
				{
					_bounty = (Bounty) CR2WTypeManager.Create("Bounty", "bounty", cr2w, this);
				}
				return _bounty;
			}
			set
			{
				if (_bounty == value)
				{
					return;
				}
				_bounty = value;
				PropertySet(this);
			}
		}

		public SetBountyObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
