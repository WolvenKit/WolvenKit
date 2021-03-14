using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableSetup : CVariable
	{
		private CInt32 _departFrequency;
		private CInt32 _uiUpdateFrequency;

		[Ordinal(0)] 
		[RED("departFrequency")] 
		public CInt32 DepartFrequency
		{
			get
			{
				if (_departFrequency == null)
				{
					_departFrequency = (CInt32) CR2WTypeManager.Create("Int32", "departFrequency", cr2w, this);
				}
				return _departFrequency;
			}
			set
			{
				if (_departFrequency == value)
				{
					return;
				}
				_departFrequency = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("uiUpdateFrequency")] 
		public CInt32 UiUpdateFrequency
		{
			get
			{
				if (_uiUpdateFrequency == null)
				{
					_uiUpdateFrequency = (CInt32) CR2WTypeManager.Create("Int32", "uiUpdateFrequency", cr2w, this);
				}
				return _uiUpdateFrequency;
			}
			set
			{
				if (_uiUpdateFrequency == value)
				{
					return;
				}
				_uiUpdateFrequency = value;
				PropertySet(this);
			}
		}

		public NcartTimetableSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
