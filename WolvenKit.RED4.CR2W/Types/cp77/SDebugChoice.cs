using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDebugChoice : CVariable
	{
		private CName _choiceName;
		private CInt32 _factValue;
		private CEnum<EVarDBMode> _factmode;

		[Ordinal(0)] 
		[RED("choiceName")] 
		public CName ChoiceName
		{
			get
			{
				if (_choiceName == null)
				{
					_choiceName = (CName) CR2WTypeManager.Create("CName", "choiceName", cr2w, this);
				}
				return _choiceName;
			}
			set
			{
				if (_choiceName == value)
				{
					return;
				}
				_choiceName = value;
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

		[Ordinal(2)] 
		[RED("factmode")] 
		public CEnum<EVarDBMode> Factmode
		{
			get
			{
				if (_factmode == null)
				{
					_factmode = (CEnum<EVarDBMode>) CR2WTypeManager.Create("EVarDBMode", "factmode", cr2w, this);
				}
				return _factmode;
			}
			set
			{
				if (_factmode == value)
				{
					return;
				}
				_factmode = value;
				PropertySet(this);
			}
		}

		public SDebugChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
