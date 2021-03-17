using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotRecordData : CVariable
	{
		private CBool _isInvulnerable;
		private TweakDBID _slotID;
		private CBool _reducedMeleeDamage;

		[Ordinal(0)] 
		[RED("isInvulnerable")] 
		public CBool IsInvulnerable
		{
			get => GetProperty(ref _isInvulnerable);
			set => SetProperty(ref _isInvulnerable, value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(2)] 
		[RED("reducedMeleeDamage")] 
		public CBool ReducedMeleeDamage
		{
			get => GetProperty(ref _reducedMeleeDamage);
			set => SetProperty(ref _reducedMeleeDamage, value);
		}

		public WeakspotRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
