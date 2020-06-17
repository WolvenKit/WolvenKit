using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWetnessComponent : CComponent
	{
		[RED("blendInFromOcean")] 		public CFloat BlendInFromOcean { get; set;}

		[RED("blendInFromRain")] 		public CFloat BlendInFromRain { get; set;}

		[RED("blendOutFromOcean")] 		public CFloat BlendOutFromOcean { get; set;}

		[RED("blendOutFromRain")] 		public CFloat BlendOutFromRain { get; set;}

		public CWetnessComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CWetnessComponent(cr2w);

	}
}