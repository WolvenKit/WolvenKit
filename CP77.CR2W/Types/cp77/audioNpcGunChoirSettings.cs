using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("voices")] public CArray<CName> Voices { get; set; }

		public audioNpcGunChoirSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
