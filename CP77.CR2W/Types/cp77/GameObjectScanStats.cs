using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameObjectScanStats : CVariable
	{
		[Ordinal(0)]  [RED("scannerData")] public scannerDataStructure ScannerData { get; set; }

		public GameObjectScanStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
