using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsEmerge : redEvent
	{
		[Ordinal(0)] 
		[RED("oxygen")] 
		public CFloat Oxygen
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaudioeventsEmerge()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
