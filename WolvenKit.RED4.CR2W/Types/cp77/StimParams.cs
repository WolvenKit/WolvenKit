using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimParams : CVariable
	{
		private ReactionOutput _reactionOutput;
		private StimEventData _stimData;

		[Ordinal(0)] 
		[RED("reactionOutput")] 
		public ReactionOutput ReactionOutput
		{
			get => GetProperty(ref _reactionOutput);
			set => SetProperty(ref _reactionOutput, value);
		}

		[Ordinal(1)] 
		[RED("stimData")] 
		public StimEventData StimData
		{
			get => GetProperty(ref _stimData);
			set => SetProperty(ref _stimData, value);
		}

		public StimParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
