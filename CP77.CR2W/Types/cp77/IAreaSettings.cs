using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IAreaSettings : ISerializable
	{
		[Ordinal(0)]  [RED("disabledIndexedProperties")] public CUInt64 DisabledIndexedProperties { get; set; }
		[Ordinal(1)]  [RED("enable")] public CBool Enable { get; set; }

		public IAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
