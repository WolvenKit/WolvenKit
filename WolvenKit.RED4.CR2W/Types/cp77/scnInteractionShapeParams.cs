using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInteractionShapeParams : ISerializable
	{
		private CEnum<scnChoiceNodeNsSizePreset> _preset;
		private Vector3 _offset;
		private Quaternion _rotation;
		private CFloat _customIndicationRange;
		private CFloat _customActivationRange;
		private CFloat _activationYawLimit;
		private CFloat _activationBaseLength;
		private CFloat _activationHeight;

		[Ordinal(0)] 
		[RED("preset")] 
		public CEnum<scnChoiceNodeNsSizePreset> Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(2)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(3)] 
		[RED("customIndicationRange")] 
		public CFloat CustomIndicationRange
		{
			get => GetProperty(ref _customIndicationRange);
			set => SetProperty(ref _customIndicationRange, value);
		}

		[Ordinal(4)] 
		[RED("customActivationRange")] 
		public CFloat CustomActivationRange
		{
			get => GetProperty(ref _customActivationRange);
			set => SetProperty(ref _customActivationRange, value);
		}

		[Ordinal(5)] 
		[RED("activationYawLimit")] 
		public CFloat ActivationYawLimit
		{
			get => GetProperty(ref _activationYawLimit);
			set => SetProperty(ref _activationYawLimit, value);
		}

		[Ordinal(6)] 
		[RED("activationBaseLength")] 
		public CFloat ActivationBaseLength
		{
			get => GetProperty(ref _activationBaseLength);
			set => SetProperty(ref _activationBaseLength, value);
		}

		[Ordinal(7)] 
		[RED("activationHeight")] 
		public CFloat ActivationHeight
		{
			get => GetProperty(ref _activationHeight);
			set => SetProperty(ref _activationHeight, value);
		}

		public scnInteractionShapeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
