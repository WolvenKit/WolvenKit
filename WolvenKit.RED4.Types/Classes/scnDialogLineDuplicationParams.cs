using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnDialogLineDuplicationParams : RedBaseClass
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
	}
}
