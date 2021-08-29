using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedLookAtRemove : entReplicatedLookAtData
	{
		private animLookAtRef _ref;
		private CFloat _hasOutTransition;
		private CFloat _outTransitionSpeed;

		[Ordinal(1)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get => GetProperty(ref _ref);
			set => SetProperty(ref _ref, value);
		}

		[Ordinal(2)] 
		[RED("hasOutTransition")] 
		public CFloat HasOutTransition
		{
			get => GetProperty(ref _hasOutTransition);
			set => SetProperty(ref _hasOutTransition, value);
		}

		[Ordinal(3)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetProperty(ref _outTransitionSpeed);
			set => SetProperty(ref _outTransitionSpeed, value);
		}
	}
}
