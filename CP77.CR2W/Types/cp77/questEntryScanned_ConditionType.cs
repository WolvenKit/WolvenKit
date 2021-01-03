using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntryScanned_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)]  [RED("entryID")] public TweakDBID EntryID { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questEntryScanned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
