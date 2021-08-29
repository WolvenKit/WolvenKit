using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDManagerRegistrationRequest : HUDManagerRequest
	{
		private CBool _isRegistering;
		private CEnum<HUDActorType> _type;

		[Ordinal(1)] 
		[RED("isRegistering")] 
		public CBool IsRegistering
		{
			get => GetProperty(ref _isRegistering);
			set => SetProperty(ref _isRegistering, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<HUDActorType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
