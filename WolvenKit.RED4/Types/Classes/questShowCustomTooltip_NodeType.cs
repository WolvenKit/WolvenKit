using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowCustomTooltip_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("setTooltip")] 
		public CBool SetTooltip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(2)] 
		[RED("inputAction")] 
		public CString InputAction
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get => GetPropertyValue<CEnum<inkInputHintHoldIndicationType>>();
			set => SetPropertyValue<CEnum<inkInputHintHoldIndicationType>>(value);
		}

		[Ordinal(4)] 
		[RED("queuePriority")] 
		public CInt32 QueuePriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public questShowCustomTooltip_NodeType()
		{
			SetTooltip = true;
			Text = new() { Unk1 = 0, Value = "" };
			HoldIndicationType = Enums.inkInputHintHoldIndicationType.Press;
			QueuePriority = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
