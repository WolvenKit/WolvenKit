using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnscreenplayStandaloneComment : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetPropertyValue<scnscreenplayItemId>();
			set => SetPropertyValue<scnscreenplayItemId>(value);
		}

		[Ordinal(1)] 
		[RED("comment")] 
		public CString Comment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public scnscreenplayStandaloneComment()
		{
			ItemId = new scnscreenplayItemId { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
