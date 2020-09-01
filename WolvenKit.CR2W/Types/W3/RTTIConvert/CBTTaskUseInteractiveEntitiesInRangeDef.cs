using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUseInteractiveEntitiesInRangeDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("animationEventName")] 		public CName AnimationEventName { get; set;}

		[Ordinal(2)] [RED("usableEntityTag")] 		public CName UsableEntityTag { get; set;}

		[Ordinal(3)] [RED("maxTriggeredEntities")] 		public CInt32 MaxTriggeredEntities { get; set;}

		[Ordinal(4)] [RED("delayBetweenUses")] 		public CFloat DelayBetweenUses { get; set;}

		[Ordinal(5)] [RED("checkDistance")] 		public CFloat CheckDistance { get; set;}

		[Ordinal(6)] [RED("minDistanceToSelf")] 		public CFloat MinDistanceToSelf { get; set;}

		[Ordinal(7)] [RED("targetType")] 		public CEnum<EChosenTarget> TargetType { get; set;}

		[Ordinal(8)] [RED("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(9)] [RED("betweenTargetAndSelf")] 		public CBool BetweenTargetAndSelf { get; set;}

		public CBTTaskUseInteractiveEntitiesInRangeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUseInteractiveEntitiesInRangeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}