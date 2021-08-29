using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questWorldDataManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questIWorldDataManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIWorldDataManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
