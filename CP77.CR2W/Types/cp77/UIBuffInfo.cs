using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UIBuffInfo : gameuiBuffInfo
	{
		[Ordinal(0)]  [RED("isBuff")] public CBool IsBuff { get; set; }
		[Ordinal(1)]  [RED("stackCount")] public CUInt32 StackCount { get; set; }

		public UIBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
