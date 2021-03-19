using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workDynamicSyncBindCommandData : workIWorkspotCommandData
	{
		private entEntityID _masterID;

		[Ordinal(0)] 
		[RED("masterID")] 
		public entEntityID MasterID
		{
			get => GetProperty(ref _masterID);
			set => SetProperty(ref _masterID, value);
		}

		public workDynamicSyncBindCommandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
