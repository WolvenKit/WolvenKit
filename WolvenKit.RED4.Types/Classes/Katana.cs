using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Katana : gameweaponObject
	{
		private CName _bentBulletTemplateName;
		private CName _bulletBendingReferenceSlotName;
		private CHandle<entIComponent> _colliderComponent;
		private CHandle<entSlotComponent> _slotComponent;

		[Ordinal(62)] 
		[RED("bentBulletTemplateName")] 
		public CName BentBulletTemplateName
		{
			get => GetProperty(ref _bentBulletTemplateName);
			set => SetProperty(ref _bentBulletTemplateName, value);
		}

		[Ordinal(63)] 
		[RED("bulletBendingReferenceSlotName")] 
		public CName BulletBendingReferenceSlotName
		{
			get => GetProperty(ref _bulletBendingReferenceSlotName);
			set => SetProperty(ref _bulletBendingReferenceSlotName, value);
		}

		[Ordinal(64)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get => GetProperty(ref _colliderComponent);
			set => SetProperty(ref _colliderComponent, value);
		}

		[Ordinal(65)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}
	}
}
