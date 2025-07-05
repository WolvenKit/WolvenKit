using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAdditionalSpeakers : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("executionTag")] 
		public CUInt8 ExecutionTag
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("role")] 
		public CEnum<scnAdditionalSpeakerRole> Role
		{
			get => GetPropertyValue<CEnum<scnAdditionalSpeakerRole>>();
			set => SetPropertyValue<CEnum<scnAdditionalSpeakerRole>>(value);
		}

		[Ordinal(2)] 
		[RED("speakers")] 
		public CArray<scnAdditionalSpeaker> Speakers
		{
			get => GetPropertyValue<CArray<scnAdditionalSpeaker>>();
			set => SetPropertyValue<CArray<scnAdditionalSpeaker>>(value);
		}

		public scnAdditionalSpeakers()
		{
			Speakers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
