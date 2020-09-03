using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareElementParameters : CVariable
	{
		[Ordinal(1)] [RED("material")] 		public CHandle<CMaterialInstance> Material { get; set;}

		[Ordinal(2)] [RED("isConstRadius")] 		public CBool IsConstRadius { get; set;}

		[Ordinal(3)] [RED("isAligned")] 		public CBool IsAligned { get; set;}

		[Ordinal(4)] [RED("centerFadeStart")] 		public CFloat CenterFadeStart { get; set;}

		[Ordinal(5)] [RED("centerFadeRange")] 		public CFloat CenterFadeRange { get; set;}

		[Ordinal(6)] [RED("colorGroupParamsIndex")] 		public CUInt32 ColorGroupParamsIndex { get; set;}

		[Ordinal(7)] [RED("alpha")] 		public CFloat Alpha { get; set;}

		[Ordinal(8)] [RED("size")] 		public CFloat Size { get; set;}

		[Ordinal(9)] [RED("aspect")] 		public CFloat Aspect { get; set;}

		[Ordinal(10)] [RED("shift")] 		public CFloat Shift { get; set;}

		[Ordinal(11)] [RED("pivot")] 		public CFloat Pivot { get; set;}

		[Ordinal(12)] [RED("color")] 		public CColor Color { get; set;}

		public SLensFlareElementParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLensFlareElementParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}