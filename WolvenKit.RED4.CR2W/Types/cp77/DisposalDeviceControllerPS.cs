using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private DisposalDeviceSetup _disposalDeviceSetup;
		private DistractionSetup _distractionSetup;
		private DistractionSetup _explosionSetup;
		private CBool _isDistractionDisabled;
		private CBool _wasActivated;
		private CBool _wasLethalTakedownPerformed;
		private CBool _isPlayerCurrentlyPerformingDisposal;

		[Ordinal(104)] 
		[RED("DisposalDeviceSetup")] 
		public DisposalDeviceSetup DisposalDeviceSetup
		{
			get => GetProperty(ref _disposalDeviceSetup);
			set => SetProperty(ref _disposalDeviceSetup, value);
		}

		[Ordinal(105)] 
		[RED("distractionSetup")] 
		public DistractionSetup DistractionSetup
		{
			get => GetProperty(ref _distractionSetup);
			set => SetProperty(ref _distractionSetup, value);
		}

		[Ordinal(106)] 
		[RED("explosionSetup")] 
		public DistractionSetup ExplosionSetup
		{
			get => GetProperty(ref _explosionSetup);
			set => SetProperty(ref _explosionSetup, value);
		}

		[Ordinal(107)] 
		[RED("isDistractionDisabled")] 
		public CBool IsDistractionDisabled
		{
			get => GetProperty(ref _isDistractionDisabled);
			set => SetProperty(ref _isDistractionDisabled, value);
		}

		[Ordinal(108)] 
		[RED("wasActivated")] 
		public CBool WasActivated
		{
			get => GetProperty(ref _wasActivated);
			set => SetProperty(ref _wasActivated, value);
		}

		[Ordinal(109)] 
		[RED("wasLethalTakedownPerformed")] 
		public CBool WasLethalTakedownPerformed
		{
			get => GetProperty(ref _wasLethalTakedownPerformed);
			set => SetProperty(ref _wasLethalTakedownPerformed, value);
		}

		[Ordinal(110)] 
		[RED("isPlayerCurrentlyPerformingDisposal")] 
		public CBool IsPlayerCurrentlyPerformingDisposal
		{
			get => GetProperty(ref _isPlayerCurrentlyPerformingDisposal);
			set => SetProperty(ref _isPlayerCurrentlyPerformingDisposal, value);
		}

		public DisposalDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
