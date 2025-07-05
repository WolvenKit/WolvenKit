using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeshParam_Weakspot : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("hidden")] 
		public CInt32 Hidden
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MeshParam_Weakspot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
