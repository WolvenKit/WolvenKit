using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFlareParameters : CVariable
	{
		[Ordinal(1)] [RED("category")] 		public CEnum<EFlareCategory> Category { get; set;}

		[Ordinal(2)] [RED("colorGroup")] 		public CEnum<EEnvFlareColorGroup> ColorGroup { get; set;}

		[Ordinal(3)] [RED("lensFlareGroup")] 		public CEnum<ELensFlareGroup> LensFlareGroup { get; set;}

		[Ordinal(4)] [RED("occlusionExtent")] 		public CFloat OcclusionExtent { get; set;}

		[Ordinal(5)] [RED("flareRadius")] 		public CFloat FlareRadius { get; set;}

		[Ordinal(6)] [RED("fadeInMaxSpeed")] 		public CFloat FadeInMaxSpeed { get; set;}

		[Ordinal(7)] [RED("fadeOutMaxSpeed")] 		public CFloat FadeOutMaxSpeed { get; set;}

		[Ordinal(8)] [RED("fadeInAccel")] 		public CFloat FadeInAccel { get; set;}

		[Ordinal(9)] [RED("fadeOutAccel")] 		public CFloat FadeOutAccel { get; set;}

		[Ordinal(10)] [RED("visibilityFullDist")] 		public CFloat VisibilityFullDist { get; set;}

		[Ordinal(11)] [RED("visibilityFadeRange")] 		public CFloat VisibilityFadeRange { get; set;}

		public SFlareParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}