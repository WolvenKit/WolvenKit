using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectPropertyDictionary : ISerializable
	{
		private CArray<gameSmartObjectPropertyDictionaryPropertyEntry> _properties;

		[Ordinal(0)] 
		[RED("properties")] 
		public CArray<gameSmartObjectPropertyDictionaryPropertyEntry> Properties
		{
			get
			{
				if (_properties == null)
				{
					_properties = (CArray<gameSmartObjectPropertyDictionaryPropertyEntry>) CR2WTypeManager.Create("array:gameSmartObjectPropertyDictionaryPropertyEntry", "properties", cr2w, this);
				}
				return _properties;
			}
			set
			{
				if (_properties == value)
				{
					return;
				}
				_properties = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectPropertyDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
