using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddInvestigatorEvent : redEvent
	{
		private entEntityID _investigator;

		[Ordinal(0)] 
		[RED("investigator")] 
		public entEntityID Investigator
		{
			get => GetProperty(ref _investigator);
			set => SetProperty(ref _investigator, value);
		}

		public AddInvestigatorEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
