using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemForceAttitudeChange : ScriptableDeviceAction
	{
		private CName _newAttitude;

		[Ordinal(25)] 
		[RED("newAttitude")] 
		public CName NewAttitude
		{
			get => GetProperty(ref _newAttitude);
			set => SetProperty(ref _newAttitude, value);
		}

		public SecuritySystemForceAttitudeChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
