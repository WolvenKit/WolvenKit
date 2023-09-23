using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Reprimand : MorphData
	{
		[Ordinal(1)] 
		[RED("reprimandData")] 
		public ReprimandData ReprimandData
		{
			get => GetPropertyValue<ReprimandData>();
			set => SetPropertyValue<ReprimandData>(value);
		}

		public Reprimand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
