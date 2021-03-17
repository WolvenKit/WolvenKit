using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAdditionalSpeakers : CVariable
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

		public scnAdditionalSpeakers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
