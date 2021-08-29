using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePickupObject : gameObject
	{
		private CName _interactionTag;

		[Ordinal(40)] 
		[RED("interactionTag")] 
		public CName InteractionTag
		{
			get => GetProperty(ref _interactionTag);
			set => SetProperty(ref _interactionTag, value);
		}
	}
}
