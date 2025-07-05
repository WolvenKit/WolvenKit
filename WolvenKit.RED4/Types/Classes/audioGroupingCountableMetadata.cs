using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGroupingCountableMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioGroupingCountableMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
