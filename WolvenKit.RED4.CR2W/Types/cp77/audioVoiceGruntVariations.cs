using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceGruntVariations : CVariable
	{
		private CArray<CName> _cachedVariations;

		[Ordinal(0)] 
		[RED("cachedVariations")] 
		public CArray<CName> CachedVariations
		{
			get
			{
				if (_cachedVariations == null)
				{
					_cachedVariations = (CArray<CName>) CR2WTypeManager.Create("array:CName", "cachedVariations", cr2w, this);
				}
				return _cachedVariations;
			}
			set
			{
				if (_cachedVariations == value)
				{
					return;
				}
				_cachedVariations = value;
				PropertySet(this);
			}
		}

		public audioVoiceGruntVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
