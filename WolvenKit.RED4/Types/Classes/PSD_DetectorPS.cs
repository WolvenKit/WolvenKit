using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSD_DetectorPS : gameDeviceComponentPS
	{
		[Ordinal(13)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("lastEntityID")] 
		public entEntityID LastEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(16)] 
		[RED("lastPersistentID")] 
		public gamePersistentID LastPersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(17)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PSD_DetectorPS()
		{
			LastEntityID = new();
			LastPersistentID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
