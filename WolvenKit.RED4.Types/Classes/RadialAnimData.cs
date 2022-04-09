using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialAnimData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hover_in")] 
		public CName Hover_in
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("hover_out")] 
		public CName Hover_out
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("cycle_in")] 
		public CName Cycle_in
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("cycle_out")] 
		public CName Cycle_out
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RadialAnimData()
		{
			Hover_in = "Anim name for hover in";
			Hover_out = "Anim name for hover out";
			Cycle_in = "Anim name for cycle in animation";
			Cycle_out = "Anim name for cycle out animation";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
