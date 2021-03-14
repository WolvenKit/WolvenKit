using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfileData_RootItem : ISerializable
	{
		private CFloat _timeMS;
		private CArray<CHandle<animAnimProfilerData_TreeItem>> _children;

		[Ordinal(0)] 
		[RED("timeMS")] 
		public CFloat TimeMS
		{
			get
			{
				if (_timeMS == null)
				{
					_timeMS = (CFloat) CR2WTypeManager.Create("Float", "timeMS", cr2w, this);
				}
				return _timeMS;
			}
			set
			{
				if (_timeMS == value)
				{
					return;
				}
				_timeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("children")] 
		public CArray<CHandle<animAnimProfilerData_TreeItem>> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CArray<CHandle<animAnimProfilerData_TreeItem>>) CR2WTypeManager.Create("array:handle:animAnimProfilerData_TreeItem", "children", cr2w, this);
				}
				return _children;
			}
			set
			{
				if (_children == value)
				{
					return;
				}
				_children = value;
				PropertySet(this);
			}
		}

		public animAnimProfileData_RootItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
