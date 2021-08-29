using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimSoundEvent : entSoundEvent
	{
		private CName _metadataContext;

		[Ordinal(4)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get => GetProperty(ref _metadataContext);
			set => SetProperty(ref _metadataContext, value);
		}
	}
}
