using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCinematicAnimSetSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncAnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("isOverride")] 
		public CBool IsOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnCinematicAnimSetSRRef()
		{
			Priority = 128;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
