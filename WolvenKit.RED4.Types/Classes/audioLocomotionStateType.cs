using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLocomotionStateType : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
