using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CompanionHealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<CompanionHealthBarGameController> Healthbar
		{
			get => GetPropertyValue<CWeakHandle<CompanionHealthBarGameController>>();
			set => SetPropertyValue<CWeakHandle<CompanionHealthBarGameController>>(value);
		}
	}
}
