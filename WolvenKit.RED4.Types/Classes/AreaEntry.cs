using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaEntry : RedBaseClass
	{
		private entEntityID _user;

		[Ordinal(0)] 
		[RED("user")] 
		public entEntityID User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}
	}
}
