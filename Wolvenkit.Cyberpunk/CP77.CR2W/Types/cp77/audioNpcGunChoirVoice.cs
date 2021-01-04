using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirVoice : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("autoFireSound")] public CName AutoFireSound { get; set; }
		[Ordinal(1)]  [RED("autoFireStop")] public CName AutoFireStop { get; set; }
		[Ordinal(2)]  [RED("burstFireSound")] public CName BurstFireSound { get; set; }
		[Ordinal(3)]  [RED("chargedSound")] public CName ChargedSound { get; set; }
		[Ordinal(4)]  [RED("fireSound")] public CName FireSound { get; set; }
		[Ordinal(5)]  [RED("init")] public CName Init { get; set; }
		[Ordinal(6)]  [RED("shutdown")] public CName Shutdown { get; set; }

		public audioNpcGunChoirVoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
