using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsActiveLayerData : CVariable
	{
		[Ordinal(0)] [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(1)] [RED("linkedLayersName")] public CName LinkedLayersName { get; set; }
		[Ordinal(2)] [RED("layerName")] public CName LayerName { get; set; }

		public gameinteractionsActiveLayerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
