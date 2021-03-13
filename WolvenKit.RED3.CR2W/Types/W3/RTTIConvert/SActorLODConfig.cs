using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SActorLODConfig : CVariable
	{
		[Ordinal(1)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(2)] [RED("deadZone")] 		public CFloat DeadZone { get; set;}

		[Ordinal(3)] [RED("hide")] 		public CBool Hide { get; set;}

		[Ordinal(4)] [RED("enableIK")] 		public CBool EnableIK { get; set;}

		[Ordinal(5)] [RED("enableDandles")] 		public CBool EnableDandles { get; set;}

		[Ordinal(6)] [RED("mimicsQuality")] 		public CUInt32 MimicsQuality { get; set;}

		[Ordinal(7)] [RED("behaviorLOD")] 		public CEnum<EBehaviorLod> BehaviorLOD { get; set;}

		[Ordinal(8)] [RED("animatedComponentUpdateFrameSkip")] 		public CUInt32 AnimatedComponentUpdateFrameSkip { get; set;}

		[Ordinal(9)] [RED("suppressAnimatedComponent")] 		public CBool SuppressAnimatedComponent { get; set;}

		[Ordinal(10)] [RED("budgetAnimatedComponentTick")] 		public CBool BudgetAnimatedComponentTick { get; set;}

		[Ordinal(11)] [RED("suppressAnimatedComponentIfNotVisible")] 		public CBool SuppressAnimatedComponentIfNotVisible { get; set;}

		[Ordinal(12)] [RED("budgetAnimatedComponentTickIfNotVisible")] 		public CBool BudgetAnimatedComponentTickIfNotVisible { get; set;}

		public SActorLODConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SActorLODConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}