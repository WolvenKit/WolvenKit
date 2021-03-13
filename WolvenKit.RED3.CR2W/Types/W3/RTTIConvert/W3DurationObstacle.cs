using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DurationObstacle : CGameplayEntity
	{
		[Ordinal(1)] [RED("lifeTimeDuration")] 		public SRangeF LifeTimeDuration { get; set;}

		[Ordinal(2)] [RED("disappearanceEffectDuration")] 		public CFloat DisappearanceEffectDuration { get; set;}

		[Ordinal(3)] [RED("disappearEffectName")] 		public CName DisappearEffectName { get; set;}

		[Ordinal(4)] [RED("simplyStopEffect")] 		public CBool SimplyStopEffect { get; set;}

		public W3DurationObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DurationObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}