using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNavmeshComponent : CAreaComponent
	{
		[RED("navmeshParams")] 		public SNavmeshParams NavmeshParams { get; set;}

		[RED("pathlibAreaId")] 		public CUInt16 PathlibAreaId { get; set;}

		[RED("sharedFileName")] 		public CString SharedFileName { get; set;}

		[RED("generationRootPoints", 2,0)] 		public CArray<Vector> GenerationRootPoints { get; set;}

		public CNavmeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNavmeshComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}