using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDoorType : redEvent
	{
		private CEnum<EDoorType> _doorTypeSideOne;
		private CEnum<EDoorType> _doorTypeSideTwo;

		[Ordinal(0)] 
		[RED("doorTypeSideOne")] 
		public CEnum<EDoorType> DoorTypeSideOne
		{
			get => GetProperty(ref _doorTypeSideOne);
			set => SetProperty(ref _doorTypeSideOne, value);
		}

		[Ordinal(1)] 
		[RED("doorTypeSideTwo")] 
		public CEnum<EDoorType> DoorTypeSideTwo
		{
			get => GetProperty(ref _doorTypeSideTwo);
			set => SetProperty(ref _doorTypeSideTwo, value);
		}

		public SetDoorType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
