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
			get => GetProperty(ref _bountyID);
			set => SetProperty(ref _bountyID, value);
		}

		public SetBountyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
