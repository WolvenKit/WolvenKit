using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemDropObject : gameLootObject
	{
		[Ordinal(43)] [RED("wasItemInitialized")] public CBool WasItemInitialized { get; set; }

		public gameItemDropObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
