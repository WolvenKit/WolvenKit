using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiContraPlatform : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(0)]  [RED("image")] public inkImageWidgetReference Image { get; set; }

		public gameuiContraPlatform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
