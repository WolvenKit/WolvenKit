using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeBase : gameIHitShape
	{
		private Vector3 _translation;
		private Quaternion _rotation;
		private CMatrix _localTransform;

		[Ordinal(0)] 
		[RED("translation")] 
		public Vector3 Translation
		{
			get => GetProperty(ref _translation);
			set => SetProperty(ref _translation, value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(2)] 
		[RED("localTransform")] 
		public CMatrix LocalTransform
		{
			get => GetProperty(ref _localTransform);
			set => SetProperty(ref _localTransform, value);
		}

		public gameHitShapeBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
