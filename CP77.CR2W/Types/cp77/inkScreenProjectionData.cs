using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkScreenProjectionData : CVariable
	{
		[Ordinal(0)]  [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(1)]  [RED("fixedWorldOffset")] public Vector4 FixedWorldOffset { get; set; }
		[Ordinal(2)]  [RED("slotComponentName")] public CName SlotComponentName { get; set; }
		[Ordinal(3)]  [RED("slotFallbackName")] public CName SlotFallbackName { get; set; }
		[Ordinal(4)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)]  [RED("staticWorldPosition")] public Vector4 StaticWorldPosition { get; set; }
		[Ordinal(6)]  [RED("userData")] public wCHandle<IScriptable> UserData { get; set; }

		public inkScreenProjectionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
