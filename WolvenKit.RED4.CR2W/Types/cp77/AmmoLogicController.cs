using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoLogicController : inkWidgetLogicController
	{
		private CUInt32 _count;
		private CUInt32 _capacity;

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CUInt32) CR2WTypeManager.Create("Uint32", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("capacity")] 
		public CUInt32 Capacity
		{
			get
			{
				if (_capacity == null)
				{
					_capacity = (CUInt32) CR2WTypeManager.Create("Uint32", "capacity", cr2w, this);
				}
				return _capacity;
			}
			set
			{
				if (_capacity == value)
				{
					return;
				}
				_capacity = value;
				PropertySet(this);
			}
		}

		public AmmoLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
