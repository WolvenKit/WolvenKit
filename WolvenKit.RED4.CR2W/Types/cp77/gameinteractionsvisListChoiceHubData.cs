using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceHubData : CVariable
	{
		private CInt32 _id;
		private CEnum<gameinteractionsvisEVisualizerActivityState> _activityState;
		private CEnum<gameinteractionsvisEVisualizerDefinitionFlags> _flags;
		private CBool _isPhoneLockActive;
		private CString _title;
		private CArray<gameinteractionsvisListChoiceData> _choices;
		private wCHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;
		private CUInt8 _hubPriority;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activityState")] 
		public CEnum<gameinteractionsvisEVisualizerActivityState> ActivityState
		{
			get
			{
				if (_activityState == null)
				{
					_activityState = (CEnum<gameinteractionsvisEVisualizerActivityState>) CR2WTypeManager.Create("gameinteractionsvisEVisualizerActivityState", "activityState", cr2w, this);
				}
				return _activityState;
			}
			set
			{
				if (_activityState == value)
				{
					return;
				}
				_activityState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CEnum<gameinteractionsvisEVisualizerDefinitionFlags>) CR2WTypeManager.Create("gameinteractionsvisEVisualizerDefinitionFlags", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPhoneLockActive")] 
		public CBool IsPhoneLockActive
		{
			get
			{
				if (_isPhoneLockActive == null)
				{
					_isPhoneLockActive = (CBool) CR2WTypeManager.Create("Bool", "isPhoneLockActive", cr2w, this);
				}
				return _isPhoneLockActive;
			}
			set
			{
				if (_isPhoneLockActive == value)
				{
					return;
				}
				_isPhoneLockActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisListChoiceData> Choices
		{
			get
			{
				if (_choices == null)
				{
					_choices = (CArray<gameinteractionsvisListChoiceData>) CR2WTypeManager.Create("array:gameinteractionsvisListChoiceData", "choices", cr2w, this);
				}
				return _choices;
			}
			set
			{
				if (_choices == value)
				{
					return;
				}
				_choices = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeProvider")] 
		public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get
			{
				if (_timeProvider == null)
				{
					_timeProvider = (wCHandle<gameinteractionsvisIVisualizerTimeProvider>) CR2WTypeManager.Create("whandle:gameinteractionsvisIVisualizerTimeProvider", "timeProvider", cr2w, this);
				}
				return _timeProvider;
			}
			set
			{
				if (_timeProvider == value)
				{
					return;
				}
				_timeProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get
			{
				if (_hubPriority == null)
				{
					_hubPriority = (CUInt8) CR2WTypeManager.Create("Uint8", "hubPriority", cr2w, this);
				}
				return _hubPriority;
			}
			set
			{
				if (_hubPriority == value)
				{
					return;
				}
				_hubPriority = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisListChoiceHubData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
