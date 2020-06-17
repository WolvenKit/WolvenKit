using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleModificatorSize3DOverLife : IParticleModificator
	{
		[RED("size")] 		public CPtr<IEvaluatorVector> Size { get; set;}

		[RED("modulate")] 		public CBool Modulate { get; set;}

		public CParticleModificatorSize3DOverLife(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CParticleModificatorSize3DOverLife(cr2w);

	}
}