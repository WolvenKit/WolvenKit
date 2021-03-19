using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerRegistrationRequest : HUDManagerRequest
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

		public HUDManagerRegistrationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
