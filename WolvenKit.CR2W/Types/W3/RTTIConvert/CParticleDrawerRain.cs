using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerRain : IParticleDrawer
	{
		[Ordinal(1)] [RED("stretchPerVelocity")] 		public CFloat StretchPerVelocity { get; set;}

		[Ordinal(2)] [RED("blendStartVelocity")] 		public CFloat BlendStartVelocity { get; set;}

		[Ordinal(3)] [RED("blendEndVelocity")] 		public CFloat BlendEndVelocity { get; set;}

		public CParticleDrawerRain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleDrawerRain(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}