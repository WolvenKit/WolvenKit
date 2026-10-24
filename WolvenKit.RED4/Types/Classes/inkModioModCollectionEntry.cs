using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModioModCollectionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modID")] 
		public CInt64 ModID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(1)] 
		[RED("modState")] 
		public CEnum<inkModioModState> ModState
		{
			get => GetPropertyValue<CEnum<inkModioModState>>();
			set => SetPropertyValue<CEnum<inkModioModState>>(value);
		}

		[Ordinal(2)] 
		[RED("modInfo")] 
		public inkModioModInfos ModInfo
		{
			get => GetPropertyValue<inkModioModInfos>();
			set => SetPropertyValue<inkModioModInfos>(value);
		}

		[Ordinal(3)] 
		[RED("pathOnDisk")] 
		public CString PathOnDisk
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("sizeOnDisk")] 
		public CUInt64 SizeOnDisk
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public inkModioModCollectionEntry()
		{
			ModID = -1;
			ModState = Enums.inkModioModState.MAX;
			ModInfo = new inkModioModInfos();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
