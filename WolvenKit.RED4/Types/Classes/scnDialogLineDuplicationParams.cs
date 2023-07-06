using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDialogLineDuplicationParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("executionTag")] 
		public CUInt8 ExecutionTag
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("additionalSpeakerId")] 
		public scnActorId AdditionalSpeakerId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(2)] 
		[RED("isHolocallSpeaker")] 
		public CBool IsHolocallSpeaker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnDialogLineDuplicationParams()
		{
			AdditionalSpeakerId = new scnActorId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
