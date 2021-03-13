using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformRequestBase : CVariable
	{
		[Ordinal(0)] [RED("applyServerTime")] public netTime ApplyServerTime { get; set; }

		public gameReplAnimTransformRequestBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
