using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIBuffInfo : gameuiBuffInfo
	{
		[Ordinal(2)] [RED("isBuff")] public CBool IsBuff { get; set; }
		[Ordinal(3)] [RED("stackCount")] public CUInt32 StackCount { get; set; }

		public UIBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
