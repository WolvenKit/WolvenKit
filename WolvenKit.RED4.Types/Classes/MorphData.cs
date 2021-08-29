using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MorphData : IScriptable
	{
		private CBool _changed;

		[Ordinal(0)] 
		[RED("changed")] 
		public CBool Changed
		{
			get => GetProperty(ref _changed);
			set => SetProperty(ref _changed, value);
		}
	}
}
