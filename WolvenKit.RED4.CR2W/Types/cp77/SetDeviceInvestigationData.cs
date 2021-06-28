using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDeviceInvestigationData : AIbehaviortaskScript
	{
		private wCHandle<ScriptedPuppet> _ownerPuppet;
		private wCHandle<gameObject> _listener;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public wCHandle<gameObject> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		public SetDeviceInvestigationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
