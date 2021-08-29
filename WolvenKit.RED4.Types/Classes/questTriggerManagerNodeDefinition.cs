using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTriggerManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questITriggerManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questITriggerManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
