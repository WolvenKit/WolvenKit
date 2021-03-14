using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptPath : IScriptable
	{
		private CArray<Vector4> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CArray<Vector4> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		public worldNavigationScriptPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
