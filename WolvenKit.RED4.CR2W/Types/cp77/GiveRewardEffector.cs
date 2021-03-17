using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GiveRewardEffector : gameEffector
	{
		private TweakDBID _reward;
		private entEntityID _target;

		[Ordinal(0)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetProperty(ref _reward);
			set => SetProperty(ref _reward, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public GiveRewardEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
