using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioDoorsSettings : audioDeviceSettings
	{
		[Ordinal(0)]  [RED("closeEvent")] public CName CloseEvent { get; set; }
		[Ordinal(1)]  [RED("lockEvent")] public CName LockEvent { get; set; }
		[Ordinal(2)]  [RED("openEvent")] public CName OpenEvent { get; set; }
		[Ordinal(3)]  [RED("openFailedEvent")] public CName OpenFailedEvent { get; set; }
		[Ordinal(4)]  [RED("sealEvent")] public CName SealEvent { get; set; }
		[Ordinal(5)]  [RED("soundBank")] public CName SoundBank { get; set; }
		[Ordinal(6)]  [RED("unlockEvent")] public CName UnlockEvent { get; set; }

		public audioDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
