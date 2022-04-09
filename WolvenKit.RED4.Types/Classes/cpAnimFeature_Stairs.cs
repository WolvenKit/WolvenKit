using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpAnimFeature_Stairs : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("onOff")] 
		public CBool OnOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public cpAnimFeature_Stairs()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
