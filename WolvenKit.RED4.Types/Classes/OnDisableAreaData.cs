using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnDisableAreaData : RedBaseClass
	{
		private gamePersistentID _agent;
		private CArray<CHandle<SecurityAreaControllerPS>> _remainingAreas;

		[Ordinal(0)] 
		[RED("agent")] 
		public gamePersistentID Agent
		{
			get => GetProperty(ref _agent);
			set => SetProperty(ref _agent, value);
		}

		[Ordinal(1)] 
		[RED("remainingAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> RemainingAreas
		{
			get => GetProperty(ref _remainingAreas);
			set => SetProperty(ref _remainingAreas, value);
		}
	}
}
