using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPatrolParams : questAICommandParams
	{
		private CHandle<AIPatrolPathParameters> _pathParams;
		private CBool _repeatCommandOnInterrupt;

		[Ordinal(0)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get => GetProperty(ref _pathParams);
			set => SetProperty(ref _pathParams, value);
		}

		[Ordinal(1)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetProperty(ref _repeatCommandOnInterrupt);
			set => SetProperty(ref _repeatCommandOnInterrupt, value);
		}

		public questPatrolParams()
		{
			_repeatCommandOnInterrupt = true;
		}
	}
}
