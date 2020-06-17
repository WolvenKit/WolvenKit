using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AardEntity : W3SignEntity
	{
		[RED("aspects", 2,0)] 		public CArray<SAardAspect> Aspects { get; set;}

		[RED("effects", 2,0)] 		public CArray<SAardEffects> Effects { get; set;}

		[RED("waterTestOffsetZ")] 		public CFloat WaterTestOffsetZ { get; set;}

		[RED("waterTestDistancePerc")] 		public CFloat WaterTestDistancePerc { get; set;}

		public W3AardEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3AardEntity(cr2w);

	}
}