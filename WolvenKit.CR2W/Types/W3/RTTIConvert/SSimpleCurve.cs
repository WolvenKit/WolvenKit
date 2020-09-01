using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSimpleCurve : CVariable
	{
		[Ordinal(0)] [RED("("CurveType")] 		public CEnum<ESimpleCurveType> CurveType { get; set;}

		[Ordinal(0)] [RED("("ScalarEditScale")] 		public CFloat ScalarEditScale { get; set;}

		[Ordinal(0)] [RED("("ScalarEditOrigin")] 		public CFloat ScalarEditOrigin { get; set;}

		[Ordinal(0)] [RED("("dataCurveValues", 142,0)] 		public CArray<SCurveDataEntry> DataCurveValues { get; set;}

		[Ordinal(0)] [RED("("dataBaseType")] 		public CEnum<ECurveBaseType> DataBaseType { get; set;}

		public SSimpleCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSimpleCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}