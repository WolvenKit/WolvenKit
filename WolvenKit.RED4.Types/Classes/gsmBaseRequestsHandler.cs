using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		private gsmSavingRequesResult _savingComplete;

		[Ordinal(6)] 
		[RED("SavingComplete")] 
		public gsmSavingRequesResult SavingComplete
		{
			get => GetProperty(ref _savingComplete);
			set => SetProperty(ref _savingComplete, value);
		}
	}
}
