using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPreset : ISerializable
	{
		private CName _name;
		private CBool _forceEnableCollisionCallbacks;
		private CArray<CName> _collisionType;
		private CArray<CName> _collisionMask;
		private CArray<CName> _queryDetect;

		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("ForceEnableCollisionCallbacks")] 
		public CBool ForceEnableCollisionCallbacks
		{
			get => GetProperty(ref _forceEnableCollisionCallbacks);
			set => SetProperty(ref _forceEnableCollisionCallbacks, value);
		}

		[Ordinal(2)] 
		[RED("CollisionType")] 
		public CArray<CName> CollisionType
		{
			get => GetProperty(ref _collisionType);
			set => SetProperty(ref _collisionType, value);
		}

		[Ordinal(3)] 
		[RED("CollisionMask")] 
		public CArray<CName> CollisionMask
		{
			get => GetProperty(ref _collisionMask);
			set => SetProperty(ref _collisionMask, value);
		}

		[Ordinal(4)] 
		[RED("QueryDetect")] 
		public CArray<CName> QueryDetect
		{
			get => GetProperty(ref _queryDetect);
			set => SetProperty(ref _queryDetect, value);
		}

		public physicsCollisionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
