using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateWhistleCustomWorldPosition : UpdateWhistlePosition
	{
		[Ordinal(0)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public UpdateWhistleCustomWorldPosition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
