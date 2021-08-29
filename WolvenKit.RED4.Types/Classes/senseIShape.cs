using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseIShape : IScriptable
	{
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
