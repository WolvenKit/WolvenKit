using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemUnpackedView : ISerializable
	{
		private CName _name;
		private CHandle<inkWidgetLibraryItemInstance> _instance;

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
		[RED("instance")] 
		public CHandle<inkWidgetLibraryItemInstance> Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = (CHandle<inkWidgetLibraryItemInstance>) CR2WTypeManager.Create("handle:inkWidgetLibraryItemInstance", "instance", cr2w, this);
				}
				return _instance;
			}
			set
			{
				if (_instance == value)
				{
					return;
				}
				_instance = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryItemUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
