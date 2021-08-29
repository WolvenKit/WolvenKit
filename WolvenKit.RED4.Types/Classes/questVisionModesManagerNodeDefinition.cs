using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVisionModesManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIVisionModeNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIVisionModeNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
