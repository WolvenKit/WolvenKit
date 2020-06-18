using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUseInteractiveEntitiesInRangeDef : IBehTreeTaskDefinition
	{
		[RED("animationEventName")] 		public CName AnimationEventName { get; set;}

		[RED("usableEntityTag")] 		public CName UsableEntityTag { get; set;}

		[RED("maxTriggeredEntities")] 		public CInt32 MaxTriggeredEntities { get; set;}

		[RED("delayBetweenUses")] 		public CFloat DelayBetweenUses { get; set;}

		[RED("checkDistance")] 		public CFloat CheckDistance { get; set;}

		[RED("minDistanceToSelf")] 		public CFloat MinDistanceToSelf { get; set;}

		[RED("targetType")] 		public CEnum<EChosenTarget> TargetType { get; set;}

		[RED("targetTag")] 		public CName TargetTag { get; set;}

		[RED("betweenTargetAndSelf")] 		public CBool BetweenTargetAndSelf { get; set;}

		public CBTTaskUseInteractiveEntitiesInRangeDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskUseInteractiveEntitiesInRangeDef(cr2w);

	}
}