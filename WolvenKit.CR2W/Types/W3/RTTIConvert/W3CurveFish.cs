using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CurveFish : CGameplayEntity
	{
		[Ordinal(0)] [RED("("destroyDistance")] 		public CFloat DestroyDistance { get; set;}

		[Ordinal(0)] [RED("("swimCurves", 2,0)] 		public CArray<CName> SwimCurves { get; set;}

		[Ordinal(0)] [RED("("speedUpChance")] 		public CFloat SpeedUpChance { get; set;}

		[Ordinal(0)] [RED("("baseSpeedVariance")] 		public CFloat BaseSpeedVariance { get; set;}

		[Ordinal(0)] [RED("("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[Ordinal(0)] [RED("("randomizedAppearances", 2,0)] 		public CArray<CString> RandomizedAppearances { get; set;}

		[Ordinal(0)] [RED("("manager")] 		public CHandle<W3CurveFishManager> Manager { get; set;}

		[Ordinal(0)] [RED("("baseSpeed")] 		public CFloat BaseSpeed { get; set;}

		[Ordinal(0)] [RED("("selectedSwimCurve")] 		public CName SelectedSwimCurve { get; set;}

		[Ordinal(0)] [RED("("currentSpeed")] 		public CFloat CurrentSpeed { get; set;}

		[Ordinal(0)] [RED("("accelerate")] 		public CBool Accelerate { get; set;}

		public W3CurveFish(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CurveFish(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}