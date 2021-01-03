using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilities : ScannerChunk
	{
		[Ordinal(0)]  [RED("abilities")] public CArray<wCHandle<gamedataGameplayAbility_Record>> Abilities { get; set; }

		public ScannerAbilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
