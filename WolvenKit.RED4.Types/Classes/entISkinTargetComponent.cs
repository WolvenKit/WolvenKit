using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entISkinTargetComponent : entIVisualComponent
	{
		private CHandle<entSkinningBinding> _skinning;
		private CBool _useSkinningLOD;

		[Ordinal(8)] 
		[RED("skinning")] 
		public CHandle<entSkinningBinding> Skinning
		{
			get => GetProperty(ref _skinning);
			set => SetProperty(ref _skinning, value);
		}

		[Ordinal(9)] 
		[RED("useSkinningLOD")] 
		public CBool UseSkinningLOD
		{
			get => GetProperty(ref _useSkinningLOD);
			set => SetProperty(ref _useSkinningLOD, value);
		}
	}
}
