using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioEnvelopeSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("attackTime")] public CFloat AttackTime { get; set; }
		[Ordinal(1)]  [RED("holdTime")] public CFloat HoldTime { get; set; }
		[Ordinal(2)]  [RED("releaseTime")] public CFloat ReleaseTime { get; set; }

		public audioEnvelopeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
