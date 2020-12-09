using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWetnessComponent : CComponent
	{
		[Ordinal(1)] [RED("blendInFromOcean")] 		public CFloat BlendInFromOcean { get; set;}

		[Ordinal(2)] [RED("blendInFromRain")] 		public CFloat BlendInFromRain { get; set;}

		[Ordinal(3)] [RED("blendOutFromOcean")] 		public CFloat BlendOutFromOcean { get; set;}

		[Ordinal(4)] [RED("blendOutFromRain")] 		public CFloat BlendOutFromRain { get; set;}

		public CWetnessComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWetnessComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}