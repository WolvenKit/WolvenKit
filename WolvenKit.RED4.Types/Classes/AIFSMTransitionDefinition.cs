using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFSMTransitionDefinition : RedBaseClass
	{
		private CUInt16 _destination;
		private CUInt16 _condition;

		[Ordinal(0)] 
		[RED("destination")] 
		public CUInt16 Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CUInt16 Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}
	}
}
