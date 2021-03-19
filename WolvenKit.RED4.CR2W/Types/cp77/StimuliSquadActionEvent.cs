using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimuliSquadActionEvent : senseBaseStimuliEvent
	{
		private CName _squadActionName;
		private CEnum<EAISquadVerb> _squadVerb;

		[Ordinal(2)] 
		[RED("squadActionName")] 
		public CName SquadActionName
		{
			get => GetProperty(ref _squadActionName);
			set => SetProperty(ref _squadActionName, value);
		}

		[Ordinal(3)] 
		[RED("squadVerb")] 
		public CEnum<EAISquadVerb> SquadVerb
		{
			get => GetProperty(ref _squadVerb);
			set => SetProperty(ref _squadVerb, value);
		}

		public StimuliSquadActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
