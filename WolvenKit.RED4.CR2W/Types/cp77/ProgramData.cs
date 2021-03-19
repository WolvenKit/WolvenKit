using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramData : CVariable
	{
		private CString _id;
		private CArray<CArray<ElementData>> _commandLists;
		private CArray<CEnum<ProgramEffect>> _effects;
		private CEnum<ProgramType> _type;
		private CString _localizationKey;
		private CBool _startAsUnknown;
		private CBool _wasCompleted;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("commandLists")] 
		public CArray<CArray<ElementData>> CommandLists
		{
			get => GetProperty(ref _commandLists);
			set => SetProperty(ref _commandLists, value);
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<CEnum<ProgramEffect>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<ProgramType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("localizationKey")] 
		public CString LocalizationKey
		{
			get => GetProperty(ref _localizationKey);
			set => SetProperty(ref _localizationKey, value);
		}

		[Ordinal(5)] 
		[RED("startAsUnknown")] 
		public CBool StartAsUnknown
		{
			get => GetProperty(ref _startAsUnknown);
			set => SetProperty(ref _startAsUnknown, value);
		}

		[Ordinal(6)] 
		[RED("wasCompleted")] 
		public CBool WasCompleted
		{
			get => GetProperty(ref _wasCompleted);
			set => SetProperty(ref _wasCompleted, value);
		}

		public ProgramData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
