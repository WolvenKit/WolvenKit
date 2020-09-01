using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFlareParameters : CVariable
	{
		[Ordinal(0)] [RED("("category")] 		public CEnum<EFlareCategory> Category { get; set;}

		[Ordinal(0)] [RED("("colorGroup")] 		public CEnum<EEnvFlareColorGroup> ColorGroup { get; set;}

		[Ordinal(0)] [RED("("lensFlareGroup")] 		public CEnum<ELensFlareGroup> LensFlareGroup { get; set;}

		[Ordinal(0)] [RED("("occlusionExtent")] 		public CFloat OcclusionExtent { get; set;}

		[Ordinal(0)] [RED("("flareRadius")] 		public CFloat FlareRadius { get; set;}

		[Ordinal(0)] [RED("("fadeInMaxSpeed")] 		public CFloat FadeInMaxSpeed { get; set;}

		[Ordinal(0)] [RED("("fadeOutMaxSpeed")] 		public CFloat FadeOutMaxSpeed { get; set;}

		[Ordinal(0)] [RED("("fadeInAccel")] 		public CFloat FadeInAccel { get; set;}

		[Ordinal(0)] [RED("("fadeOutAccel")] 		public CFloat FadeOutAccel { get; set;}

		[Ordinal(0)] [RED("("visibilityFullDist")] 		public CFloat VisibilityFullDist { get; set;}

		[Ordinal(0)] [RED("("visibilityFadeRange")] 		public CFloat VisibilityFadeRange { get; set;}

		public SFlareParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFlareParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}