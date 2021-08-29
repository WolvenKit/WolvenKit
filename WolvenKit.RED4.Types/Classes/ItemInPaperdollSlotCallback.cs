using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInPaperdollSlotCallback : gameAttachmentSlotsScriptCallback
	{
		private CWeakHandle<gamePuppet> _paperdollPuppet;

		[Ordinal(2)] 
		[RED("paperdollPuppet")] 
		public CWeakHandle<gamePuppet> PaperdollPuppet
		{
			get => GetProperty(ref _paperdollPuppet);
			set => SetProperty(ref _paperdollPuppet, value);
		}
	}
}
