using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionTransition : DefaultTransition
	{
		private TweakDBID _ownerRecordId;
		private CUInt64 _statModifierGroupId;
		private CString _statModifierTDBNameDefault;

		[Ordinal(0)] 
		[RED("ownerRecordId")] 
		public TweakDBID OwnerRecordId
		{
			get => GetProperty(ref _ownerRecordId);
			set => SetProperty(ref _ownerRecordId, value);
		}

		[Ordinal(1)] 
		[RED("statModifierGroupId")] 
		public CUInt64 StatModifierGroupId
		{
			get => GetProperty(ref _statModifierGroupId);
			set => SetProperty(ref _statModifierGroupId, value);
		}

		[Ordinal(2)] 
		[RED("statModifierTDBNameDefault")] 
		public CString StatModifierTDBNameDefault
		{
			get => GetProperty(ref _statModifierTDBNameDefault);
			set => SetProperty(ref _statModifierTDBNameDefault, value);
		}

		public LocomotionTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
