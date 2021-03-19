using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationComponent : entSlotComponent
	{
		private CArray<gameHitShapeContainer> _representations;
		private CName _physicsMaterial;
		private gameHitShapeBVH _bvhRoot;
		private CBool _useResourceData;
		private raRef<gameHitRepresentationResource> _resource;
		private CArray<gameHitRepresentationOverride> _appearanceOverrides;

		[Ordinal(7)] 
		[RED("representations")] 
		public CArray<gameHitShapeContainer> Representations
		{
			get => GetProperty(ref _representations);
			set => SetProperty(ref _representations, value);
		}

		[Ordinal(8)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get => GetProperty(ref _physicsMaterial);
			set => SetProperty(ref _physicsMaterial, value);
		}

		[Ordinal(9)] 
		[RED("bvhRoot")] 
		public gameHitShapeBVH BvhRoot
		{
			get => GetProperty(ref _bvhRoot);
			set => SetProperty(ref _bvhRoot, value);
		}

		[Ordinal(10)] 
		[RED("useResourceData")] 
		public CBool UseResourceData
		{
			get => GetProperty(ref _useResourceData);
			set => SetProperty(ref _useResourceData, value);
		}

		[Ordinal(11)] 
		[RED("resource")] 
		public raRef<gameHitRepresentationResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(12)] 
		[RED("appearanceOverrides")] 
		public CArray<gameHitRepresentationOverride> AppearanceOverrides
		{
			get => GetProperty(ref _appearanceOverrides);
			set => SetProperty(ref _appearanceOverrides, value);
		}

		public gameHitRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
