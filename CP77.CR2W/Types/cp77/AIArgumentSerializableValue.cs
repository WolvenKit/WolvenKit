using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIArgumentSerializableValue : AIArgumentDefinition
	{
		[Ordinal(0)]  [RED("defaultValue")] public CHandle<ISerializable> DefaultValue { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<AIArgumentType> Type { get; set; }

		public AIArgumentSerializableValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
