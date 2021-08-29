using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMultiPrereq : gameIPrereq
	{
		private CEnum<gameAggregationType> _aggregationType;
		private CArray<CHandle<gameIPrereq>> _nestedPrereqs;

		[Ordinal(0)] 
		[RED("aggregationType")] 
		public CEnum<gameAggregationType> AggregationType
		{
			get => GetProperty(ref _aggregationType);
			set => SetProperty(ref _aggregationType, value);
		}

		[Ordinal(1)] 
		[RED("nestedPrereqs")] 
		public CArray<CHandle<gameIPrereq>> NestedPrereqs
		{
			get => GetProperty(ref _nestedPrereqs);
			set => SetProperty(ref _nestedPrereqs, value);
		}
	}
}
