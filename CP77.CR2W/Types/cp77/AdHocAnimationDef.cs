using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AdHocAnimationDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("AnimationIndex")] public gamebbScriptID_Int32 AnimationIndex { get; set; }
		[Ordinal(1)]  [RED("IsActive")] public gamebbScriptID_Bool IsActive { get; set; }
		[Ordinal(2)]  [RED("UnequipWeapon")] public gamebbScriptID_Bool UnequipWeapon { get; set; }
		[Ordinal(3)]  [RED("UseBothHands")] public gamebbScriptID_Bool UseBothHands { get; set; }

		public AdHocAnimationDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
