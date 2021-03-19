using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBody : physicsISystemObject
	{
		private physicsSystemBodyParams _params;
		private Transform _localToModel;
		private CArray<CHandle<physicsICollider>> _collisionShapes;
		private CName _mappedBoneName;
		private Transform _mappedBoneToBody;
		private CBool _isQueryBodyOnly;

		[Ordinal(1)] 
		[RED("params")] 
		public physicsSystemBodyParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(2)] 
		[RED("localToModel")] 
		public Transform LocalToModel
		{
			get => GetProperty(ref _localToModel);
			set => SetProperty(ref _localToModel, value);
		}

		[Ordinal(3)] 
		[RED("collisionShapes")] 
		public CArray<CHandle<physicsICollider>> CollisionShapes
		{
			get => GetProperty(ref _collisionShapes);
			set => SetProperty(ref _collisionShapes, value);
		}

		[Ordinal(4)] 
		[RED("mappedBoneName")] 
		public CName MappedBoneName
		{
			get => GetProperty(ref _mappedBoneName);
			set => SetProperty(ref _mappedBoneName, value);
		}

		[Ordinal(5)] 
		[RED("mappedBoneToBody")] 
		public Transform MappedBoneToBody
		{
			get => GetProperty(ref _mappedBoneToBody);
			set => SetProperty(ref _mappedBoneToBody, value);
		}

		[Ordinal(6)] 
		[RED("isQueryBodyOnly")] 
		public CBool IsQueryBodyOnly
		{
			get => GetProperty(ref _isQueryBodyOnly);
			set => SetProperty(ref _isQueryBodyOnly, value);
		}

		public physicsSystemBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
