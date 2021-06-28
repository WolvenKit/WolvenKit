using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerUnauthorized : ActionBool
	{
		private CBool _isLiftDoor;

		[Ordinal(25)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetProperty(ref _isLiftDoor);
			set => SetProperty(ref _isLiftDoor, value);
		}

		public PlayerUnauthorized(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
