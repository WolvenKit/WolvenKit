using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AntiRadar : gameweaponObject
	{
		[Ordinal(57)] [RED("colliderComponent")] public CHandle<entIComponent> ColliderComponent { get; set; }
		[Ordinal(58)] [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(59)] [RED("gameEffectInstance")] public CHandle<gameEffectInstance> GameEffectInstance { get; set; }
		[Ordinal(60)] [RED("jammedSensorsArray")] public CArray<wCHandle<SensorDevice>> JammedSensorsArray { get; set; }

		public AntiRadar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
