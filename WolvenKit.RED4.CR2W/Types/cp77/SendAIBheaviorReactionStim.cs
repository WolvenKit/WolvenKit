using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendAIBheaviorReactionStim : AIbehaviortaskScript
	{
		private CEnum<gamedataStimType> _stimToSend;

		[Ordinal(0)] 
		[RED("stimToSend")] 
		public CEnum<gamedataStimType> StimToSend
		{
			get => GetProperty(ref _stimToSend);
			set => SetProperty(ref _stimToSend, value);
		}

		public SendAIBheaviorReactionStim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
