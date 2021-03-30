using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CombatGadget : animAnimFeature
	{
		private CBool _isQuickthrow;
		private CBool _isChargedThrow;
		private CBool _isDetonated;

		[Ordinal(0)] 
		[RED("isQuickthrow")] 
		public CBool IsQuickthrow
		{
			get => GetProperty(ref _isQuickthrow);
			set => SetProperty(ref _isQuickthrow, value);
		}

		[Ordinal(1)] 
		[RED("isChargedThrow")] 
		public CBool IsChargedThrow
		{
			get => GetProperty(ref _isChargedThrow);
			set => SetProperty(ref _isChargedThrow, value);
		}

		[Ordinal(2)] 
		[RED("isDetonated")] 
		public CBool IsDetonated
		{
			get => GetProperty(ref _isDetonated);
			set => SetProperty(ref _isDetonated, value);
		}

		public AnimFeature_CombatGadget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
