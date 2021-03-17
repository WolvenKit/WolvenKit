using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TankTurretComponent : gameScriptableComponent
	{
		private TweakDBID _attackRecord;
		private CName _slotComponentName1;
		private CName _slotName1;
		private CName _slotComponentName2;
		private CName _slotName2;
		private CHandle<entSlotComponent> _slotComponent1;
		private CHandle<entSlotComponent> _slotComponent2;

		[Ordinal(5)] 
		[RED("attackRecord")] 
		public TweakDBID AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(6)] 
		[RED("slotComponentName1")] 
		public CName SlotComponentName1
		{
			get => GetProperty(ref _slotComponentName1);
			set => SetProperty(ref _slotComponentName1, value);
		}

		[Ordinal(7)] 
		[RED("slotName1")] 
		public CName SlotName1
		{
			get => GetProperty(ref _slotName1);
			set => SetProperty(ref _slotName1, value);
		}

		[Ordinal(8)] 
		[RED("slotComponentName2")] 
		public CName SlotComponentName2
		{
			get => GetProperty(ref _slotComponentName2);
			set => SetProperty(ref _slotComponentName2, value);
		}

		[Ordinal(9)] 
		[RED("slotName2")] 
		public CName SlotName2
		{
			get => GetProperty(ref _slotName2);
			set => SetProperty(ref _slotName2, value);
		}

		[Ordinal(10)] 
		[RED("slotComponent1")] 
		public CHandle<entSlotComponent> SlotComponent1
		{
			get => GetProperty(ref _slotComponent1);
			set => SetProperty(ref _slotComponent1, value);
		}

		[Ordinal(11)] 
		[RED("slotComponent2")] 
		public CHandle<entSlotComponent> SlotComponent2
		{
			get => GetProperty(ref _slotComponent2);
			set => SetProperty(ref _slotComponent2, value);
		}

		public TankTurretComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
