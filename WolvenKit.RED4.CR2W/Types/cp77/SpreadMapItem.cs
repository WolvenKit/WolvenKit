using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadMapItem : CVariable
	{
		private wCHandle<gamedataInteractionBase_Record> _key;
		private CInt32 _count;
		private CFloat _range;

		[Ordinal(0)] 
		[RED("key")] 
		public wCHandle<gamedataInteractionBase_Record> Key
		{
			get
			{
				if (_key == null)
				{
					_key = (wCHandle<gamedataInteractionBase_Record>) CR2WTypeManager.Create("whandle:gamedataInteractionBase_Record", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CInt32) CR2WTypeManager.Create("Int32", "count", cr2w, this);
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
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		public SpreadMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
