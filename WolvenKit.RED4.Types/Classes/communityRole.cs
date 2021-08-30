using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityRole : ISerializable
	{
		private CName _roleName;

		[Ordinal(0)] 
		[RED("roleName")] 
		public CName RoleName
		{
			get => GetProperty(ref _roleName);
			set => SetProperty(ref _roleName, value);
		}

		public communityRole()
		{
			_roleName = "default";
		}
	}
}
