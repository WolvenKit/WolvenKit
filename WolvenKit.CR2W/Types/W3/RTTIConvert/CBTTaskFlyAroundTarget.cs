using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAroundTarget : CBTTaskVolumetricMove
	{
		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("frontalHeadingOffset")] 		public CInt32 FrontalHeadingOffset { get; set;}

		[RED("randomFactor")] 		public CInt32 RandomFactor { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("randomHeightAmplitude")] 		public CFloat RandomHeightAmplitude { get; set;}

		[RED("collisionGroupsNames", 2,0)] 		public CArray<CName> CollisionGroupsNames { get; set;}

		public CBTTaskFlyAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyAroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}