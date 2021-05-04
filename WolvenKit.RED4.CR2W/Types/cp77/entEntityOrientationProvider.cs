using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityOrientationProvider : entIOrientationProvider
	{
		private wCHandle<entSlotComponent> _slotComponent;
		private CInt32 _slotId;
		private wCHandle<entEntity> _entity;
		private Quaternion _orientationEntitySpace;

		[Ordinal(0)] 
		[RED("slotComponent")] 
		public wCHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("orientationEntitySpace")] 
		public Quaternion OrientationEntitySpace
		{
			get => GetProperty(ref _orientationEntitySpace);
			set => SetProperty(ref _orientationEntitySpace, value);
		}

		public entEntityOrientationProvider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
