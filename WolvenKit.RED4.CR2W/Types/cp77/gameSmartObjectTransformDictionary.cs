using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformDictionary : ISerializable
	{
		private CArray<gameSmartObjectTransformDictionaryTransformEntry> _transforms;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<gameSmartObjectTransformDictionaryTransformEntry> Transforms
		{
			get
			{
				if (_transforms == null)
				{
					_transforms = (CArray<gameSmartObjectTransformDictionaryTransformEntry>) CR2WTypeManager.Create("array:gameSmartObjectTransformDictionaryTransformEntry", "transforms", cr2w, this);
				}
				return _transforms;
			}
			set
			{
				if (_transforms == value)
				{
					return;
				}
				_transforms = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectTransformDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
