using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_RejectOnPrereq : gameEffectObjectSingleFilter
	{
		private CHandle<gameIPrereq> _prereq;

		[Ordinal(0)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetProperty(ref _prereq);
			set => SetProperty(ref _prereq, value);
		}
	}
}
