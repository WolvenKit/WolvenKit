using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class oauthAuthenticationToken : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("token")] 
		public CString Token
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("secret")] 
		public CString Secret
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("sessionHandle")] 
		public CString SessionHandle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("tokenExpiresIn")] 
		public CUInt64 TokenExpiresIn
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("authorizationExpiresIn")] 
		public CUInt64 AuthorizationExpiresIn
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public oauthAuthenticationToken()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
