using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShiftTime_NodeType : questITimeManagerNodeType
	{
		[Ordinal(0)] 
		[RED("timeShiftType")] 
		public CEnum<questETimeShiftType> TimeShiftType
		{
			get => GetPropertyValue<CEnum<questETimeShiftType>>();
			set => SetPropertyValue<CEnum<questETimeShiftType>>(value);
		}

		[Ordinal(1)] 
		[RED("preventVisualGlitch")] 
		public CBool PreventVisualGlitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questShiftTime_NodeType()
		{
			PreventVisualGlitch = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
