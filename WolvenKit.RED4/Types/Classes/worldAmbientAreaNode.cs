using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAmbientAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("useCustomColor")] 
		public CBool UseCustomColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldAmbientAreaNode()
		{
			Color = new CColor { Red = 236, Green = 255, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
