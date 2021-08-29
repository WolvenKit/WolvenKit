using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workBodytypeCondition : workIWorkspotCondition
	{
		private CResourceAsyncReference<animRig> _rig;

		[Ordinal(2)] 
		[RED("rig")] 
		public CResourceAsyncReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}
	}
}
