using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AntiRadar : gameweaponObject
	{
		[Ordinal(0)]  [RED("colliderComponent")] public CHandle<entIComponent> ColliderComponent { get; set; }
		[Ordinal(1)]  [RED("gameEffectInstance")] public CHandle<gameEffectInstance> GameEffectInstance { get; set; }
		[Ordinal(2)]  [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(3)]  [RED("jammedSensorsArray")] public CArray<wCHandle<SensorDevice>> JammedSensorsArray { get; set; }

		public AntiRadar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
