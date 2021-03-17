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
			get => GetProperty(ref _activeVariants);
			set => SetProperty(ref _activeVariants, value);
		}

		public worldPrefabVariantsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
