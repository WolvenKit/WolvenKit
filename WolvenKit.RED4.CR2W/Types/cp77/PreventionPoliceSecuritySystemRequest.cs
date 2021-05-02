using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionPoliceSecuritySystemRequest : gameScriptableSystemRequest
	{
		private gamePersistentID _securitySystemID;

		[Ordinal(0)] 
		[RED("securitySystemID")] 
		public gamePersistentID SecuritySystemID
		{
			get => GetProperty(ref _securitySystemID);
			set => SetProperty(ref _securitySystemID, value);
		}

		public PreventionPoliceSecuritySystemRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
