using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDefaultAppearancePreset_Entity : ISerializable
	{
		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CName DebugEntityPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("defaultAppearanceName")] 
		public CName DefaultAppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameDefaultAppearancePreset_Entity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
