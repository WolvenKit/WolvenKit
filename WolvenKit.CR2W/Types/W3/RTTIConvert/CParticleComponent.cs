using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleComponent : CDrawableComponent
	{
		[RED("particleSystem")] 		public CHandle<CParticleSystem> ParticleSystem { get; set;}

		[RED("transparencySortGroup")] 		public CEnum<ETransparencySortGroup> TransparencySortGroup { get; set;}

		[RED("envAutoHideGroup")] 		public CEnum<EEnvAutoHideGroup> EnvAutoHideGroup { get; set;}

		public CParticleComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CParticleComponent(cr2w);

	}
}