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
		[RED("destroyDistance")] 		public CFloat DestroyDistance { get; set;}

		[RED("swimCurves", 2,0)] 		public CArray<CName> SwimCurves { get; set;}

		[RED("speedUpChance")] 		public CFloat SpeedUpChance { get; set;}

		[RED("baseSpeedVariance")] 		public CFloat BaseSpeedVariance { get; set;}

		[RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[RED("randomizedAppearances", 2,0)] 		public CArray<CString> RandomizedAppearances { get; set;}

		[RED("manager")] 		public CHandle<W3CurveFishManager> Manager { get; set;}

		[RED("baseSpeed")] 		public CFloat BaseSpeed { get; set;}

		[RED("selectedSwimCurve")] 		public CName SelectedSwimCurve { get; set;}

		[RED("currentSpeed")] 		public CFloat CurrentSpeed { get; set;}

		[RED("accelerate")] 		public CBool Accelerate { get; set;}

		public W3CurveFish(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CurveFish(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}