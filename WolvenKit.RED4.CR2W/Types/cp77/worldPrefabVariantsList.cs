using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefabVariantsList : ISerializable
	{
		private CArray<CName> _activeVariants;

		[Ordinal(0)] 
		[RED("activeVariants")] 
		public CArray<CName> ActiveVariants
		{
			get
			{
				if (_activeVariants == null)
				{
					_activeVariants = (CArray<CName>) CR2WTypeManager.Create("array:CName", "activeVariants", cr2w, this);
				}
				return _activeVariants;
			}
			set
			{
				if (_activeVariants == value)
				{
					return;
				}
				_activeVariants = value;
				PropertySet(this);
			}
		}

		public worldPrefabVariantsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
