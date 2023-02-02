using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInteractionShapeParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("preset")] 
		public CEnum<scnChoiceNodeNsSizePreset> Preset
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsSizePreset>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsSizePreset>>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(3)] 
		[RED("customIndicationRange")] 
		public CFloat CustomIndicationRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("customActivationRange")] 
		public CFloat CustomActivationRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("activationYawLimit")] 
		public CFloat ActivationYawLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("activationBaseLength")] 
		public CFloat ActivationBaseLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("activationHeight")] 
		public CFloat ActivationHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnInteractionShapeParams()
		{
			Preset = Enums.scnChoiceNodeNsSizePreset.normal;
			Offset = new();
			Rotation = new() { R = 1.000000F };
			ActivationBaseLength = 1.000000F;
			ActivationHeight = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
