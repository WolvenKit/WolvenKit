using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearancePartOverrides : CVariable
	{
		private raRef<entEntityTemplate> _partResource;
		private CArray<appearancePartComponentOverrides> _componentsOverrides;

		[Ordinal(0)] 
		[RED("partResource")] 
		public raRef<entEntityTemplate> PartResource
		{
			get
			{
				if (_partResource == null)
				{
					_partResource = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "partResource", cr2w, this);
				}
				return _partResource;
			}
			set
			{
				if (_partResource == value)
				{
					return;
				}
				_partResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("componentsOverrides")] 
		public CArray<appearancePartComponentOverrides> ComponentsOverrides
		{
			get
			{
				if (_componentsOverrides == null)
				{
					_componentsOverrides = (CArray<appearancePartComponentOverrides>) CR2WTypeManager.Create("array:appearancePartComponentOverrides", "componentsOverrides", cr2w, this);
				}
				return _componentsOverrides;
			}
			set
			{
				if (_componentsOverrides == value)
				{
					return;
				}
				_componentsOverrides = value;
				PropertySet(this);
			}
		}

		public appearanceAppearancePartOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
