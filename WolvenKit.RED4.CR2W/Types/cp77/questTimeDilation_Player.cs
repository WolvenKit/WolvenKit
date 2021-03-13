using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Player : questTimeDilation_NodeTypeParam
	{
		[Ordinal(0)] [RED("operation")] public CHandle<questTimeDilation_Operation> Operation { get; set; }
		[Ordinal(1)] [RED("globalTimeDilationOverride")] public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride { get; set; }

		public questTimeDilation_Player(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
