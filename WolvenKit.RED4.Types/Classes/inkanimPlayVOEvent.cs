using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimPlayVOEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("VOLine")] 
		public CString VOLine
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkanimPlayVOEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
