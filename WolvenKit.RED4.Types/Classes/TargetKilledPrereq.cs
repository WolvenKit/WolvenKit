
namespace WolvenKit.RED4.Types
{
	public partial class TargetKilledPrereq : GenericHitPrereq
	{
		public TargetKilledPrereq()
		{
			PipelineStage = Enums.gameDamagePipelineStage.PostProcess;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
