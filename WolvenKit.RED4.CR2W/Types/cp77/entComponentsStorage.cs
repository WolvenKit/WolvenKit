using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entComponentsStorage : ISerializable
	{
		private CArray<CHandle<entIComponent>> _components;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<CHandle<entIComponent>> Components
		{
			get
			{
				if (_components == null)
				{
					_components = (CArray<CHandle<entIComponent>>) CR2WTypeManager.Create("array:handle:entIComponent", "components", cr2w, this);
				}
				return _components;
			}
			set
			{
				if (_components == value)
				{
					return;
				}
				_components = value;
				PropertySet(this);
			}
		}

		public entComponentsStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
