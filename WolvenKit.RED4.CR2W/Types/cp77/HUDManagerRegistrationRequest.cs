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
			get
			{
				if (_isRegistering == null)
				{
					_isRegistering = (CBool) CR2WTypeManager.Create("Bool", "isRegistering", cr2w, this);
				}
				return _isRegistering;
			}
			set
			{
				if (_isRegistering == value)
				{
					return;
				}
				_isRegistering = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<HUDActorType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<HUDActorType>) CR2WTypeManager.Create("HUDActorType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public HUDManagerRegistrationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
