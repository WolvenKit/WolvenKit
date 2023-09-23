using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnlockAnimData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("levelFrom")] 
		public CInt32 LevelFrom
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("levelTo")] 
		public CInt32 LevelTo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public UnlockAnimData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
