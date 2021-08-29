using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGameManagerNodeDefinition : questTypedSignalStoppingNodeDefinition
	{
		private CHandle<questIGameManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIGameManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
