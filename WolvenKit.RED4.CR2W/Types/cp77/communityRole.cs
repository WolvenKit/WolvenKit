using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityRole : ISerializable
	{
		private CName _roleName;

		[Ordinal(0)] 
		[RED("roleName")] 
		public CName RoleName
		{
			get => GetProperty(ref _roleName);
			set => SetProperty(ref _roleName, value);
		}

		public communityRole(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
