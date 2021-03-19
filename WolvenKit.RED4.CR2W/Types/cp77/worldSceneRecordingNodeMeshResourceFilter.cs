using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingNodeMeshResourceFilter : CVariable
	{
		private CArray<raRef<CMesh>> _forceFilterIgnore;
		private CArray<raRef<CMesh>> _forceFilterMatch;

		[Ordinal(0)] 
		[RED("forceFilterIgnore")] 
		public CArray<raRef<CMesh>> ForceFilterIgnore
		{
			get => GetProperty(ref _forceFilterIgnore);
			set => SetProperty(ref _forceFilterIgnore, value);
		}

		[Ordinal(1)] 
		[RED("forceFilterMatch")] 
		public CArray<raRef<CMesh>> ForceFilterMatch
		{
			get => GetProperty(ref _forceFilterMatch);
			set => SetProperty(ref _forceFilterMatch, value);
		}

		public worldSceneRecordingNodeMeshResourceFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
