
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetKilledPrereq : GenericHitPrereq
	{

		public TargetKilledPrereq()
		{
			PipelineStage = Enums.gameDamagePipelineStage.PostProcess;
		}
	}
}
