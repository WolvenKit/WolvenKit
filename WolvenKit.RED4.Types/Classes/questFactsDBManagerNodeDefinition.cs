using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFactsDBManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIFactsDBManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIFactsDBManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
