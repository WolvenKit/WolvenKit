using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntityAttachementComponentPS : gameComponentPS
	{
		private CArray<EntityAttachementData> _pendingChildAttachements;

		[Ordinal(0)] 
		[RED("pendingChildAttachements")] 
		public CArray<EntityAttachementData> PendingChildAttachements
		{
			get => GetProperty(ref _pendingChildAttachements);
			set => SetProperty(ref _pendingChildAttachements, value);
		}
	}
}
