using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questItemManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIItemManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIItemManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
