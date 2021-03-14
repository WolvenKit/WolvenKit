using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDebugLogScope : CVariable
	{
		private CUInt32 _index;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CUInt32) CR2WTypeManager.Create("Uint32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public AIDebugLogScope(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
