using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputHint_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private CName _action;
		private CName _groupId;
		private CString _localizedLabel;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CName Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(2)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetProperty(ref _groupId);
			set => SetProperty(ref _groupId, value);
		}

		[Ordinal(3)] 
		[RED("localizedLabel")] 
		public CString LocalizedLabel
		{
			get => GetProperty(ref _localizedLabel);
			set => SetProperty(ref _localizedLabel, value);
		}

		public questInputHint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
