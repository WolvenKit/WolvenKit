using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetScanningState : CVariable
	{
		[Ordinal(0)]  [RED("isScanning")] public CBool IsScanning { get; set; }

		public gameMuppetScanningState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
