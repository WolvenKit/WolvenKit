using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirVoice : audioAudioMetadata
	{
		[Ordinal(1)] [RED("fireSound")] public CName FireSound { get; set; }
		[Ordinal(2)] [RED("burstFireSound")] public CName BurstFireSound { get; set; }
		[Ordinal(3)] [RED("chargedSound")] public CName ChargedSound { get; set; }
		[Ordinal(4)] [RED("autoFireSound")] public CName AutoFireSound { get; set; }
		[Ordinal(5)] [RED("autoFireStop")] public CName AutoFireStop { get; set; }
		[Ordinal(6)] [RED("shutdown")] public CName Shutdown { get; set; }
		[Ordinal(7)] [RED("init")] public CName Init { get; set; }

		public audioNpcGunChoirVoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
