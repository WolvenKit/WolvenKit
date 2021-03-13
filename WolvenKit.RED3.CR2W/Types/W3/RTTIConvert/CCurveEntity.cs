using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCurveEntity : CEntity
	{
		[Ordinal(1)] [RED("curveComponent")] 		public CPtr<CCurveComponent> CurveComponent { get; set;}

		[Ordinal(2)] [RED("controlPointEntities", 2,0)] 		public CArray<CPtr<CCurveControlPointEntity>> ControlPointEntities { get; set;}

		[Ordinal(3)] [RED("curveEntitySpawner")] 		public CPtr<CCurveEntitySpawner> CurveEntitySpawner { get; set;}

		public CCurveEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCurveEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}