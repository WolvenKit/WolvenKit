using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerformedActions : CVariable
	{
		private CName _iD;
		private CArray<CEnum<EActionContext>> _actionContext;

		[Ordinal(0)] 
		[RED("ID")] 
		public CName ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(1)] 
		[RED("ActionContext")] 
		public CArray<CEnum<EActionContext>> ActionContext
		{
			get => GetProperty(ref _actionContext);
			set => SetProperty(ref _actionContext, value);
		}

		public SPerformedActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
