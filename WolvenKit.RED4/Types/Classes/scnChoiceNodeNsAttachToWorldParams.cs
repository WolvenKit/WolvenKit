using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsAttachToWorldParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityPosition")] 
		public Vector3 EntityPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("entityOrientation")] 
		public Quaternion EntityOrientation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(2)] 
		[RED("customEntityRadius")] 
		public CFloat CustomEntityRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>(value);
		}

		public scnChoiceNodeNsAttachToWorldParams()
		{
			EntityPosition = new Vector3();
			EntityOrientation = new Quaternion { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
