using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiStaticIconLogicController : gameuiDynamicIconLogicController
	{
		[Ordinal(0)]  [RED("iconReference")] public TweakDBID IconReference { get; set; }

		public gameuiStaticIconLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
