using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectMoverStatus : redEvent
	{
		private CName _ownerName;
		private CEnum<EMovementDirection> _direction;

		[Ordinal(0)] 
		[RED("ownerName")] 
		public CName OwnerName
		{
			get => GetProperty(ref _ownerName);
			set => SetProperty(ref _ownerName, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<EMovementDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public ObjectMoverStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
