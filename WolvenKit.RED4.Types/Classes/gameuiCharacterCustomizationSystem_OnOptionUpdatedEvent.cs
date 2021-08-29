using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent : redEvent
	{
		private CWeakHandle<gameuiCharacterCustomizationOption> _option;

		[Ordinal(0)] 
		[RED("option")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> Option
		{
			get => GetProperty(ref _option);
			set => SetProperty(ref _option, value);
		}
	}
}
