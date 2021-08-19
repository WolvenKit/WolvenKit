using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HandleRagdollOnDeathEvent : redEvent
	{
		private CBool _handleUncontrolledMovement;

		[Ordinal(0)] 
		[RED("handleUncontrolledMovement")] 
		public CBool HandleUncontrolledMovement
		{
			get => GetProperty(ref _handleUncontrolledMovement);
			set => SetProperty(ref _handleUncontrolledMovement, value);
		}

		public HandleRagdollOnDeathEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
