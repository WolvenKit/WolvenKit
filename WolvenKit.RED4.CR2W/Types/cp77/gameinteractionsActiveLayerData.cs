using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
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
