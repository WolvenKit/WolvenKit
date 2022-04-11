using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRigRetarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sourceRig")] 
		public CResourceReference<animRig> SourceRig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}
	}
}
