using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestPrefabEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}
	}
}
