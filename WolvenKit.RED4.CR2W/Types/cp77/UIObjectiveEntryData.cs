using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIObjectiveEntryData : CVariable
	{
		private CString _name;
		private CString _counter;
		private CEnum<UIObjectiveEntryType> _type;
		private CEnum<gameJournalEntryState> _state;
		private CBool _isTracked;
		private CBool _isOptional;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("counter")] 
		public CString Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<UIObjectiveEntryType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(4)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetProperty(ref _isTracked);
			set => SetProperty(ref _isTracked, value);
		}

		[Ordinal(5)] 
		[RED("isOptional")] 
		public CBool IsOptional
		{
			get => GetProperty(ref _isOptional);
			set => SetProperty(ref _isOptional, value);
		}

		public UIObjectiveEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
