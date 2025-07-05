using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TogglePreventionSystem : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TogglePreventionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
