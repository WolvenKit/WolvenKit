using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffect : CVariable
	{
		private CArray<entEntityID> _netrunnerIDs;
		private entEntityID _targetID;
		private CArray<TweakDBID> _statusEffectList;

		[Ordinal(0)] 
		[RED("netrunnerIDs")] 
		public CArray<entEntityID> NetrunnerIDs
		{
			get => GetProperty(ref _netrunnerIDs);
			set => SetProperty(ref _netrunnerIDs, value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectList")] 
		public CArray<TweakDBID> StatusEffectList
		{
			get => GetProperty(ref _statusEffectList);
			set => SetProperty(ref _statusEffectList, value);
		}

		public LinkedStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
