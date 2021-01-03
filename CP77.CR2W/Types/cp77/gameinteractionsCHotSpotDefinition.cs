using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotDefinition : CVariable
	{
		[Ordinal(0)]  [RED("layersDefinition")] public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition { get; set; }
		[Ordinal(1)]  [RED("suppressor")] public CBool Suppressor { get; set; }

		public gameinteractionsCHotSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
