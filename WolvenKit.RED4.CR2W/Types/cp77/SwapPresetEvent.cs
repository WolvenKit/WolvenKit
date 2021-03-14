using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwapPresetEvent : redEvent
	{
		private CString _mappingName;

		[Ordinal(0)] 
		[RED("mappingName")] 
		public CString MappingName
		{
			get
			{
				if (_mappingName == null)
				{
					_mappingName = (CString) CR2WTypeManager.Create("String", "mappingName", cr2w, this);
				}
				return _mappingName;
			}
			set
			{
				if (_mappingName == value)
				{
					return;
				}
				_mappingName = value;
				PropertySet(this);
			}
		}

		public SwapPresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
