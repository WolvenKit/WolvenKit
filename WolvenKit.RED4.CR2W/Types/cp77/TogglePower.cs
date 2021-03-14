using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TogglePower : ActionBool
	{
		private CString _trueRecordName;
		private CString _falseRecordName;

		[Ordinal(25)] 
		[RED("TrueRecordName")] 
		public CString TrueRecordName
		{
			get
			{
				if (_trueRecordName == null)
				{
					_trueRecordName = (CString) CR2WTypeManager.Create("String", "TrueRecordName", cr2w, this);
				}
				return _trueRecordName;
			}
			set
			{
				if (_trueRecordName == value)
				{
					return;
				}
				_trueRecordName = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("FalseRecordName")] 
		public CString FalseRecordName
		{
			get
			{
				if (_falseRecordName == null)
				{
					_falseRecordName = (CString) CR2WTypeManager.Create("String", "FalseRecordName", cr2w, this);
				}
				return _falseRecordName;
			}
			set
			{
				if (_falseRecordName == value)
				{
					return;
				}
				_falseRecordName = value;
				PropertySet(this);
			}
		}

		public TogglePower(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
