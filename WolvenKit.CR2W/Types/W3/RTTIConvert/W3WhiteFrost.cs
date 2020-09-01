using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WhiteFrost : W3Petard
	{
		[Ordinal(0)] [RED("("waveProjectileTemplate")] 		public CHandle<CEntityTemplate> WaveProjectileTemplate { get; set;}

		[Ordinal(0)] [RED("("freezeNPCFadeInTime")] 		public CFloat FreezeNPCFadeInTime { get; set;}

		[Ordinal(0)] [RED("("waveSpeedModifier")] 		public CFloat WaveSpeedModifier { get; set;}

		[Ordinal(0)] [RED("("HAX_waveRadius")] 		public CFloat HAX_waveRadius { get; set;}

		[Ordinal(0)] [RED("("collisionMask", 2,0)] 		public CArray<CName> CollisionMask { get; set;}

		[Ordinal(0)] [RED("("shaderSpeed")] 		public CFloat ShaderSpeed { get; set;}

		[Ordinal(0)] [RED("("totalTime")] 		public CFloat TotalTime { get; set;}

		[Ordinal(0)] [RED("("collidedEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> CollidedEntities { get; set;}

		[Ordinal(0)] [RED("("waveProjectile")] 		public CHandle<W3WhiteFrostWaveProjectile> WaveProjectile { get; set;}

		public W3WhiteFrost(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WhiteFrost(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}