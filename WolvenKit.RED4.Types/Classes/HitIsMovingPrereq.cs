using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsMovingPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("object")] 
		public CString Object
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public HitIsMovingPrereq()
		{
			IsSync = true;
			PipelineStage = Enums.gameDamagePipelineStage.Process;
		}
	}
}
