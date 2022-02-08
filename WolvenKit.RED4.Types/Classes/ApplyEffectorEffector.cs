using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyEffectorEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("effectorToApply")] 
		public TweakDBID EffectorToApply
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ApplyEffectorEffector()
		{
			Target = new();
		}
	}
}
