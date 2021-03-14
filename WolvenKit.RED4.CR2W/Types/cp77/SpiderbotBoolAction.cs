using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpiderbotBoolAction : ActionBool
	{
		private CString _trueRecord;
		private CString _falseRecord;

		[Ordinal(25)] 
		[RED("TrueRecord")] 
		public CString TrueRecord
		{
			get
			{
				if (_trueRecord == null)
				{
					_trueRecord = (CString) CR2WTypeManager.Create("String", "TrueRecord", cr2w, this);
				}
				return _trueRecord;
			}
			set
			{
				if (_trueRecord == value)
				{
					return;
				}
				_trueRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("FalseRecord")] 
		public CString FalseRecord
		{
			get
			{
				if (_falseRecord == null)
				{
					_falseRecord = (CString) CR2WTypeManager.Create("String", "FalseRecord", cr2w, this);
				}
				return _falseRecord;
			}
			set
			{
				if (_falseRecord == value)
				{
					return;
				}
				_falseRecord = value;
				PropertySet(this);
			}
		}

		public SpiderbotBoolAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
