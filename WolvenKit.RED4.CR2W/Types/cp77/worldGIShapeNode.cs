using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldGIShapeNode : worldGeometryShapeNode
	{
		private CUInt32 _priority;
		private CEnum<rendGIGroup> _group;
		private CBool _interior;
		private CBool _runtime;
		private CBool _updated;

		[Ordinal(6)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt32) CR2WTypeManager.Create("Uint32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("group")] 
		public CEnum<rendGIGroup> Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CEnum<rendGIGroup>) CR2WTypeManager.Create("rendGIGroup", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("interior")] 
		public CBool Interior
		{
			get
			{
				if (_interior == null)
				{
					_interior = (CBool) CR2WTypeManager.Create("Bool", "interior", cr2w, this);
				}
				return _interior;
			}
			set
			{
				if (_interior == value)
				{
					return;
				}
				_interior = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("runtime")] 
		public CBool Runtime
		{
			get
			{
				if (_runtime == null)
				{
					_runtime = (CBool) CR2WTypeManager.Create("Bool", "runtime", cr2w, this);
				}
				return _runtime;
			}
			set
			{
				if (_runtime == value)
				{
					return;
				}
				_runtime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("updated")] 
		public CBool Updated
		{
			get
			{
				if (_updated == null)
				{
					_updated = (CBool) CR2WTypeManager.Create("Bool", "updated", cr2w, this);
				}
				return _updated;
			}
			set
			{
				if (_updated == value)
				{
					return;
				}
				_updated = value;
				PropertySet(this);
			}
		}

		public worldGIShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
