using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPauseTime_NodeType : questITimeManagerNodeType
	{
		[Ordinal(0)] 
		[RED("pause")] 
		public CBool Pause
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questPauseTime_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
