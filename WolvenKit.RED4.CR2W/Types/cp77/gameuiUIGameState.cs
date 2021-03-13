using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUIGameState : ISerializable
	{
		[Ordinal(0)] [RED("uiData")] public CArray<CHandle<gameuiBaseUIData>> UiData { get; set; }

		public gameuiUIGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
