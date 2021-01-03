using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetTimestampToBehaviorAgrument : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("timestampArgument")] public CName TimestampArgument { get; set; }

		public SetTimestampToBehaviorAgrument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
