using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questParamKeepDistance : ISerializable
	{
		private CHandle<questUniversalRef> _companionTargetRef;
		private CFloat _distance;

		[Ordinal(0)] 
		[RED("companionTargetRef")] 
		public CHandle<questUniversalRef> CompanionTargetRef
		{
			get => GetProperty(ref _companionTargetRef);
			set => SetProperty(ref _companionTargetRef, value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}
	}
}
