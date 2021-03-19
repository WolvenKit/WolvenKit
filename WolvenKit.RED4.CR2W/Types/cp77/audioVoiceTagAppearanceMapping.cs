using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagAppearanceMapping : audioAudioMetadata
	{
		private CArray<audioVoiceTagAppearanceGroup> _mappings;

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<audioVoiceTagAppearanceGroup> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}

		public audioVoiceTagAppearanceMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
