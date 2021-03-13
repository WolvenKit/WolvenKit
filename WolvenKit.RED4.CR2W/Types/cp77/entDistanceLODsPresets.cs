using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDistanceLODsPresets : ISerializable
	{
		[Ordinal(0)] [RED("definitions", 4)] public CStatic<entLODDefinition> Definitions { get; set; }

		public entDistanceLODsPresets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
