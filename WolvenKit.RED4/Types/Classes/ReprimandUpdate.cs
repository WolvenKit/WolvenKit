using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReprimandUpdate : redEvent
	{
		[Ordinal(0)] 
		[RED("reprimandInstructions")] 
		public CEnum<EReprimandInstructions> ReprimandInstructions
		{
			get => GetPropertyValue<CEnum<EReprimandInstructions>>();
			set => SetPropertyValue<CEnum<EReprimandInstructions>>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("targetPos")] 
		public Vector4 TargetPos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("currentPerformer")] 
		public CWeakHandle<gameObject> CurrentPerformer
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ReprimandUpdate()
		{
			Target = new entEntityID();
			TargetPos = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
