using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animIAnimNode_PostProcess : ISerializable
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animIAnimNode_PostProcess()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
