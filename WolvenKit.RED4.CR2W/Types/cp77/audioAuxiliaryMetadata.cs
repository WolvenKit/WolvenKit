using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAuxiliaryMetadata : CVariable
	{
		[Ordinal(0)] [RED("physicalPropSettings")] public CName PhysicalPropSettings { get; set; }

		public audioAuxiliaryMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
