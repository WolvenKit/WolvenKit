using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetArgumentVector : SetArguments
	{
		[Ordinal(1)] [RED("newValue")] public CHandle<AIArgumentMapping> NewValue { get; set; }

		public SetArgumentVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
