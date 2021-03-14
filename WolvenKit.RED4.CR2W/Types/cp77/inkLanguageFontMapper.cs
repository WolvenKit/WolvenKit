using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFontMapper : ISerializable
	{
		private CArray<inkLanguageFontMapping> _mappings;

		[Ordinal(0)] 
		[RED("mappings")] 
		public CArray<inkLanguageFontMapping> Mappings
		{
			get
			{
				if (_mappings == null)
				{
					_mappings = (CArray<inkLanguageFontMapping>) CR2WTypeManager.Create("array:inkLanguageFontMapping", "mappings", cr2w, this);
				}
				return _mappings;
			}
			set
			{
				if (_mappings == value)
				{
					return;
				}
				_mappings = value;
				PropertySet(this);
			}
		}

		public inkLanguageFontMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
