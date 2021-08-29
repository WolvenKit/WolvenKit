using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAchievementManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIAchievementManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIAchievementManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
