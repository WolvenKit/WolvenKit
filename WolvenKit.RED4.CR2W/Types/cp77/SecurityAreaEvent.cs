using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaEvent : ActionBool
	{
		private SecurityAreaData _securityAreaData;
		private wCHandle<gameObject> _whoBreached;

		[Ordinal(25)] 
		[RED("securityAreaData")] 
		public SecurityAreaData SecurityAreaData
		{
			get => GetProperty(ref _securityAreaData);
			set => SetProperty(ref _securityAreaData, value);
		}

		[Ordinal(26)] 
		[RED("whoBreached")] 
		public wCHandle<gameObject> WhoBreached
		{
			get => GetProperty(ref _whoBreached);
			set => SetProperty(ref _whoBreached, value);
		}

		public SecurityAreaEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
