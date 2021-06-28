using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QsTransform : CVariable
	{
		private Vector4 _translation;
		private Quaternion _rotation;
		private Vector4 _scale;

		[Ordinal(0)] 
		[RED("Translation")] 
		public Vector4 Translation
		{
			get => GetProperty(ref _translation);
			set => SetProperty(ref _translation, value);
		}

		[Ordinal(1)] 
		[RED("Rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(2)] 
		[RED("Scale")] 
		public Vector4 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		public QsTransform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
