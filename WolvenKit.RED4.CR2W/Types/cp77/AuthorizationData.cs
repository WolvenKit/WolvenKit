using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AuthorizationData : CVariable
	{
		private CBool _isAuthorizationModuleOn;
		private CBool _alwaysExposeActions;
		private SecurityAccessLevelEntryClient _authorizationDataEntry;

		[Ordinal(0)] 
		[RED("isAuthorizationModuleOn")] 
		public CBool IsAuthorizationModuleOn
		{
			get
			{
				if (_isAuthorizationModuleOn == null)
				{
					_isAuthorizationModuleOn = (CBool) CR2WTypeManager.Create("Bool", "isAuthorizationModuleOn", cr2w, this);
				}
				return _isAuthorizationModuleOn;
			}
			set
			{
				if (_isAuthorizationModuleOn == value)
				{
					return;
				}
				_isAuthorizationModuleOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("alwaysExposeActions")] 
		public CBool AlwaysExposeActions
		{
			get
			{
				if (_alwaysExposeActions == null)
				{
					_alwaysExposeActions = (CBool) CR2WTypeManager.Create("Bool", "alwaysExposeActions", cr2w, this);
				}
				return _alwaysExposeActions;
			}
			set
			{
				if (_alwaysExposeActions == value)
				{
					return;
				}
				_alwaysExposeActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("authorizationDataEntry")] 
		public SecurityAccessLevelEntryClient AuthorizationDataEntry
		{
			get
			{
				if (_authorizationDataEntry == null)
				{
					_authorizationDataEntry = (SecurityAccessLevelEntryClient) CR2WTypeManager.Create("SecurityAccessLevelEntryClient", "authorizationDataEntry", cr2w, this);
				}
				return _authorizationDataEntry;
			}
			set
			{
				if (_authorizationDataEntry == value)
				{
					return;
				}
				_authorizationDataEntry = value;
				PropertySet(this);
			}
		}

		public AuthorizationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
