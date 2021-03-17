using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCallContact_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _caller;
		private CHandle<gameJournalPath> _addressee;
		private CEnum<questPhoneCallPhase> _phase;
		private CEnum<questPhoneCallMode> _mode;
		private NodeRef _prefabNodeRef;
		private CBool _applyPhoneRestriction;

		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(2)] 
		[RED("phase")] 
		public CEnum<questPhoneCallPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<questPhoneCallMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(4)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetProperty(ref _prefabNodeRef);
			set => SetProperty(ref _prefabNodeRef, value);
		}

		[Ordinal(5)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get => GetProperty(ref _applyPhoneRestriction);
			set => SetProperty(ref _applyPhoneRestriction, value);
		}

		public questCallContact_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
