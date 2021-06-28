using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SplinePoint : CVariable
	{
		private Vector3 _position;
		private Quaternion _rotation;
		private CArrayFixedSize<Vector3> _tangents;
		private CBool _continuousTangents;
		private CBool _automaticTangents;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(2)] 
		[RED("tangents", 2)] 
		public CArrayFixedSize<Vector3> Tangents
		{
			get => GetProperty(ref _tangents);
			set => SetProperty(ref _tangents, value);
		}

		[Ordinal(3)] 
		[RED("continuousTangents")] 
		public CBool ContinuousTangents
		{
			get => GetProperty(ref _continuousTangents);
			set => SetProperty(ref _continuousTangents, value);
		}

		[Ordinal(4)] 
		[RED("automaticTangents")] 
		public CBool AutomaticTangents
		{
			get => GetProperty(ref _automaticTangents);
			set => SetProperty(ref _automaticTangents, value);
		}

		[Ordinal(5)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public SplinePoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
