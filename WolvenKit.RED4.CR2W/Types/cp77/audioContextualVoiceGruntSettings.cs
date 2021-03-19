using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualVoiceGruntSettings : CVariable
	{
		private audioContextualVoiceGrunt _painShort;
		private audioContextualVoiceGrunt _effort;

		[Ordinal(0)] 
		[RED("painShort")] 
		public audioContextualVoiceGrunt PainShort
		{
			get => GetProperty(ref _painShort);
			set => SetProperty(ref _painShort, value);
		}

		[Ordinal(1)] 
		[RED("effort")] 
		public audioContextualVoiceGrunt Effort
		{
			get => GetProperty(ref _effort);
			set => SetProperty(ref _effort, value);
		}

		public audioContextualVoiceGruntSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
