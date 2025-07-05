using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmasherPlayVFX : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("vfxOffset")] 
		public Vector3 VfxOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("fxDirection")] 
		public CHandle<AIArgumentMapping> FxDirection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("attachmentSlotName")] 
		public CName AttachmentSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("KillFx")] 
		public CBool KillFx
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("effectToKill")] 
		public CName EffectToKill
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(8)] 
		[RED("vfxInstance")] 
		public CHandle<gameFxInstance> VfxInstance
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		[Ordinal(9)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SmasherPlayVFX()
		{
			VfxOffset = new Vector3();
			VfxResource = new gameFxResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
