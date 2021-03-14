using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSetTextEvent : inkanimEvent
	{
		private CString _localizationString;

		[Ordinal(1)] 
		[RED("localizationString")] 
		public CString LocalizationString
		{
			get
			{
				if (_localizationString == null)
				{
					_localizationString = (CString) CR2WTypeManager.Create("String", "localizationString", cr2w, this);
				}
				return _localizationString;
			}
			set
			{
				if (_localizationString == value)
				{
					return;
				}
				_localizationString = value;
				PropertySet(this);
			}
		}

		public inkanimSetTextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
