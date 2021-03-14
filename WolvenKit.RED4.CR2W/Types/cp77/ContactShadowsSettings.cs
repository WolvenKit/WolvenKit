using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContactShadowsSettings : IAreaSettings
	{
		private ContactShadowsConfig _contactShadows;

		[Ordinal(2)] 
		[RED("contactShadows")] 
		public ContactShadowsConfig ContactShadows
		{
			get
			{
				if (_contactShadows == null)
				{
					_contactShadows = (ContactShadowsConfig) CR2WTypeManager.Create("ContactShadowsConfig", "contactShadows", cr2w, this);
				}
				return _contactShadows;
			}
			set
			{
				if (_contactShadows == value)
				{
					return;
				}
				_contactShadows = value;
				PropertySet(this);
			}
		}

		public ContactShadowsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
