using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineComponent : gamePlayerControlledComponent
	{
		private CString _packageName;

		[Ordinal(3)] 
		[RED("packageName")] 
		public CString PackageName
		{
			get
			{
				if (_packageName == null)
				{
					_packageName = (CString) CR2WTypeManager.Create("String", "packageName", cr2w, this);
				}
				return _packageName;
			}
			set
			{
				if (_packageName == value)
				{
					return;
				}
				_packageName = value;
				PropertySet(this);
			}
		}

		public gamestateMachineComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
