using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetPoliceSearchArea : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("SearchAreaRadius")] 
		public CFloat SearchAreaRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("ChaseDistance")] 
		public CFloat ChaseDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetPoliceSearchArea()
		{
			SearchAreaRadius = -1.000000F;
			ChaseDistance = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
