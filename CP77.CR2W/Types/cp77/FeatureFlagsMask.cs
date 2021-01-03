using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FeatureFlagsMask : CVariable
	{
		[Ordinal(0)]  [RED("flags")] public CUInt64 Flags { get; set; }

		public FeatureFlagsMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
