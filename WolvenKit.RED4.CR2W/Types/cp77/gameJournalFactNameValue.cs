using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalFactNameValue : CVariable
	{
		private CName _factName;
		private CInt32 _factValue;

		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CName) CR2WTypeManager.Create("CName", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get
			{
				if (_factValue == null)
				{
					_factValue = (CInt32) CR2WTypeManager.Create("Int32", "factValue", cr2w, this);
				}
				return _factValue;
			}
			set
			{
				if (_factValue == value)
				{
					return;
				}
				_factValue = value;
				PropertySet(this);
			}
		}

		public gameJournalFactNameValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
