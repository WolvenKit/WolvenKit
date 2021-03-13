using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameComponent : entIComponent
	{
		[Ordinal(3)] [RED("persistentState")] public CHandle<gamePersistentState> PersistentState { get; set; }

		public gameComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
