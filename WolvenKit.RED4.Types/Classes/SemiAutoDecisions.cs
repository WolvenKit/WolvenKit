using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SemiAutoDecisions : WeaponTransition
	{
		private CHandle<redCallbackObject> _callBackID;

		[Ordinal(3)] 
		[RED("callBackID")] 
		public CHandle<redCallbackObject> CallBackID
		{
			get => GetProperty(ref _callBackID);
			set => SetProperty(ref _callBackID, value);
		}
	}
}
