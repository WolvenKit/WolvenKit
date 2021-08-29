using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddInvestigatorEvent : redEvent
	{
		private entEntityID _investigator;

		[Ordinal(0)] 
		[RED("investigator")] 
		public entEntityID Investigator
		{
			get => GetProperty(ref _investigator);
			set => SetProperty(ref _investigator, value);
		}
	}
}
