using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPathInstance : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CInt32 Id { get; set;}

		[Ordinal(2)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(3)] [RED("splinePoints", 2,0)] 		public CArray<Vector> SplinePoints { get; set;}

		[Ordinal(4)] [RED("color")] 		public CInt32 Color { get; set;}

		[Ordinal(5)] [RED("lineWidth")] 		public CFloat LineWidth { get; set;}

		[Ordinal(6)] [RED("isAddedToMinimap")] 		public CBool IsAddedToMinimap { get; set;}

		public SMapPathInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMapPathInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}