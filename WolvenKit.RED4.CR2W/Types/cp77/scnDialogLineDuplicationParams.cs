using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineDuplicationParams : CVariable
	{
		private CUInt8 _executionTag;
		private scnActorId _additionalSpeakerId;
		private CBool _isHolocallSpeaker;

		[Ordinal(0)] 
		[RED("executionTag")] 
		public CUInt8 ExecutionTag
		{
			get => GetProperty(ref _executionTag);
			set => SetProperty(ref _executionTag, value);
		}

		[Ordinal(1)] 
		[RED("additionalSpeakerId")] 
		public scnActorId AdditionalSpeakerId
		{
			get => GetProperty(ref _additionalSpeakerId);
			set => SetProperty(ref _additionalSpeakerId, value);
		}

		[Ordinal(2)] 
		[RED("isHolocallSpeaker")] 
		public CBool IsHolocallSpeaker
		{
			get => GetProperty(ref _isHolocallSpeaker);
			set => SetProperty(ref _isHolocallSpeaker, value);
		}

		public scnDialogLineDuplicationParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
