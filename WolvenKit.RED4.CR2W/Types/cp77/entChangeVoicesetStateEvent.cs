using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entChangeVoicesetStateEvent : redEvent
	{
		private CBool _enableVoicesetLines;
		private CBool _enableVoicesetGrunts;
		private CArray<entVoicesetInputToBlock> _inputsToBlock;

		[Ordinal(0)] 
		[RED("enableVoicesetLines")] 
		public CBool EnableVoicesetLines
		{
			get => GetProperty(ref _enableVoicesetLines);
			set => SetProperty(ref _enableVoicesetLines, value);
		}

		[Ordinal(1)] 
		[RED("enableVoicesetGrunts")] 
		public CBool EnableVoicesetGrunts
		{
			get => GetProperty(ref _enableVoicesetGrunts);
			set => SetProperty(ref _enableVoicesetGrunts, value);
		}

		[Ordinal(2)] 
		[RED("inputsToBlock")] 
		public CArray<entVoicesetInputToBlock> InputsToBlock
		{
			get => GetProperty(ref _inputsToBlock);
			set => SetProperty(ref _inputsToBlock, value);
		}

		public entChangeVoicesetStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
