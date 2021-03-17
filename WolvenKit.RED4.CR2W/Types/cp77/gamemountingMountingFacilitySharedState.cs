using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingFacilitySharedState : ISerializable
	{
		private CArray<wCHandle<entEntity>> _children;
		private CArray<wCHandle<entEntity>> _parents;
		private CArray<gamemountingMountingSlotId> _slotIds;
		private CArray<CEnum<gameMountingObjectType>> _parentTypes;
		private CArray<CEnum<gameMountingObjectType>> _childTypes;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<wCHandle<entEntity>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		[Ordinal(1)] 
		[RED("parents")] 
		public CArray<wCHandle<entEntity>> Parents
		{
			get => GetProperty(ref _parents);
			set => SetProperty(ref _parents, value);
		}

		[Ordinal(2)] 
		[RED("slotIds")] 
		public CArray<gamemountingMountingSlotId> SlotIds
		{
			get => GetProperty(ref _slotIds);
			set => SetProperty(ref _slotIds, value);
		}

		[Ordinal(3)] 
		[RED("parentTypes")] 
		public CArray<CEnum<gameMountingObjectType>> ParentTypes
		{
			get => GetProperty(ref _parentTypes);
			set => SetProperty(ref _parentTypes, value);
		}

		[Ordinal(4)] 
		[RED("childTypes")] 
		public CArray<CEnum<gameMountingObjectType>> ChildTypes
		{
			get => GetProperty(ref _childTypes);
			set => SetProperty(ref _childTypes, value);
		}

		public gamemountingMountingFacilitySharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
