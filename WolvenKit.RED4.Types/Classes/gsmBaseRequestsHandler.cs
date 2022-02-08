using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		[Ordinal(6)] 
		[RED("SavingComplete")] 
		public gsmSavingRequesResult SavingComplete
		{
			get => GetPropertyValue<gsmSavingRequesResult>();
			set => SetPropertyValue<gsmSavingRequesResult>(value);
		}
	}
}
