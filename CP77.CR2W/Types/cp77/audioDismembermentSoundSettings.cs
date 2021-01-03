using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioDismembermentSoundSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("armEvent")] public CName ArmEvent { get; set; }
		[Ordinal(1)]  [RED("headEvent")] public CName HeadEvent { get; set; }
		[Ordinal(2)]  [RED("legEvent")] public CName LegEvent { get; set; }

		public audioDismembermentSoundSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
