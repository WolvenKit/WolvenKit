using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRewardManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIRewardManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRewardManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
