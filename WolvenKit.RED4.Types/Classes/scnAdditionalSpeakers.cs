using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAdditionalSpeakers : RedBaseClass
	{
		private CUInt8 _executionTag;
		private CEnum<scnAdditionalSpeakerRole> _role;
		private CArray<scnAdditionalSpeaker> _speakers;

		[Ordinal(0)] 
		[RED("executionTag")] 
		public CUInt8 ExecutionTag
		{
			get => GetProperty(ref _executionTag);
			set => SetProperty(ref _executionTag, value);
		}

		[Ordinal(1)] 
		[RED("role")] 
		public CEnum<scnAdditionalSpeakerRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		[Ordinal(2)] 
		[RED("speakers")] 
		public CArray<scnAdditionalSpeaker> Speakers
		{
			get => GetProperty(ref _speakers);
			set => SetProperty(ref _speakers, value);
		}
	}
}
