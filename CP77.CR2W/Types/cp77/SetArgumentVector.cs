using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetArgumentVector : SetArguments
	{
		[Ordinal(0)]  [RED("newValue")] public CHandle<AIArgumentMapping> NewValue { get; set; }

		public SetArgumentVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
