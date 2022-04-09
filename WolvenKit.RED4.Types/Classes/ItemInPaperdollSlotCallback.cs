using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemInPaperdollSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("paperdollPuppet")] 
		public CWeakHandle<gamePuppet> PaperdollPuppet
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		public ItemInPaperdollSlotCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
