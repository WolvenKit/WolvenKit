using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRigRetarget : RedBaseClass
	{
		private CResourceReference<animRig> _sourceRig;

		[Ordinal(0)] 
		[RED("sourceRig")] 
		public CResourceReference<animRig> SourceRig
		{
			get => GetProperty(ref _sourceRig);
			set => SetProperty(ref _sourceRig, value);
		}
	}
}
