using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFlareParameters : CVariable
	{
		[RED("category")] 		public EFlareCategory Category { get; set;}

		[RED("colorGroup")] 		public EEnvFlareColorGroup ColorGroup { get; set;}

		[RED("lensFlareGroup")] 		public ELensFlareGroup LensFlareGroup { get; set;}

		[RED("occlusionExtent")] 		public CFloat OcclusionExtent { get; set;}

		[RED("flareRadius")] 		public CFloat FlareRadius { get; set;}

		[RED("fadeInMaxSpeed")] 		public CFloat FadeInMaxSpeed { get; set;}

		[RED("fadeOutMaxSpeed")] 		public CFloat FadeOutMaxSpeed { get; set;}

		[RED("fadeInAccel")] 		public CFloat FadeInAccel { get; set;}

		[RED("fadeOutAccel")] 		public CFloat FadeOutAccel { get; set;}

		[RED("visibilityFullDist")] 		public CFloat VisibilityFullDist { get; set;}

		[RED("visibilityFadeRange")] 		public CFloat VisibilityFadeRange { get; set;}

		public SFlareParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFlareParameters(cr2w);

	}
}