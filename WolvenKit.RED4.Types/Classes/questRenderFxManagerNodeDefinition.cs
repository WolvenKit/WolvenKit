using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRenderFxManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIRenderFxManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRenderFxManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
