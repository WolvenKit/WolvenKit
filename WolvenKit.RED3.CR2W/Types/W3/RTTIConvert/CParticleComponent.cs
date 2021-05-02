using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleComponent : CDrawableComponent
	{
		[Ordinal(1)] [RED("particleSystem")] 		public CHandle<CParticleSystem> ParticleSystem { get; set;}

		[Ordinal(2)] [RED("transparencySortGroup")] 		public CEnum<ETransparencySortGroup> TransparencySortGroup { get; set;}

		[Ordinal(3)] [RED("envAutoHideGroup")] 		public CEnum<EEnvAutoHideGroup> EnvAutoHideGroup { get; set;}

		public CParticleComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}