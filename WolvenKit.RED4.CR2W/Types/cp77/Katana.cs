using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Katana : gameweaponObject
	{
		private CName _bentBulletTemplateName;
		private CName _bulletBendingReferenceSlotName;
		private CHandle<entIComponent> _colliderComponent;
		private CHandle<entSlotComponent> _slotComponent;

		[Ordinal(57)] 
		[RED("bentBulletTemplateName")] 
		public CName BentBulletTemplateName
		{
			get => GetProperty(ref _bentBulletTemplateName);
			set => SetProperty(ref _bentBulletTemplateName, value);
		}

		[Ordinal(58)] 
		[RED("bulletBendingReferenceSlotName")] 
		public CName BulletBendingReferenceSlotName
		{
			get => GetProperty(ref _bulletBendingReferenceSlotName);
			set => SetProperty(ref _bulletBendingReferenceSlotName, value);
		}

		[Ordinal(59)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get => GetProperty(ref _colliderComponent);
			set => SetProperty(ref _colliderComponent, value);
		}

		[Ordinal(60)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		public Katana(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
