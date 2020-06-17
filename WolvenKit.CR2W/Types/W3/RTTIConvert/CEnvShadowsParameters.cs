using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvShadowsParameters : CVariable
	{
		[RED("activatedAutoHide")] 		public CBool ActivatedAutoHide { get; set;}

		[RED("autoHideBoxSizeMin")] 		public SSimpleCurve AutoHideBoxSizeMin { get; set;}

		[RED("autoHideBoxSizeMax")] 		public SSimpleCurve AutoHideBoxSizeMax { get; set;}

		[RED("autoHideBoxCompMaxX")] 		public SSimpleCurve AutoHideBoxCompMaxX { get; set;}

		[RED("autoHideBoxCompMaxY")] 		public SSimpleCurve AutoHideBoxCompMaxY { get; set;}

		[RED("autoHideBoxCompMaxZ")] 		public SSimpleCurve AutoHideBoxCompMaxZ { get; set;}

		[RED("autoHideDistScale")] 		public SSimpleCurve AutoHideDistScale { get; set;}

		public CEnvShadowsParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvShadowsParameters(cr2w);

	}
}