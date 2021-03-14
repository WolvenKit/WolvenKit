using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLocalizationStringComponent : entIComponent
	{
		private CArray<entLocalizationStringMapEntry> _strings;

		[Ordinal(3)] 
		[RED("Strings")] 
		public CArray<entLocalizationStringMapEntry> Strings
		{
			get
			{
				if (_strings == null)
				{
					_strings = (CArray<entLocalizationStringMapEntry>) CR2WTypeManager.Create("array:entLocalizationStringMapEntry", "Strings", cr2w, this);
				}
				return _strings;
			}
			set
			{
				if (_strings == value)
				{
					return;
				}
				_strings = value;
				PropertySet(this);
			}
		}

		public entLocalizationStringComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
