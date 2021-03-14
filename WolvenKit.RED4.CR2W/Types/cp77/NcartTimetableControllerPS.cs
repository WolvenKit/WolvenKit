using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		private NcartTimetableSetup _ncartTimetableSetup;
		private CInt32 _currentTimeToDepart;

		[Ordinal(103)] 
		[RED("ncartTimetableSetup")] 
		public NcartTimetableSetup NcartTimetableSetup
		{
			get
			{
				if (_ncartTimetableSetup == null)
				{
					_ncartTimetableSetup = (NcartTimetableSetup) CR2WTypeManager.Create("NcartTimetableSetup", "ncartTimetableSetup", cr2w, this);
				}
				return _ncartTimetableSetup;
			}
			set
			{
				if (_ncartTimetableSetup == value)
				{
					return;
				}
				_ncartTimetableSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("currentTimeToDepart")] 
		public CInt32 CurrentTimeToDepart
		{
			get
			{
				if (_currentTimeToDepart == null)
				{
					_currentTimeToDepart = (CInt32) CR2WTypeManager.Create("Int32", "currentTimeToDepart", cr2w, this);
				}
				return _currentTimeToDepart;
			}
			set
			{
				if (_currentTimeToDepart == value)
				{
					return;
				}
				_currentTimeToDepart = value;
				PropertySet(this);
			}
		}

		public NcartTimetableControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
