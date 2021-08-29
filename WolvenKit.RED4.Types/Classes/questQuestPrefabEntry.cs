using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestPrefabEntry : RedBaseClass
	{
		private NodeRef _prefabNodeRef;

		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetProperty(ref _prefabNodeRef);
			set => SetProperty(ref _prefabNodeRef, value);
		}
	}
}
