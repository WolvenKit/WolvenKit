using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AntiRadar : gameweaponObject
	{
		[Ordinal(46)]  [RED("colliderComponent")] public CHandle<entIComponent> ColliderComponent { get; set; }
		[Ordinal(47)]  [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(48)]  [RED("gameEffectInstance")] public CHandle<gameEffectInstance> GameEffectInstance { get; set; }
		[Ordinal(49)]  [RED("jammedSensorsArray")] public CArray<wCHandle<SensorDevice>> JammedSensorsArray { get; set; }

		public AntiRadar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
