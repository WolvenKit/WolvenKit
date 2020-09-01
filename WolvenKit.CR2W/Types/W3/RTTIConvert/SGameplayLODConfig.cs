using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayLODConfig : CVariable
	{
		[Ordinal(1)] [RED("actorLODs", 2,0)] 		public CArray<SActorLODConfig> ActorLODs { get; set;}

		[Ordinal(2)] [RED("actorInvisibilityTimeThreshold")] 		public CFloat ActorInvisibilityTimeThreshold { get; set;}

		[Ordinal(3)] [RED("maxBudgetedComponentsTickTime")] 		public CFloat MaxBudgetedComponentsTickTime { get; set;}

		[Ordinal(4)] [RED("minBudgetedComponentsTickPercentage")] 		public CUInt32 MinBudgetedComponentsTickPercentage { get; set;}

		[Ordinal(5)] [RED("componentsTickLODUpdateTime")] 		public CFloat ComponentsTickLODUpdateTime { get; set;}

		[Ordinal(6)] [RED("componentsBudgetableTickDistance")] 		public CFloat ComponentsBudgetableTickDistance { get; set;}

		[Ordinal(7)] [RED("componentsDisableTickDistance")] 		public CFloat ComponentsDisableTickDistance { get; set;}

		[Ordinal(8)] [RED("entitiesBudgetableTickDistance")] 		public CFloat EntitiesBudgetableTickDistance { get; set;}

		[Ordinal(9)] [RED("entitiesDisableTickDistance")] 		public CFloat EntitiesDisableTickDistance { get; set;}

		[Ordinal(10)] [RED("entitiesTickTime")] 		public CFloat EntitiesTickTime { get; set;}

		[Ordinal(11)] [RED("effectsBudgetableTickDistance")] 		public CFloat EffectsBudgetableTickDistance { get; set;}

		[Ordinal(12)] [RED("effectsTickLODUpdateTime")] 		public CFloat EffectsTickLODUpdateTime { get; set;}

		[Ordinal(13)] [RED("effectsTickTime")] 		public CFloat EffectsTickTime { get; set;}

		public SGameplayLODConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayLODConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}