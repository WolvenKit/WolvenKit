using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSimpleCurve : CVariable
	{
		[Ordinal(1)] [RED("CurveType")] 		public CEnum<ESimpleCurveType> CurveType { get; set;}

		[Ordinal(2)] [RED("ScalarEditScale")] 		public CFloat ScalarEditScale { get; set;}

		[Ordinal(3)] [RED("ScalarEditOrigin")] 		public CFloat ScalarEditOrigin { get; set;}

		[Ordinal(4)] [RED("dataCurveValues", 142,0)] 		public CArray<SCurveDataEntry> DataCurveValues { get; set;}

		[Ordinal(5)] [RED("dataBaseType")] 		public CEnum<ECurveBaseType> DataBaseType { get; set;}

		public SSimpleCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSimpleCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}