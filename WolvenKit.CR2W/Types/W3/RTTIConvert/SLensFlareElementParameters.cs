using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareElementParameters : CVariable
	{
		[RED("material")] 		public CHandle<CMaterialInstance> Material { get; set;}

		[RED("isConstRadius")] 		public CBool IsConstRadius { get; set;}

		[RED("isAligned")] 		public CBool IsAligned { get; set;}

		[RED("centerFadeStart")] 		public CFloat CenterFadeStart { get; set;}

		[RED("centerFadeRange")] 		public CFloat CenterFadeRange { get; set;}

		[RED("colorGroupParamsIndex")] 		public CUInt32 ColorGroupParamsIndex { get; set;}

		[RED("alpha")] 		public CFloat Alpha { get; set;}

		[RED("size")] 		public CFloat Size { get; set;}

		[RED("aspect")] 		public CFloat Aspect { get; set;}

		[RED("shift")] 		public CFloat Shift { get; set;}

		[RED("pivot")] 		public CFloat Pivot { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		public SLensFlareElementParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLensFlareElementParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}