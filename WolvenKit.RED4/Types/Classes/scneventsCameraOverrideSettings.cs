using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsCameraOverrideSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overrideFov")] 
		public CBool OverrideFov
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("overrideDof")] 
		public CBool OverrideDof
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("resetFov")] 
		public CBool ResetFov
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("resetDof")] 
		public CBool ResetDof
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsCameraOverrideSettings()
		{
			OverrideFov = true;
			OverrideDof = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
