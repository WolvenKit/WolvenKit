using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckCurrentWorkspotTag : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _tag;

		[Ordinal(0)] 
		[RED("tag")] 
		public CHandle<AIArgumentMapping> Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}
	}
}
