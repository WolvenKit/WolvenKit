using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitIsHumanPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HitIsHumanPrereq()
		{
			IsSync = true;
			PipelineStage = Enums.gameDamagePipelineStage.Process;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
