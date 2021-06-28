using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingInfo : CVariable
	{
		private entEntityID _childId;
		private entEntityID _parentId;
		private gamemountingMountingSlotId _slotId;

		[Ordinal(0)] 
		[RED("childId")] 
		public entEntityID ChildId
		{
			get => GetProperty(ref _childId);
			set => SetProperty(ref _childId, value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get => GetProperty(ref _parentId);
			set => SetProperty(ref _parentId, value);
		}

		[Ordinal(2)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		public gamemountingMountingInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
