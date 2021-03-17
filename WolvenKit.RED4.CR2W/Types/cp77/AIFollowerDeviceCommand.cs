using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerDeviceCommand : AIFollowerCommand
	{
		private wCHandle<gameObject> _target;
		private wCHandle<gameObject> _overrideMovementTarget;

		[Ordinal(5)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(6)] 
		[RED("overrideMovementTarget")] 
		public wCHandle<gameObject> OverrideMovementTarget
		{
			get => GetProperty(ref _overrideMovementTarget);
			set => SetProperty(ref _overrideMovementTarget, value);
		}

		public AIFollowerDeviceCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
