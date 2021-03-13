using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuInitData : IScriptable
	{
		[Ordinal(0)] [RED("menuName")] public CName MenuName { get; set; }
		[Ordinal(1)] [RED("submenuName")] public CName SubmenuName { get; set; }
		[Ordinal(2)] [RED("userData")] public CHandle<IScriptable> UserData { get; set; }

		public HubMenuInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
