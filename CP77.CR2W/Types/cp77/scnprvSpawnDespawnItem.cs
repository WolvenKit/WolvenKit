using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnprvSpawnDespawnItem : CVariable
	{
		[Ordinal(0)]  [RED("finalTransform")] public Transform FinalTransform { get; set; }
		[Ordinal(1)]  [RED("recordID")] public TweakDBID RecordID { get; set; }

		public scnprvSpawnDespawnItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
