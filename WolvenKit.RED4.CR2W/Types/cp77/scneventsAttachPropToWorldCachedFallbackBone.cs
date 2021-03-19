using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToWorldCachedFallbackBone : CVariable
	{
		private CName _boneName;
		private Transform _modelSpaceTransform;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(1)] 
		[RED("modelSpaceTransform")] 
		public Transform ModelSpaceTransform
		{
			get => GetProperty(ref _modelSpaceTransform);
			set => SetProperty(ref _modelSpaceTransform, value);
		}

		public scneventsAttachPropToWorldCachedFallbackBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
