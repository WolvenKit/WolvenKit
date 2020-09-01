using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareElementParameters : CVariable
	{
		[Ordinal(0)] [RED("("material")] 		public CHandle<CMaterialInstance> Material { get; set;}

		[Ordinal(0)] [RED("("isConstRadius")] 		public CBool IsConstRadius { get; set;}

		[Ordinal(0)] [RED("("isAligned")] 		public CBool IsAligned { get; set;}

		[Ordinal(0)] [RED("("centerFadeStart")] 		public CFloat CenterFadeStart { get; set;}

		[Ordinal(0)] [RED("("centerFadeRange")] 		public CFloat CenterFadeRange { get; set;}

		[Ordinal(0)] [RED("("colorGroupParamsIndex")] 		public CUInt32 ColorGroupParamsIndex { get; set;}

		[Ordinal(0)] [RED("("alpha")] 		public CFloat Alpha { get; set;}

		[Ordinal(0)] [RED("("size")] 		public CFloat Size { get; set;}

		[Ordinal(0)] [RED("("aspect")] 		public CFloat Aspect { get; set;}

		[Ordinal(0)] [RED("("shift")] 		public CFloat Shift { get; set;}

		[Ordinal(0)] [RED("("pivot")] 		public CFloat Pivot { get; set;}

		[Ordinal(0)] [RED("("color")] 		public CColor Color { get; set;}

		public SLensFlareElementParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLensFlareElementParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}