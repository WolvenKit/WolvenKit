using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SActorLODConfig : CVariable
	{
		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("deadZone")] 		public CFloat DeadZone { get; set;}

		[RED("hide")] 		public CBool Hide { get; set;}

		[RED("enableIK")] 		public CBool EnableIK { get; set;}

		[RED("enableDandles")] 		public CBool EnableDandles { get; set;}

		[RED("mimicsQuality")] 		public CUInt32 MimicsQuality { get; set;}

		[RED("behaviorLOD")] 		public CEnum<EBehaviorLod> BehaviorLOD { get; set;}

		[RED("animatedComponentUpdateFrameSkip")] 		public CUInt32 AnimatedComponentUpdateFrameSkip { get; set;}

		[RED("suppressAnimatedComponent")] 		public CBool SuppressAnimatedComponent { get; set;}

		[RED("budgetAnimatedComponentTick")] 		public CBool BudgetAnimatedComponentTick { get; set;}

		[RED("suppressAnimatedComponentIfNotVisible")] 		public CBool SuppressAnimatedComponentIfNotVisible { get; set;}

		[RED("budgetAnimatedComponentTickIfNotVisible")] 		public CBool BudgetAnimatedComponentTickIfNotVisible { get; set;}

		public SActorLODConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SActorLODConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}