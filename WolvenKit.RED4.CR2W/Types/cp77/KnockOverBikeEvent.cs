using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KnockOverBikeEvent : redEvent
	{
		private CBool _forceKnockdown;
		private CBool _applyDirectionalForce;

		[Ordinal(0)] 
		[RED("forceKnockdown")] 
		public CBool ForceKnockdown
		{
			get => GetProperty(ref _forceKnockdown);
			set => SetProperty(ref _forceKnockdown, value);
		}

		[Ordinal(1)] 
		[RED("applyDirectionalForce")] 
		public CBool ApplyDirectionalForce
		{
			get => GetProperty(ref _applyDirectionalForce);
			set => SetProperty(ref _applyDirectionalForce, value);
		}

		public KnockOverBikeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
