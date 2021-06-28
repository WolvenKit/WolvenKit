using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrappleStandEvents : LocomotionTakedownEvents
	{
		private CBool _isWalking;

		[Ordinal(1)] 
		[RED("isWalking")] 
		public CBool IsWalking
		{
			get => GetProperty(ref _isWalking);
			set => SetProperty(ref _isWalking, value);
		}

		public GrappleStandEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
