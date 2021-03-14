using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleModificatorRotationOverLife : IParticleModificator
	{
		[Ordinal(1)] [RED("rotation")] 		public CPtr<IEvaluatorFloat> Rotation { get; set;}

		[Ordinal(2)] [RED("modulate")] 		public CBool Modulate { get; set;}

		public CParticleModificatorRotationOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleModificatorRotationOverLife(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}