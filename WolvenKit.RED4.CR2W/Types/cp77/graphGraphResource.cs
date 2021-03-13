using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphResource : CResource
	{
		[Ordinal(1)] [RED("graph")] public CHandle<graphGraphDefinition> Graph { get; set; }

		public graphGraphResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
