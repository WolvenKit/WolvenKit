using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetupResource : CResource
	{
		private CArray<rRef<animAnimSet>> _dependencies;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<rRef<animAnimSet>> Dependencies
		{
			get
			{
				if (_dependencies == null)
				{
					_dependencies = (CArray<rRef<animAnimSet>>) CR2WTypeManager.Create("array:rRef:animAnimSet", "dependencies", cr2w, this);
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

		public animAnimSetupResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
