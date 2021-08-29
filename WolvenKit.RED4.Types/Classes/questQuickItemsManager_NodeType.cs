using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuickItemsManager_NodeType : questIUIManagerNodeType
	{
		private CEnum<questQuickItemsSet> _set;

		[Ordinal(0)] 
		[RED("set")] 
		public CEnum<questQuickItemsSet> Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}
	}
}
