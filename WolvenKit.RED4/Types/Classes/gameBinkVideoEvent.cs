using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBinkVideoEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<gameBinkVideoAction> Action
		{
			get => GetPropertyValue<CEnum<gameBinkVideoAction>>();
			set => SetPropertyValue<CEnum<gameBinkVideoAction>>(value);
		}

		public gameBinkVideoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
