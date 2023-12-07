using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PocketRadioQuestContentLockListener : questScriptQuestContentLockListener
	{
		[Ordinal(0)] 
		[RED("pocketRadio")] 
		public CHandle<PocketRadio> PocketRadio
		{
			get => GetPropertyValue<CHandle<PocketRadio>>();
			set => SetPropertyValue<CHandle<PocketRadio>>(value);
		}

		public PocketRadioQuestContentLockListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
