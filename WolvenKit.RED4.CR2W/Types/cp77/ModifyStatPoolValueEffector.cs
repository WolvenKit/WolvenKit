using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolValueEffector : gameEffector
	{
		private CArray<wCHandle<gamedataStatPoolUpdate_Record>> _statPoolUpdates;
		private CBool _usePercent;
		private CString _applicationTarget;
		private CBool _setValue;

		[Ordinal(0)] 
		[RED("statPoolUpdates")] 
		public CArray<wCHandle<gamedataStatPoolUpdate_Record>> StatPoolUpdates
		{
			get => GetProperty(ref _statPoolUpdates);
			set => SetProperty(ref _statPoolUpdates, value);
		}

		[Ordinal(1)] 
		[RED("usePercent")] 
		public CBool UsePercent
		{
			get => GetProperty(ref _usePercent);
			set => SetProperty(ref _usePercent, value);
		}

		[Ordinal(2)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(3)] 
		[RED("setValue")] 
		public CBool SetValue_
		{
			get => GetProperty(ref _setValue);
			set => SetProperty(ref _setValue, value);
		}

		public ModifyStatPoolValueEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
