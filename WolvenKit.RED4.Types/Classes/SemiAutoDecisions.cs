using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SemiAutoDecisions : WeaponTransition
	{
		[Ordinal(3)] 
		[RED("callBackID")] 
		public CHandle<redCallbackObject> CallBackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}
	}
}
