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
			get => GetProperty(ref _contactShadows);
			set => SetProperty(ref _contactShadows, value);
		}

		public ContactShadowsSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
