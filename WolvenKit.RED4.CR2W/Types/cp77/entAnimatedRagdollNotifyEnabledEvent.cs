using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimatedRagdollNotifyEnabledEvent : redEvent
	{
		private entEntityID _instigator;

		[Ordinal(0)] 
		[RED("instigator")] 
		public entEntityID Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		public entAnimatedRagdollNotifyEnabledEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
