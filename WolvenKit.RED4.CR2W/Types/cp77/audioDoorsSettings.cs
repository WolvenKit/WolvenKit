using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDoorsSettings : audioDeviceSettings
	{
		[Ordinal(7)] [RED("openEvent")] public CName OpenEvent { get; set; }
		[Ordinal(8)] [RED("openFailedEvent")] public CName OpenFailedEvent { get; set; }
		[Ordinal(9)] [RED("closeEvent")] public CName CloseEvent { get; set; }
		[Ordinal(10)] [RED("lockEvent")] public CName LockEvent { get; set; }
		[Ordinal(11)] [RED("unlockEvent")] public CName UnlockEvent { get; set; }
		[Ordinal(12)] [RED("sealEvent")] public CName SealEvent { get; set; }
		[Ordinal(13)] [RED("soundBank")] public CName SoundBank { get; set; }

		public audioDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
