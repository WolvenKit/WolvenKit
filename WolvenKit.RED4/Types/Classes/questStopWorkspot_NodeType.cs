using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStopWorkspot_NodeType : questIBehaviourManager_NodeType
	{
		[Ordinal(1)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("exitAnim")] 
		public CName ExitAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questStopWorkspot_NodeType()
		{
			PuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
