using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redStageMessage : CVariable
	{
		private CUInt32 _parent;
		private CBool _reset;
		private CArray<CString> _names;
		private CArray<CUInt32> _ids;

		[Ordinal(0)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get
			{
				if (_parent == null)
				{
					_parent = (CUInt32) CR2WTypeManager.Create("Uint32", "parent", cr2w, this);
				}
				return _parent;
			}
			set
			{
				if (_parent == value)
				{
					return;
				}
				_parent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get
			{
				if (_reset == null)
				{
					_reset = (CBool) CR2WTypeManager.Create("Bool", "reset", cr2w, this);
				}
				return _reset;
			}
			set
			{
				if (_reset == value)
				{
					return;
				}
				_reset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get
			{
				if (_names == null)
				{
					_names = (CArray<CString>) CR2WTypeManager.Create("array:String", "names", cr2w, this);
				}
				return _names;
			}
			set
			{
				if (_names == value)
				{
					return;
				}
				_names = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ids")] 
		public CArray<CUInt32> Ids
		{
			get
			{
				if (_ids == null)
				{
					_ids = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "ids", cr2w, this);
				}
				return _ids;
			}
			set
			{
				if (_ids == value)
				{
					return;
				}
				_ids = value;
				PropertySet(this);
			}
		}

		public redStageMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
