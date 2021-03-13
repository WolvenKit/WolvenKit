using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxSetup : CVariable
	{
		[Ordinal(0)] [RED("startingStation")] public CEnum<ERadioStationList> StartingStation { get; set; }
		[Ordinal(1)] [RED("glitchSFX")] public CName GlitchSFX { get; set; }
		[Ordinal(2)] [RED("paymentRecordID")] public TweakDBID PaymentRecordID { get; set; }

		public JukeboxSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
