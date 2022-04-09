using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisplayGlassControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isTinted")] 
		public CBool IsTinted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("useAppearances")] 
		public CBool UseAppearances
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("clearAppearance")] 
		public CName ClearAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(107)] 
		[RED("tintedAppearance")] 
		public CName TintedAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DisplayGlassControllerPS()
		{
			DeviceName = "LocKey#2069";
			TweakDBRecord = 86545678090;
			TweakDBDescriptionRecord = 137703617399;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
