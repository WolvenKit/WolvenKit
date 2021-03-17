using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLink : CVariable
	{
		private gamePersistentID _pSID;
		private CName _className;

		[Ordinal(0)] 
		[RED("PSID")] 
		public gamePersistentID PSID
		{
			get => GetProperty(ref _pSID);
			set => SetProperty(ref _pSID, value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		public DeviceLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
