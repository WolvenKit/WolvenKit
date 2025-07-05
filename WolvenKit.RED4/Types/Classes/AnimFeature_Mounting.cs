using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Mounting : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("mountingState")] 
		public CInt32 MountingState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("parentSpeed")] 
		public CFloat ParentSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("parentHorizontalSpeed")] 
		public CFloat ParentHorizontalSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_Mounting()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
