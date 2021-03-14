using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionChoiceHubData : CVariable
	{
		private CInt32 _id;
		private CEnum<gameinteractionsvisEVisualizerDefinitionFlags> _flags;
		private CBool _active;
		private CString _title;
		private CArray<gameinteractionsvisInteractionChoiceData> _choices;
		private wCHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;

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

		[Ordinal(2)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisInteractionChoiceData> Choices
		{
			get
			{
				if (_choices == null)
				{
					_choices = (CArray<gameinteractionsvisInteractionChoiceData>) CR2WTypeManager.Create("array:gameinteractionsvisInteractionChoiceData", "choices", cr2w, this);
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

		[Ordinal(5)] 
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

		public gameinteractionsvisInteractionChoiceHubData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
