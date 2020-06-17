using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCurveEntitySpawner : CObject
	{
		[RED("density")] 		public CUInt32 Density { get; set;}

		[RED("variation")] 		public CFloat Variation { get; set;}

		[RED("templateWeights", 2,0)] 		public CArray<SEntityWeight> TemplateWeights { get; set;}

		public CCurveEntitySpawner(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCurveEntitySpawner(cr2w);

	}
}