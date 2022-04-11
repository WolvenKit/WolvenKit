using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MarkBackdoorAsRevealedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("device")] 
		public CHandle<SharedGameplayPS> Device
		{
			get => GetPropertyValue<CHandle<SharedGameplayPS>>();
			set => SetPropertyValue<CHandle<SharedGameplayPS>>(value);
		}
	}
}
