using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvShadowsParameters : CVariable
	{
		[Ordinal(1)] [RED("("activatedAutoHide")] 		public CBool ActivatedAutoHide { get; set;}

		[Ordinal(2)] [RED("("autoHideBoxSizeMin")] 		public SSimpleCurve AutoHideBoxSizeMin { get; set;}

		[Ordinal(3)] [RED("("autoHideBoxSizeMax")] 		public SSimpleCurve AutoHideBoxSizeMax { get; set;}

		[Ordinal(4)] [RED("("autoHideBoxCompMaxX")] 		public SSimpleCurve AutoHideBoxCompMaxX { get; set;}

		[Ordinal(5)] [RED("("autoHideBoxCompMaxY")] 		public SSimpleCurve AutoHideBoxCompMaxY { get; set;}

		[Ordinal(6)] [RED("("autoHideBoxCompMaxZ")] 		public SSimpleCurve AutoHideBoxCompMaxZ { get; set;}

		[Ordinal(7)] [RED("("autoHideDistScale")] 		public SSimpleCurve AutoHideDistScale { get; set;}

		public CEnvShadowsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvShadowsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}