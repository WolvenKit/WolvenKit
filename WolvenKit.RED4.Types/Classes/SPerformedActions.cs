using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SPerformedActions : RedBaseClass
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
	}
}
