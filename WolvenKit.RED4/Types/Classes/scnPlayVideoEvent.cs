using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlayVideoEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("isPhoneCall")] 
		public CBool IsPhoneCall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("forceFrameRate")] 
		public CBool ForceFrameRate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnPlayVideoEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Duration = 1000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
