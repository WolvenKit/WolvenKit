using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetLootInteractionAccess_NodeType : questIItemManagerNodeType
	{
		private gameEntityReference _objectRef;
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetProperty(ref _accessible);
			set => SetProperty(ref _accessible, value);
		}
	}
}
