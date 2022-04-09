using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animActionAnimDatabase_DatabaseRow : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("animationData")] 
		public animActionAnimDatabase_AnimationData AnimationData
		{
			get => GetPropertyValue<animActionAnimDatabase_AnimationData>();
			set => SetPropertyValue<animActionAnimDatabase_AnimationData>(value);
		}

		public animActionAnimDatabase_DatabaseRow()
		{
			AnimationData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
