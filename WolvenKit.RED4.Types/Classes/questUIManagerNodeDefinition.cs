using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUIManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questIUIManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIUIManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
