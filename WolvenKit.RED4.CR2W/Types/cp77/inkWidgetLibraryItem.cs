using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItem : CVariable
	{
		private CName _name;
		private SharedDataBuffer _package;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("package")] 
		public SharedDataBuffer Package
		{
			get
			{
				if (_package == null)
				{
					_package = (SharedDataBuffer) CR2WTypeManager.Create("SharedDataBuffer", "package", cr2w, this);
				}
				return _package;
			}
			set
			{
				if (_package == value)
				{
					return;
				}
				_package = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
