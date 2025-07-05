using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionStateType : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioLocomotionStateType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
