using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("voices")] public CArray<CName> Voices { get; set; }

		public audioNpcGunChoirSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
