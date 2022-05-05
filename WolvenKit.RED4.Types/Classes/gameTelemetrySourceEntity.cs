using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetrySourceEntity : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("className")] 
		public CString ClassName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("sourceEntityRecord")] 
		public TweakDBID SourceEntityRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameTelemetrySourceEntity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
