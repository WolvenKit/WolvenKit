using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimsetOverrideData : CVariable
	{
		private CUInt64 _animsetHash;
		private CArray<CName> _variables;

		[Ordinal(0)] 
		[RED("animsetHash")] 
		public CUInt64 AnimsetHash
		{
			get
			{
				if (_animsetHash == null)
				{
					_animsetHash = (CUInt64) CR2WTypeManager.Create("Uint64", "animsetHash", cr2w, this);
				}
				return _animsetHash;
			}
			set
			{
				if (_animsetHash == value)
				{
					return;
				}
				_animsetHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get
			{
				if (_variables == null)
				{
					_variables = (CArray<CName>) CR2WTypeManager.Create("array:CName", "variables", cr2w, this);
				}
				return _variables;
			}
			set
			{
				if (_variables == value)
				{
					return;
				}
				_variables = value;
				PropertySet(this);
			}
		}

		public gameAnimsetOverrideData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
