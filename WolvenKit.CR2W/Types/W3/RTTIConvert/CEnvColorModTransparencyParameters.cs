using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvColorModTransparencyParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("commonFarDist")] 		public SSimpleCurve CommonFarDist { get; set;}

		[Ordinal(3)] [RED("filterNearColor")] 		public SSimpleCurve FilterNearColor { get; set;}

		[Ordinal(4)] [RED("filterFarColor")] 		public SSimpleCurve FilterFarColor { get; set;}

		[Ordinal(5)] [RED("contrastNearStrength")] 		public SSimpleCurve ContrastNearStrength { get; set;}

		[Ordinal(6)] [RED("contrastFarStrength")] 		public SSimpleCurve ContrastFarStrength { get; set;}

		[Ordinal(7)] [RED("autoHideCustom0")] 		public CEnvDistanceRangeParameters AutoHideCustom0 { get; set;}

		[Ordinal(8)] [RED("autoHideCustom1")] 		public CEnvDistanceRangeParameters AutoHideCustom1 { get; set;}

		[Ordinal(9)] [RED("autoHideCustom2")] 		public CEnvDistanceRangeParameters AutoHideCustom2 { get; set;}

		[Ordinal(10)] [RED("autoHideCustom3")] 		public CEnvDistanceRangeParameters AutoHideCustom3 { get; set;}

		public CEnvColorModTransparencyParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvColorModTransparencyParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}