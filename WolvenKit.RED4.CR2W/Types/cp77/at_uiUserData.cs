using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class at_uiUserData : inkUserData
	{
		private CString _atid;

		[Ordinal(0)] 
		[RED("atid")] 
		public CString Atid
		{
			get => GetProperty(ref _atid);
			set => SetProperty(ref _atid, value);
		}

		public at_uiUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
