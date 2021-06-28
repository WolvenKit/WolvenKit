using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropEvents : CarriedObjectEvents
	{
		private CBool _ragdollReenabled;

		[Ordinal(9)] 
		[RED("ragdollReenabled")] 
		public CBool RagdollReenabled
		{
			get => GetProperty(ref _ragdollReenabled);
			set => SetProperty(ref _ragdollReenabled, value);
		}

		public DropEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
