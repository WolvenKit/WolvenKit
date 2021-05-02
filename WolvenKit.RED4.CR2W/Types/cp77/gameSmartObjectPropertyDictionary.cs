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
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}

		public gameSmartObjectPropertyDictionary(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
