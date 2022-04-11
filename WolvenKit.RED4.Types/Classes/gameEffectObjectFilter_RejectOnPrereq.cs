using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_RejectOnPrereq : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}
	}
}
