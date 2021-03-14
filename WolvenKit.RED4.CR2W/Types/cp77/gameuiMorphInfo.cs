using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMorphInfo : gameuiCharacterCustomizationInfo
	{
		private CArray<gameuiIndexedMorphName> _morphNames;

		[Ordinal(12)] 
		[RED("morphNames")] 
		public CArray<gameuiIndexedMorphName> MorphNames
		{
			get
			{
				if (_morphNames == null)
				{
					_morphNames = (CArray<gameuiIndexedMorphName>) CR2WTypeManager.Create("array:gameuiIndexedMorphName", "morphNames", cr2w, this);
				}
				return _morphNames;
			}
			set
			{
				if (_morphNames == value)
				{
					return;
				}
				_morphNames = value;
				PropertySet(this);
			}
		}

		public gameuiMorphInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
