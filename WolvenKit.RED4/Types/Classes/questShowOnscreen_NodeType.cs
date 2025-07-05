using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowOnscreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("localizedMessage")] 
		public LocalizationString LocalizedMessage
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questShowOnscreen_NodeType()
		{
			LocalizedMessage = new() { Unk1 = 0, Value = "" };
			Duration = 3.000000F;
			Show = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
