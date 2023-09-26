using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questProgressBar_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(3)] 
		[RED("bottomText")] 
		public LocalizationString BottomText
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetPropertyValue<CEnum<gameSimpleMessageType>>();
			set => SetPropertyValue<CEnum<gameSimpleMessageType>>(value);
		}

		public questProgressBar_NodeType()
		{
			Show = true;
			Duration = 3.000000F;
			Text = new() { Unk1 = 0, Value = "" };
			BottomText = new() { Unk1 = 0, Value = "LocKey#22165" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
