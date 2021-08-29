using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsInteractionDescriptorResource : CResource
	{
		private gameinteractionsCHotSpotDefinition _definition;

		[Ordinal(1)] 
		[RED("definition")] 
		public gameinteractionsCHotSpotDefinition Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}
	}
}
