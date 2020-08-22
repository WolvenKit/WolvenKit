using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPathInstance : CVariable
	{
		[RED("id")] 		public CInt32 Id { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("splinePoints", 2,0)] 		public CArray<Vector> SplinePoints { get; set;}

		[RED("color")] 		public CInt32 Color { get; set;}

		[RED("lineWidth")] 		public CFloat LineWidth { get; set;}

		[RED("isAddedToMinimap")] 		public CBool IsAddedToMinimap { get; set;}

		public SMapPathInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMapPathInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}