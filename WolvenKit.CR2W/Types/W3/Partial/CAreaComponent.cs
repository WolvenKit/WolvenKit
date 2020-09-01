using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CAreaComponent : CBoundedComponent
	{
		[Ordinal(1)] [RED("("height")] 		public CFloat Height { get; set;}

		[Ordinal(2)] [RED("("color")] 		public CColor Color { get; set;}

		[Ordinal(3)] [RED("("terrainSide")] 		public CEnum<EAreaTerrainSide> TerrainSide { get; set;}

		[Ordinal(4)] [RED("("clippingMode")] 		public CEnum<EAreaClippingMode> ClippingMode { get; set;}

		[Ordinal(5)] [RED("("clippingAreaTags")] 		public TagList ClippingAreaTags { get; set;}

		[Ordinal(6)] [RED("("saveShapeToLayer")] 		public CBool SaveShapeToLayer { get; set;}

		[Ordinal(7)] [RED("("localPoints", 2,0)] 		public CArray<Vector> LocalPoints { get; set;}

		[Ordinal(8)] [RED("("worldPoints", 2,0)] 		public CArray<Vector> WorldPoints { get; set;}

		public CAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}