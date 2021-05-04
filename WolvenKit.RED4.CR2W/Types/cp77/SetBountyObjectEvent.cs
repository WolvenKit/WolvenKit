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
			get => GetProperty(ref _bounty);
			set => SetProperty(ref _bounty, value);
		}

		public SetBountyObjectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
