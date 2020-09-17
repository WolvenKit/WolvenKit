using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SonarEnttity : CEntity
	{
		[Ordinal(1)] [RED("scaleVector")] 		public Vector ScaleVector { get; set;}

		[Ordinal(2)] [RED("sonarScaleRate")] 		public CFloat SonarScaleRate { get; set;}

		[Ordinal(3)] [RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(4)] [RED("speedModifier")] 		public CFloat SpeedModifier { get; set;}

		[Ordinal(5)] [RED("stopHighlightAfter")] 		public CFloat StopHighlightAfter { get; set;}

		[Ordinal(6)] [RED("sonarComponent")] 		public CHandle<CComponent> SonarComponent { get; set;}

		public W3SonarEnttity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SonarEnttity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}