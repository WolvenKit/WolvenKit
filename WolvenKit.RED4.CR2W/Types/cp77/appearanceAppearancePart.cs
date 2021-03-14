using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearancePart : CVariable
	{
		private raRef<entEntityTemplate> _resource;

		[Ordinal(0)] 
		[RED("resource")] 
		public raRef<entEntityTemplate> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		public appearanceAppearancePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
