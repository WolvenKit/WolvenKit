using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RecipientData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fuseID")] 
		public CInt32 FuseID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CInt32 EntryID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RecipientData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
