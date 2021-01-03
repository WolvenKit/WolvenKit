using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_ActionProperty : CVariable
	{
		[Ordinal(0)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(1)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(3)]  [RED("value")] public CVariant Value { get; set; }

		public questDeviceManager_ActionProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
