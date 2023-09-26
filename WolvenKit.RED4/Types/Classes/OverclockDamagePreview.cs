using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverclockDamagePreview : redEvent
	{
		[Ordinal(0)] 
		[RED("IsHovering")] 
		public CBool IsHovering
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("JustHacked")] 
		public CBool JustHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("MemoryCost")] 
		public CInt32 MemoryCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public OverclockDamagePreview()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
