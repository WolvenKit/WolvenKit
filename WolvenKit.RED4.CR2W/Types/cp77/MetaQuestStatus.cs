using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MetaQuestStatus : CVariable
	{
		private CBool _metaQuest1Hidden;
		private CInt32 _metaQuest1Value;
		private CString _metaQuest1Description;
		private CBool _metaQuest2Hidden;
		private CString _metaQuest2Description;
		private CInt32 _metaQuest2Value;
		private CBool _metaQuest3Hidden;
		private CString _metaQuest3Description;
		private CInt32 _metaQuest3Value;

		[Ordinal(0)] 
		[RED("MetaQuest1Hidden")] 
		public CBool MetaQuest1Hidden
		{
			get => GetProperty(ref _metaQuest1Hidden);
			set => SetProperty(ref _metaQuest1Hidden, value);
		}

		[Ordinal(1)] 
		[RED("MetaQuest1Value")] 
		public CInt32 MetaQuest1Value
		{
			get => GetProperty(ref _metaQuest1Value);
			set => SetProperty(ref _metaQuest1Value, value);
		}

		[Ordinal(2)] 
		[RED("MetaQuest1Description")] 
		public CString MetaQuest1Description
		{
			get => GetProperty(ref _metaQuest1Description);
			set => SetProperty(ref _metaQuest1Description, value);
		}

		[Ordinal(3)] 
		[RED("MetaQuest2Hidden")] 
		public CBool MetaQuest2Hidden
		{
			get => GetProperty(ref _metaQuest2Hidden);
			set => SetProperty(ref _metaQuest2Hidden, value);
		}

		[Ordinal(4)] 
		[RED("MetaQuest2Description")] 
		public CString MetaQuest2Description
		{
			get => GetProperty(ref _metaQuest2Description);
			set => SetProperty(ref _metaQuest2Description, value);
		}

		[Ordinal(5)] 
		[RED("MetaQuest2Value")] 
		public CInt32 MetaQuest2Value
		{
			get => GetProperty(ref _metaQuest2Value);
			set => SetProperty(ref _metaQuest2Value, value);
		}

		[Ordinal(6)] 
		[RED("MetaQuest3Hidden")] 
		public CBool MetaQuest3Hidden
		{
			get => GetProperty(ref _metaQuest3Hidden);
			set => SetProperty(ref _metaQuest3Hidden, value);
		}

		[Ordinal(7)] 
		[RED("MetaQuest3Description")] 
		public CString MetaQuest3Description
		{
			get => GetProperty(ref _metaQuest3Description);
			set => SetProperty(ref _metaQuest3Description, value);
		}

		[Ordinal(8)] 
		[RED("MetaQuest3Value")] 
		public CInt32 MetaQuest3Value
		{
			get => GetProperty(ref _metaQuest3Value);
			set => SetProperty(ref _metaQuest3Value, value);
		}

		public MetaQuestStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
