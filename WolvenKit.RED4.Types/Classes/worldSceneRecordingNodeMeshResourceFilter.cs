using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSceneRecordingNodeMeshResourceFilter : RedBaseClass
	{
		private CArray<CResourceAsyncReference<CMesh>> _forceFilterIgnore;
		private CArray<CResourceAsyncReference<CMesh>> _forceFilterMatch;

		[Ordinal(0)] 
		[RED("forceFilterIgnore")] 
		public CArray<CResourceAsyncReference<CMesh>> ForceFilterIgnore
		{
			get => GetProperty(ref _forceFilterIgnore);
			set => SetProperty(ref _forceFilterIgnore, value);
		}

		[Ordinal(1)] 
		[RED("forceFilterMatch")] 
		public CArray<CResourceAsyncReference<CMesh>> ForceFilterMatch
		{
			get => GetProperty(ref _forceFilterMatch);
			set => SetProperty(ref _forceFilterMatch, value);
		}
	}
}
