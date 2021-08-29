using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasNewMountRequest : AIVehicleConditionAbstract
	{
		private CHandle<AIArgumentMapping> _mountRequest;
		private CBool _checkOnlyInstant;

		[Ordinal(0)] 
		[RED("mountRequest")] 
		public CHandle<AIArgumentMapping> MountRequest
		{
			get => GetProperty(ref _mountRequest);
			set => SetProperty(ref _mountRequest, value);
		}

		[Ordinal(1)] 
		[RED("checkOnlyInstant")] 
		public CBool CheckOnlyInstant
		{
			get => GetProperty(ref _checkOnlyInstant);
			set => SetProperty(ref _checkOnlyInstant, value);
		}
	}
}
