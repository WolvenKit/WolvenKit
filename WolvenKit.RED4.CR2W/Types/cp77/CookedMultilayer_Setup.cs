using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CookedMultilayer_Setup : CResource
	{
		private CArray<rRef<Multilayer_Setup>> _dependencies;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<rRef<Multilayer_Setup>> Dependencies
		{
			get
			{
				if (_dependencies == null)
				{
					_dependencies = (CArray<rRef<Multilayer_Setup>>) CR2WTypeManager.Create("array:rRef:Multilayer_Setup", "dependencies", cr2w, this);
				}
				return _dependencies;
			}
			set
			{
				if (_dependencies == value)
				{
					return;
				}
				_dependencies = value;
				PropertySet(this);
			}
		}

		public CookedMultilayer_Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
