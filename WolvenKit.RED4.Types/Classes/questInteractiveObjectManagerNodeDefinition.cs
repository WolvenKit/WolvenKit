using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInteractiveObjectManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIInteractiveObjectManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIInteractiveObjectManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
