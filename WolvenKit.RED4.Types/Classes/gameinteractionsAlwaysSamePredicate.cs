using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsAlwaysSamePredicate : gameinteractionsIPredicateType
	{
		private CFloat _priority;

		[Ordinal(0)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		public gameinteractionsAlwaysSamePredicate()
		{
			_priority = 1.000000F;
		}
	}
}
