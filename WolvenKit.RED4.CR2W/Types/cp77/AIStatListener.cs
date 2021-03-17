using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStatListener : gameScriptStatsListener
	{
		private wCHandle<ScriptedPuppet> _owner;
		private CName _behaviorCallbackName;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<ScriptedPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackName")] 
		public CName BehaviorCallbackName
		{
			get => GetProperty(ref _behaviorCallbackName);
			set => SetProperty(ref _behaviorCallbackName, value);
		}

		public AIStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
