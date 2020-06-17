using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerRain : IParticleDrawer
	{
		[RED("stretchPerVelocity")] 		public CFloat StretchPerVelocity { get; set;}

		[RED("blendStartVelocity")] 		public CFloat BlendStartVelocity { get; set;}

		[RED("blendEndVelocity")] 		public CFloat BlendEndVelocity { get; set;}

		public CParticleDrawerRain(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CParticleDrawerRain(cr2w);

	}
}