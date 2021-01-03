using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CuttingGrenadePotentialTarget : CVariable
	{
		[Ordinal(0)]  [RED("entity")] public wCHandle<ScriptedPuppet> Entity { get; set; }
		[Ordinal(1)]  [RED("hits")] public CInt32 Hits { get; set; }

		public CuttingGrenadePotentialTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
