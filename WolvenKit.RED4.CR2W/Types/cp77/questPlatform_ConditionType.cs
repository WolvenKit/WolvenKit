using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlatform_ConditionType : questISystemConditionType
	{
		private CEnum<questPlatform> _platform;

		[Ordinal(0)] 
		[RED("platform")] 
		public CEnum<questPlatform> Platform
		{
			get
			{
				if (_platform == null)
				{
					_platform = (CEnum<questPlatform>) CR2WTypeManager.Create("questPlatform", "platform", cr2w, this);
				}
				return _platform;
			}
			set
			{
				if (_platform == value)
				{
					return;
				}
				_platform = value;
				PropertySet(this);
			}
		}

		public questPlatform_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
