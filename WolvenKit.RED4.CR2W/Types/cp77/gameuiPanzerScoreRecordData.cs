using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecordData : CVariable
	{
		private CString _name;
		private CUInt32 _score;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
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
		[RED("score")] 
		public CUInt32 Score
		{
			get
			{
				if (_score == null)
				{
					_score = (CUInt32) CR2WTypeManager.Create("Uint32", "score", cr2w, this);
				}
				return _score;
			}
			set
			{
				if (_score == value)
				{
					return;
				}
				_score = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerScoreRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
