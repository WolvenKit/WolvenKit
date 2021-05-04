using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirSettings : audioAudioMetadata
	{
		private CArray<CName> _voices;

		[Ordinal(1)] 
		[RED("voices")] 
		public CArray<CName> Voices
		{
			get => GetProperty(ref _voices);
			set => SetProperty(ref _voices, value);
		}

		public audioNpcGunChoirSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
