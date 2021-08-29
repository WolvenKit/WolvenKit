using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NonStealthQuickHackVictimEvent : redEvent
	{
		private entEntityID _instigatorID;

		[Ordinal(0)] 
		[RED("instigatorID")] 
		public entEntityID InstigatorID
		{
			get => GetProperty(ref _instigatorID);
			set => SetProperty(ref _instigatorID, value);
		}
	}
}
