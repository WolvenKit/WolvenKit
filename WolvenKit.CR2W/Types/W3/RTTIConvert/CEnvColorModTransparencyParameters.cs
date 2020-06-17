using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvColorModTransparencyParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("commonFarDist")] 		public SSimpleCurve CommonFarDist { get; set;}

		[RED("filterNearColor")] 		public SSimpleCurve FilterNearColor { get; set;}

		[RED("filterFarColor")] 		public SSimpleCurve FilterFarColor { get; set;}

		[RED("contrastNearStrength")] 		public SSimpleCurve ContrastNearStrength { get; set;}

		[RED("contrastFarStrength")] 		public SSimpleCurve ContrastFarStrength { get; set;}

		[RED("autoHideCustom0")] 		public CEnvDistanceRangeParameters AutoHideCustom0 { get; set;}

		[RED("autoHideCustom1")] 		public CEnvDistanceRangeParameters AutoHideCustom1 { get; set;}

		[RED("autoHideCustom2")] 		public CEnvDistanceRangeParameters AutoHideCustom2 { get; set;}

		[RED("autoHideCustom3")] 		public CEnvDistanceRangeParameters AutoHideCustom3 { get; set;}

		public CEnvColorModTransparencyParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvColorModTransparencyParameters(cr2w);

	}
}