using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUseInteractiveEntitiesInRange : IBehTreeTask
	{
		[Ordinal(0)] [RED("animationEventName")] 		public CName AnimationEventName { get; set;}

		[Ordinal(0)] [RED("usableEntityTag")] 		public CName UsableEntityTag { get; set;}

		[Ordinal(0)] [RED("maxTriggeredEntities")] 		public CInt32 MaxTriggeredEntities { get; set;}

		[Ordinal(0)] [RED("delayBetweenUses")] 		public CFloat DelayBetweenUses { get; set;}

		[Ordinal(0)] [RED("checkDistance")] 		public CFloat CheckDistance { get; set;}

		[Ordinal(0)] [RED("minDistanceToSelf")] 		public CFloat MinDistanceToSelf { get; set;}

		[Ordinal(0)] [RED("targetType")] 		public CEnum<EChosenTarget> TargetType { get; set;}

		[Ordinal(0)] [RED("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(0)] [RED("betweenTargetAndSelf")] 		public CBool BetweenTargetAndSelf { get; set;}

		[Ordinal(0)] [RED("chosenEntities", 2,0)] 		public CArray<CHandle<W3UsableEntity>> ChosenEntities { get; set;}

		[Ordinal(0)] [RED("interactiveNodes", 2,0)] 		public CArray<CHandle<CNode>> InteractiveNodes { get; set;}

		[Ordinal(0)] [RED("lastUsedTime")] 		public EngineTime LastUsedTime { get; set;}

		[Ordinal(0)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskUseInteractiveEntitiesInRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUseInteractiveEntitiesInRange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}