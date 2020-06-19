using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayLODConfig : CVariable
	{
		[RED("actorLODs", 2,0)] 		public CArray<SActorLODConfig> ActorLODs { get; set;}

		[RED("actorInvisibilityTimeThreshold")] 		public CFloat ActorInvisibilityTimeThreshold { get; set;}

		[RED("maxBudgetedComponentsTickTime")] 		public CFloat MaxBudgetedComponentsTickTime { get; set;}

		[RED("minBudgetedComponentsTickPercentage")] 		public CUInt32 MinBudgetedComponentsTickPercentage { get; set;}

		[RED("componentsTickLODUpdateTime")] 		public CFloat ComponentsTickLODUpdateTime { get; set;}

		[RED("componentsBudgetableTickDistance")] 		public CFloat ComponentsBudgetableTickDistance { get; set;}

		[RED("componentsDisableTickDistance")] 		public CFloat ComponentsDisableTickDistance { get; set;}

		[RED("entitiesBudgetableTickDistance")] 		public CFloat EntitiesBudgetableTickDistance { get; set;}

		[RED("entitiesDisableTickDistance")] 		public CFloat EntitiesDisableTickDistance { get; set;}

		[RED("entitiesTickTime")] 		public CFloat EntitiesTickTime { get; set;}

		[RED("effectsBudgetableTickDistance")] 		public CFloat EffectsBudgetableTickDistance { get; set;}

		[RED("effectsTickLODUpdateTime")] 		public CFloat EffectsTickLODUpdateTime { get; set;}

		[RED("effectsTickTime")] 		public CFloat EffectsTickTime { get; set;}

		public SGameplayLODConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayLODConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}