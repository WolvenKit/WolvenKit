using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TreeItem : ISerializable
	{
		private CName _className;
		private CFloat _exclusiveTimeMS;
		private CFloat _inclusiveTimeMS;
		private CArray<CHandle<animAnimProfilerData_TreeItem>> _children;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("exclusiveTimeMS")] 
		public CFloat ExclusiveTimeMS
		{
			get
			{
				if (_exclusiveTimeMS == null)
				{
					_exclusiveTimeMS = (CFloat) CR2WTypeManager.Create("Float", "exclusiveTimeMS", cr2w, this);
				}
				return _exclusiveTimeMS;
			}
			set
			{
				if (_exclusiveTimeMS == value)
				{
					return;
				}
				_exclusiveTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inclusiveTimeMS")] 
		public CFloat InclusiveTimeMS
		{
			get
			{
				if (_inclusiveTimeMS == null)
				{
					_inclusiveTimeMS = (CFloat) CR2WTypeManager.Create("Float", "inclusiveTimeMS", cr2w, this);
				}
				return _inclusiveTimeMS;
			}
			set
			{
				if (_inclusiveTimeMS == value)
				{
					return;
				}
				_inclusiveTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public animAnimProfilerData_TreeItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
