using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCutControlNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _permanent;

		[Ordinal(2)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetProperty(ref _permanent);
			set => SetProperty(ref _permanent, value);
		}
	}
}
