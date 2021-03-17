using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyNewStatusEffectEvent : redEvent
	{
		private TweakDBID _effectID;
		private TweakDBID _instigatorID;

		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get => GetProperty(ref _effectID);
			set => SetProperty(ref _effectID, value);
		}

		[Ordinal(1)] 
		[RED("instigatorID")] 
		public TweakDBID InstigatorID
		{
			get => GetProperty(ref _instigatorID);
			set => SetProperty(ref _instigatorID, value);
		}

		public ApplyNewStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
