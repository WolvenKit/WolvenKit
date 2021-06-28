using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReactionStimType : AIbehaviorconditionScript
	{
		private CEnum<gamedataStimType> _stimToCompare;

		[Ordinal(0)] 
		[RED("stimToCompare")] 
		public CEnum<gamedataStimType> StimToCompare
		{
			get => GetProperty(ref _stimToCompare);
			set => SetProperty(ref _stimToCompare, value);
		}

		public CheckReactionStimType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
