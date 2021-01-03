using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLayerActivatedPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)]  [RED("layerName")] public CName LayerName { get; set; }
		[Ordinal(1)]  [RED("linkedLayersName")] public CName LinkedLayersName { get; set; }

		public gameinteractionsLayerActivatedPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
