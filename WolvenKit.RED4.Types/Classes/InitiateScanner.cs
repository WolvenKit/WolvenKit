using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitiateScanner : redEvent
	{
		private CInt32 _trespasserEntryIndex;

		[Ordinal(0)] 
		[RED("trespasserEntryIndex")] 
		public CInt32 TrespasserEntryIndex
		{
			get => GetProperty(ref _trespasserEntryIndex);
			set => SetProperty(ref _trespasserEntryIndex, value);
		}
	}
}
