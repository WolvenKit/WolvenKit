using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetTime_NodeType : questITimeManagerNodeType
	{
		[Ordinal(0)] 
		[RED("hours")] 
		public CInt32 Hours
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("minutes")] 
		public CInt32 Minutes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("seconds")] 
		public CInt32 Seconds
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetTime_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
