using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPresetTimetableEntry : CVariable
	{
		private SSimpleGameTime _time;
		private CBool _useTime;
		private CInt32 _arrayPosition;
		private CUInt32 _entryID;

		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (SSimpleGameTime) CR2WTypeManager.Create("SSimpleGameTime", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useTime")] 
		public CBool UseTime
		{
			get
			{
				if (_useTime == null)
				{
					_useTime = (CBool) CR2WTypeManager.Create("Bool", "useTime", cr2w, this);
				}
				return _useTime;
			}
			set
			{
				if (_useTime == value)
				{
					return;
				}
				_useTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get
			{
				if (_arrayPosition == null)
				{
					_arrayPosition = (CInt32) CR2WTypeManager.Create("Int32", "arrayPosition", cr2w, this);
				}
				return _arrayPosition;
			}
			set
			{
				if (_arrayPosition == value)
				{
					return;
				}
				_arrayPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entryID")] 
		public CUInt32 EntryID
		{
			get
			{
				if (_entryID == null)
				{
					_entryID = (CUInt32) CR2WTypeManager.Create("Uint32", "entryID", cr2w, this);
				}
				return _entryID;
			}
			set
			{
				if (_entryID == value)
				{
					return;
				}
				_entryID = value;
				PropertySet(this);
			}
		}

		public SPresetTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
