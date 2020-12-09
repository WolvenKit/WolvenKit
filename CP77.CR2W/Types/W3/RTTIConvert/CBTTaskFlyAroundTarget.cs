using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAroundTarget : CBTTaskVolumetricMove
	{
		[Ordinal(1)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(2)] [RED("frontalHeadingOffset")] 		public CInt32 FrontalHeadingOffset { get; set;}

		[Ordinal(3)] [RED("randomFactor")] 		public CInt32 RandomFactor { get; set;}

		[Ordinal(4)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(5)] [RED("randomHeightAmplitude")] 		public CFloat RandomHeightAmplitude { get; set;}

		[Ordinal(6)] [RED("collisionGroupsNames", 2,0)] 		public CArray<CName> CollisionGroupsNames { get; set;}

		public CBTTaskFlyAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyAroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}