using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreen : LcdScreen
	{
		private CUInt32 _timeSystemCallbackID;

		[Ordinal(95)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get
			{
				if (_timeSystemCallbackID == null)
				{
					_timeSystemCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "timeSystemCallbackID", cr2w, this);
				}
				return _timeSystemCallbackID;
			}
			set
			{
				if (_timeSystemCallbackID == value)
				{
					return;
				}
				_timeSystemCallbackID = value;
				PropertySet(this);
			}
		}

		public ApartmentScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
